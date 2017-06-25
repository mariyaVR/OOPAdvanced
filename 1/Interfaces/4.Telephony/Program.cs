using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split();

            foreach (string phoneNumber in phoneNumbers)
            {
                Smartphone Call = new Smartphone();
                Console.WriteLine(Call.Calling(phoneNumber));
            }
            var webAddress = Console.ReadLine().Split();
            foreach (string url in webAddress)
            {
                Smartphone tel = new Smartphone();
                Console.WriteLine(tel.Browsing(url));
            }
        }
    }
}
