using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake();
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                Stone stone = new Stone(number);
                lake.Collection.Add(stone);
            }
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}