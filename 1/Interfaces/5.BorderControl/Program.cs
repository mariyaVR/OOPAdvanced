using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //string command = Console.ReadLine(); //5
            //List<IIdentifiable> beings = new List<IIdentifiable>();
            //while (!command.Equals("End"))
            //{
            //    string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    if (input.Length == 3)
            //    {
            //        Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2]);
            //        beings.Add(citizen);
            //    }
            //    else if(input.Length == 2)
            //    {
            //        Robot robot = new Robot(input[0], input[1]);
            //        beings.Add(robot);
            //    }

            //    command = Console.ReadLine();
            //}

            //string fake = Console.ReadLine();

            //foreach (var b in beings)
            //{
            //    if (b.ID.EndsWith(fake))
            //    {
            //        Console.WriteLine(b.ID);
            //    }
            //}

            //string command = Console.ReadLine(); //6
            //List<IBirthDate> beings = new List<IBirthDate>();
            //while (!command.Equals("End"))
            //{
            //    string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    switch (input[0])
            //    {
            //        case "Citizen":
            //            var citizen = input[1];
            //            var age = int.Parse(input[2]);
            //            var id = input[3];
            //            var birthDayCitizen = input[4];
            //            beings.Add(new Citizen(citizen, age, id, birthDayCitizen));
            //            break;

            //        case "Pet":
            //            var pet = input[1];
            //            var birthDayPet = input[2];
            //            beings.Add(new Pet(pet, birthDayPet));
            //            break;
            //    }

            //    command = Console.ReadLine();
            //}

            //string year = Console.ReadLine();

            //var result = beings.Where(b => b.BirthDate.EndsWith(year));
            //foreach (var being in result)
            //{
            //    Console.WriteLine(being.BirthDate);
            //}

            int numberOfPeople = int.Parse(Console.ReadLine());
            List<IBuyer> people = new List<IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);
                if (input.Length == 4)
                {
                    string id = input[2];
                    string birthday = input[3];
                    people.Add(new Citizen(name, age, id, birthday));
                }
                else
                {
                    string group = input[2];
                    people.Add(new Rebel(name, age, group));
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (people.Any(p => p.Name == command))
                {
                    IBuyer curBuyer = people.Where(p => p.Name == command).First();
                    curBuyer.BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(people.Sum(p => p.Food));
        }
    }
}