using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Park
{
    class Program
    {
        static void Main(string[] args)
        {

            //Note: in these project we use  ASCII art  to draw an image of our animals and activities 
            List<Animal> zoo = new List<Animal> //Общие рассмотрение животные
        {
            new Tigar("tigris", "groooowl!", 2.2, 200),
            new Kangaroo("boomer", "grunts!", 8, 120),
            new Elephant("Loxodonta", "Pawoo!", 8, 120)
        };

            VideoRecordAssistant assistant = new VideoRecordAssistant();
            Tigar tigar  = new Tigar ("tigris", "groooowl!", 2.2, 200);
            Kangaroo kangaroo = new Kangaroo("boomer", "grunts!", 8, 120);
            Elephant elephant = new Elephant("Loxodonta", "Pawoo!", 13.2, 6.350);

            Random random = new Random();

            bool exit = false;
            do
            {
                Console.WriteLine("1. Look at the animals");
                Console.WriteLine("2. Random View online via video surveillance");
                Console.WriteLine("3. Elephant: Walk around the zoo");
                Console.WriteLine("4. Elephant: Eat around the zoo");
                Console.WriteLine("5. Elephant: Sleep around the zoo");
                Console.WriteLine("6. Tigar: Walk around the zoo");
                Console.WriteLine("7. Tigar: Eat around the zoo");
                Console.WriteLine("8. Tigar: Sleep around the zoo");
                Console.WriteLine("9. Kanganroo: Walk around the zoo");
                Console.WriteLine("10. Kanganroo: Eat around the zoo");
                Console.WriteLine("11. Kanganroo: Sleep around the zoo");
                Console.WriteLine("12. Assistant: Walk around the zoo");
                Console.WriteLine("13. Assistant: Record video surveillance");
                Console.WriteLine("14. Exit");

                Console.Write("Choose an action: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Animal in ZooPark:");
                        foreach (var animal in zoo)
                        {
                            Console.WriteLine($"Name: {animal.Name, -10} with Sound: {animal.Sound, -10}");

                        }
                        break;

                    case "2":
                        Console.WriteLine("Online video surveillance:");
                        foreach (var animal in zoo)
                        {
                            if (random.Next(2) == 0)
                            {
                                Console.WriteLine($"Name: {animal.Name,-10} with sound: {animal.Sound,-10} is interacting.");
                            }
                            else
                            {
                                Console.WriteLine($"Name: {animal.Name, -10} with sound: {animal.Sound, -10} is Sleeping.");
                            }
                        }
                        break;
                    case "3":
                        elephant.Walk(); break;
                    case "4":
                        elephant.Eat(); break;
                    case "5":
                        elephant.Sleep(); break;
                    case "6":
                        tigar.Walk(); break;
                    case "7":
                        tigar.Eat(); break;
                    case "8":
                        tigar.Sleep(); break;
                    case "9":
                        kangaroo.Walk(); break;
                    case "10":
                        kangaroo.Eat(); break;
                    case "11":
                        kangaroo.Sleep(); break;
                    case "12":
                        assistant.Walk(); break;
                    case "13":
                        assistant.VideoRecord(); break;
                    case "14": exit = true; break;
                    default:
                        Console.WriteLine("Incorrect choice. Please select again.");
                        break;
                }

                Console.WriteLine();
            } while (!exit);
        }
    }
}
