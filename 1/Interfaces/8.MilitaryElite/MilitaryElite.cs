using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Interfaces
{
    class MilitaryElite
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<ISoldier> army = new List<ISoldier>();

            while (input != "End")
            {
                try
                {
                    army.Add(SolderFactory.ProduceSoldier(input));
                }
                catch (Exception)
                {

                }
                input = Console.ReadLine();
            }


            foreach (var soldier in army)
            {
                try
                {
                    Console.WriteLine(soldier.ToString());

                }
                catch (Exception)
                {


                }

            }
        }
    }
}
