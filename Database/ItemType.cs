using System;
using System.Xml.Serialization;

namespace Sherlock.Database
{
    public enum ItemType
    {
        [XmlEnum("text")]
        Text = 0,

        [XmlEnum("password")]
        Secret = 1,

        [XmlEnum("url")]
        Url = 2,

        [XmlEnum("email")]
        EMail = 3
    }
}
