using System;
using System.Xml.Serialization;

namespace Sherlock.Database
{
    [Serializable]
    public class Item
    {
        private string _name;
        private string _value;
        private ItemType _type;
        private Folder _parent;

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

        [XmlText]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        [XmlAttribute("type")]
        public ItemType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
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

        public Item()
        {
        }

        public Item(string name, string value, ItemType type)
        {
            _name = name;
            _value = value;
            _type = type;
        }

        public void RemoveMe()
        {
            _parent.Items.Remove(this);
        }
    }
}
