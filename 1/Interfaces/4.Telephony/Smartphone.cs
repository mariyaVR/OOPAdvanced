using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Telephony
{
    class Smartphone : ICalling, IBrowsing
    {
        public string Browsing(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";
        }

        public string Calling(string number)
        {
            if (!number.Any(c => char.IsDigit(c)))
            {
                return "Invalid number!";
            }
            return  $"Calling... {number}";
        }
    }
}