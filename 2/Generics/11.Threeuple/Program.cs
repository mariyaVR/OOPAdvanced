using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameAdressTown = Console.ReadLine().Split();
            string fullName = nameAdressTown[0] + " " + nameAdressTown[1];
            string adress = nameAdressTown[2];
            string town = nameAdressTown[3];

            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(fullName, adress, town);

            string[] personBeerDrunk = Console.ReadLine().Split();
            string person = personBeerDrunk[0];
            int beer = int.Parse(personBeerDrunk[1]);
            bool drunk;
            if (personBeerDrunk[2] == "drunk")
            {
                drunk = true;
            }
            else
            {
                drunk = false;
            }
            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>(person, beer, drunk);

            string[] personCashBank = Console.ReadLine().Split();
            string name = personCashBank[0];
            double cash = double.Parse(personCashBank[1]);
            string bank = personCashBank[2];
            Threeuple<string, double, string> thirdThreeuple = new Threeuple<string, double, string>(name, cash, bank);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
