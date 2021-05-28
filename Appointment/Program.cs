using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment
{
    class Program
    {
        static AppointmentRepository repo = new AppointmentRepository();
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.Write("Enter a day: ");
                            int dayNumber = int.Parse(Console.ReadLine());
                            if (dayNumber <= 0 && dayNumber > 31)
                            {
                                Console.WriteLine("Time is not valid!");
                                Console.ReadKey();
                                break;
                            }
                            int count = repo.AppointmentCount(dayNumber);
                            if (count == 4)
                            {
                                Console.WriteLine("Select another day!");
                                Console.ReadKey();
                                break;
                            }
                            Console.Write("Enter a name: ");
                            string name = Console.ReadLine();
                            Appointment ap = new Appointment()
                            {
                                DayNumber = dayNumber,
                                Name = name
                            };
                            repo.Add(ap);
                            Console.WriteLine("Appointment set!");
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Appointment result = repo.Get(name);
                            if (result == null)
                            {
                                Console.WriteLine("Name not found!");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("The time is " + result.DayNumber);
                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        Console.Clear();
                        foreach (var item in repo.GetAll())
                        {
                            Console.Write("Name: " + item.Name);
                            Console.WriteLine("    Day: " + item.DayNumber);
                        }
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1) Add an appointment");
            Console.WriteLine("2) Search appointment");
            Console.WriteLine("3) Print all appointments");
            Console.WriteLine();
            Console.Write("Choose: ");
        }
    }
}
