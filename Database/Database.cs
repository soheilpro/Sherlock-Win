using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace Sherlock.Database
{
    [XmlRoot("data")]
    public class Database : Folder
    {
        private string _filename;
        private string _password;
        private string _version;

        [XmlAttribute("version")]
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }

        [XmlIgnore]
        public string Fileame
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
            }
        }

        [XmlIgnore]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public Database()
        {
            Folders.Parent = this;
        }

        public static Database Load(string filename, string password)
        {
            Stream stream = null;
            Database database;

            try
            {
                stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);

                if (password != null)
                {
                    var des = CreateTripleDEPS(password);
                    stream = new CryptoStream(stream, des.CreateDecryptor(), CryptoStreamMode.Read);
                }

                var serializer = new XmlSerializer(typeof(Database));

                database = (Database)serializer.Deserialize(stream);
                database._filename = filename;
                database._password = password;

                SetFolderItemParents(database);
            }
            catch (CryptographicException)
            {
                throw new InvalidPasswordException();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidPasswordException();
            }
            finally
            {
                // There's a bug in CryptoStream
                try
                {
                    if (stream != null)
                        stream.Dispose();
                }
                catch
                {
                }
            }

            return database;
        }

        private static void SetFolderItemParents(Folder folder)
        {
            folder.Items.Parent = folder;
            
            foreach (Item item in folder.Items)
            {
                item.Parent = folder;
            }

            folder.Folders.Parent = folder;

            foreach (Folder subFolder in folder.Folders)
            {
                subFolder.Parent = folder;
                SetFolderItemParents(subFolder);
            }
        }

        public void Save(string filename)
        {
            Stream stream = new FileStream(filename, FileMode.Create);

            if (_password != null)
            {
                var des = CreateTripleDEPS(_password);
                stream = new CryptoStream(stream, des.CreateEncryptor(), CryptoStreamMode.Write);
            }

            var serializer = new XmlSerializer(typeof(Database));

            using (stream)
                serializer.Serialize(stream, this);

            _filename = filename;
        }

        public void Save()
        {
            Save(_filename);
        }

        private static TripleDES CreateTripleDEPS(string password)
        {
            var des = TripleDES.Create();

            // Use password as key
            var key = password;

            // Make sure key is 24 bytes (192 bits) at least
            while (key.Length < 24)
                key += password;

            // Make sure key is no longer that 24 bytes (192 bits)
            if (key.Length > 24)
                key = key.Substring(0, 24);

            // Use password as IV
            var iv = password;

            // Make sure key is 16 bytes (128 bits) at least
            while (iv.Length < 8)
                iv += password;

            // Make sure key is no longer that 24 bytes (192 bits)
            if (iv.Length > 8)
                iv = key.Substring(0, 8);

            des.Key = Encoding.UTF8.GetBytes(key);
            des.IV = Encoding.UTF8.GetBytes(iv);

            return des;
        }

        public static bool IsWeakPassword(string password)
        {
            try
            {
                CreateTripleDEPS(password);
            }
            catch (CryptographicException)
            {
                return true;
            }

            return false;
        }
    }
}
