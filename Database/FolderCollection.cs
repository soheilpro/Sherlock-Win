using System;
using System.Collections;
using System.Xml.Serialization;

namespace Sherlock.Database
{
    [Serializable]
    public class FolderCollection : CollectionBase
    {
        private Folder _parent;

        [XmlIgnore]
        public Folder Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        public void Add(Folder folder)
        {
            folder.Parent = _parent;

            List.Add(folder);
        }

        public Folder Add(string name)
        {
            var newFolder = new Folder(name);
            newFolder.Parent = _parent;

            Add(newFolder);

            return newFolder;
        }

        public void Remove(Folder folder)
        {
            List.Remove(folder);
        }

        public Folder this[int index]
        {
            get
            {
                return (Folder)List[index];
            }
        }
    }
}
