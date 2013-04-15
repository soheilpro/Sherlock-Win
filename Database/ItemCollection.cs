using System;
using System.Collections;
using System.Xml.Serialization;

namespace Sherlock.Database
{
    [Serializable]
    public class ItemCollection : CollectionBase
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

        public void Add(Item item)
        {
            item.Parent = _parent;

            List.Add(item);
        }

        public Item Add(string name, string value, ItemType type)
        {
            var newItem = new Item(name, value, type);
            newItem.Parent = _parent;

            Add(newItem);

            return newItem;
        }

        public void Remove(Item item)
        {
            List.Remove(item);
        }

        public Item this[int index]
        {
            get
            {
                return (Item)List[index];
            }
        }
    }
}
