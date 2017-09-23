using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            ListyIterator<string> listCollection = new ListyIterator<string>();
            while (input != "END")
            {
                string[] command = input.Split();
                string commandType = command[0];
                switch (commandType)
                {
                    case "Create":
                        List<string> givenCollection = new List<string>();
                        for (int i = 1; i < command.Length; i++)
                        {
                            givenCollection.Add(command[i]);
                        }
                        listCollection.Create(givenCollection);
                        break;
                    case "Move":
                        Console.WriteLine(listCollection.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listCollection.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listCollection.Print();

                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "PrintAll":
                        Console.WriteLine(listCollection.PrintAll());
                        break;
                }

                input = Console.ReadLine();
            }          
        }
    }
}