using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite
{
    using Interfaces;
    using Models;
    class SolderFactory
    {
        private static readonly List<Private> lstPrivate = new List<Private>();

        public static ISoldier ProduceSoldier(string input)
        {
            var command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var solder = command[0];
            var id = int.Parse(command[1]);
            var firstName = command[2];
            var lastName = command[3];
            switch (solder)
            {
                case "Private":
                    var salary = double.Parse(command[4]);
                    Private soldPrivate = new Private(id, firstName, lastName, salary);
                    lstPrivate.Add(soldPrivate);
                    return soldPrivate;
                    break;
                case "LeutenantGeneral":
                    var salaryGeneral = double.Parse(command[4]);
                    LeutenantGeneral LGeneral = new LeutenantGeneral(id, firstName, lastName, salaryGeneral);
                    try
                    {
                        for (int i = 5; i < command.Length; i++)
                        {
                            int idPrivate = int.Parse(command[i]);
                            var currPrivate = lstPrivate.First(x => x.Id == idPrivate);
                            if (currPrivate != null)
                            {
                                LGeneral.Privates.Add(currPrivate);
                            }
                        }
                    }
                    catch (Exception)
                    {


                    }
                    lstPrivate.Add(LGeneral);
                    return LGeneral;
                    break;

                case "Engineer":
                    var engSalary = double.Parse(command[4]);
                    var engCorp = command[5];
                    Engineer Engineer = new Engineer(id, firstName, lastName, engSalary, engCorp);

                    List<IRepair> repairs = new List<IRepair>();
                    for (int i = 6; i < command.Length - 1; i += 2)
                    {
                        string partName = command[i];
                        int workHours = int.Parse(command[i + 1]);
                        Engineer.AddRepair(new Repair(partName, workHours));
                    }
                    lstPrivate.Add(Engineer);
                    return Engineer;
                    break;

                case "Commando":
                    var commandoSalary = double.Parse(command[4]);
                    var commandoCopr = command[5];

                    Commando Commando = new Commando(id, firstName, lastName, commandoSalary, commandoCopr);
                    List<IMission> Missions = new List<IMission>();
                    for (int i = 6; i < command.Length - 1; i += 2)
                    {
                        string codeName = command[i];
                        string state = command[i + 1];
                        try
                        {
                            Commando.AddMisions(new Mission(codeName, state));

                        }
                        catch (Exception)
                        {
                        }
                    }
                    lstPrivate.Add(Commando);
                    return Commando;
                    break;

                case "Spy":
                    int codeNumber = int.Parse(command[3]);
                    Spy Spy = new Spy(id, firstName, lastName, codeNumber);
                    return Spy;
                    break;

                default: return null;
            }
        }
    }
}
