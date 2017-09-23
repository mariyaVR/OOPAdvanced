using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0]!="END")
            {
                switch (input[0])
                {
                    case "Push":
                        if (input[0] == "Push")
                        {
                            for (int i = 1; i < input.Length; i++)
                            {
                                myStack.Push(input[i]);
                            }
                        }
                        break;
                    case "Pop":
                        myStack.Pop();
                        break;
                }

                input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}