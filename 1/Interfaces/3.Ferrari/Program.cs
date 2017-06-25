using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameDriver = Console.ReadLine();
            var car = new Ferrari("488-Spider", nameDriver);
            Console.WriteLine($"{car.Model}/{car.UseBrakes()}/{car.GasPedal()}/{car.Driver}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}