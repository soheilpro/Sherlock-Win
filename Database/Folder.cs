using System;
using System.Xml.Serialization;

namespace Sherlock.Database
{
    [Serializable]
    public class Folder
    {
        private string _name;
        private Folder _parent;
        private ItemCollection _items = new ItemCollection();
        private FolderCollection _folders = new FolderCollection();

        [XmlAttribute("name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

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

        [XmlElement("item")]
        public ItemCollection Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        [XmlElement("category")]
        public FolderCollection Folders
        {
            get
            {
                return _folders;
            }
            set
            {
                _folders = value;
            }
        }

        public Folder()
        {
        }

        public Folder(string name)
        {
            _name = name;
            _folders.Parent = this;
            _items.Parent = this;
        }

        public void RemoveMe()
        {
            _parent.Folders.Remove(this);
        }

        public void Clear()
        {
            _items.Clear();
            _folders.Clear();
        }
    }
}
