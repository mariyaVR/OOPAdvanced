using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.GenericBoxOfString

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Box<string> generic = new Box<string>(input);

            //    Console.WriteLine(generic);
            //}     

            //3.GenericBoxOfInt

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    Box<int> generic = new Box<int>(input);

            //    Console.WriteLine(generic);


            //4.Swap string
            //int n = int.Parse(Console.ReadLine());
            //List<Box<string>> genericList = new List<Box<string>>();
            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Box<string> genericString = new Box<string>(input);
            //    genericList.Add(genericString);
            //}
            //int[] swapPositionsInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int startIndex = swapPositionsInfo[0];
            //int lastIndex = swapPositionsInfo[1];
            //Box<string>.Swap(genericList, startIndex, lastIndex);
            //foreach (var generic in genericList)
            //{
            //    Console.WriteLine(generic);
            //}

            //5.Swap int
            //int n = int.Parse(Console.ReadLine());
            //List<Box<int>> genericList = new List<Box<int>>();
            //for (int i = 0; i < n; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    Box<int> genericInt = new Box<int>(input);
            //    genericList.Add(genericInt);
            //}
            //int[] swapPositionsInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int startIndex = swapPositionsInfo[0];
            //int lastIndex = swapPositionsInfo[1];
            //Box<int>.Swap(genericList, startIndex, lastIndex);
            //foreach (var generic in genericList)
            //{
            //    Console.WriteLine(generic);
            //}


        }
    }
}