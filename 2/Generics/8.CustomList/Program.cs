using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //8
            //CustomList<string> numbers = new CustomList<string>();

            //string input = Console.ReadLine();
            //while (input!="END")
            //{
            //    string[] inputArgs = input.Split();
            //    switch (inputArgs[0])
            //    {
            //        case "Add":
            //            numbers.Add(inputArgs[1]);
            //            break;
            //        case "Remove":
            //            numbers.Remove(int.Parse(inputArgs[1]));
            //            break;
            //        case "Contains":
            //            Console.WriteLine(numbers.Contains(inputArgs[1]));
            //            break;
            //        case "Swap":
            //            numbers.Swap(int.Parse(inputArgs[1]), int.Parse(inputArgs[2]));
            //            break;
            //        case "Greater":
            //            Console.WriteLine(numbers.CountOfElementsGreaterThan(inputArgs[1]));
            //            break;
            //        case "Max":
            //            Console.WriteLine(numbers.Max());
            //            break;
            //        case "Min":
            //            Console.WriteLine(numbers.Min());
            //            break;
            //        case "Print":
            //            Console.WriteLine(numbers.ToString());
            //            break;
            //    }

            //    input = Console.ReadLine();
            //}

            //9

            string input = Console.ReadLine();
            CustomList<string> ourList = new CustomList<string>();
            while (input != "END")
            {
                string[] commandInfo = input.Split();
                switch (input)
                {
                    case "Min":
                        Console.WriteLine(ourList.Min());
                        break;
                    case "Max":
                        Console.WriteLine(ourList.Max());
                        break;
                    case "Print":
                        ourList.Print();
                        break;
                    case "Sort":
                        ourList = Sorter.Sort(ourList);
                        break;
                }
                if (input.Contains("Add"))
                {
                    string textToAdd = commandInfo[1];
                    ourList.Add(textToAdd);
                }
                else if (input.Contains("Remove"))
                {
                    int indexToRemove = int.Parse(commandInfo[1]);
                    ourList.Remove(indexToRemove);

                }
                else if (input.Contains("Contains"))
                {
                    Console.WriteLine(ourList.Contains(commandInfo[1]));
                }
                else if (input.Contains("Swap"))
                {
                    int firstIndex = int.Parse(commandInfo[1]);
                    int secondIndex = int.Parse(commandInfo[2]);
                    ourList.Swap(firstIndex, secondIndex);
                }
                else if (input.Contains("Greater"))
                {
                    Console.WriteLine(ourList.CountOfElementsGreaterThan(commandInfo[1]));
                }
                input = Console.ReadLine();
            }
        }
    }
}