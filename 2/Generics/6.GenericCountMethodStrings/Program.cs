using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //6
            //List<Box<string>> boxes = new List<Box<string>>();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    boxes.Add(new Box<string>(Console.ReadLine()));
            //}

            //Box<string> comparableBox = new Box<string>(Console.ReadLine());

            //int countOfGreaterElemts = CompareElements(boxes, comparableBox);
            //Console.WriteLine(countOfGreaterElemts);

            //7
            List<Box<double>> boxes = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<double>(double.Parse((Console.ReadLine()))));
            }

            Box<double> comparableBox = new Box<double>(double.Parse(Console.ReadLine()));

            int countOfGreaterElemts = CompareElements(boxes, comparableBox);
            Console.WriteLine(countOfGreaterElemts);
        }
        static int CompareElements<T>(List<Box<T>> boxes, Box<T> comparableBox) 
        where T:IComparable<T>
        {
            int count = boxes.Count(b => b.Value.CompareTo(comparableBox.Value) > 0);

            return count;
        }
    }
}