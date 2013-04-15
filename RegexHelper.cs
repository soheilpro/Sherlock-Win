using System;
using System.Text.RegularExpressions;

namespace Sherlock
{
    public static class RegexHelper
    {
        private static Regex _urlRegex = new Regex(@"^https?://([\w-]+\.)+[\w-]+(:\d+)?(/[\w- ./?%&=]*)?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static Regex _emailRegex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static Regex UrlRegex
        {
            get
            {
                return _urlRegex;
            }
        }

        public static Regex EMailRegex
        {
            get
            {
                return _emailRegex;
            }
        }
    }
}
