using System;
using System.ComponentModel.Design;

namespace Kodanalys
{
    class Program
    {
        static List<string> users = new List<string>();
        
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.Write("Ange namn: ");
                    string name = Console.ReadLine();

                    users.Add(name);
                    Console.WriteLine("Användare är tillagd");

                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Användare:");
                    if (users.Count == 0)
                    {
                        Console.WriteLine("inga användare ännu.");
                    }
                    else
                    {
                        foreach (var user in users)
                        {
                            Console.WriteLine(user);
                        }
                    }
                }
                else if (userChoice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string nameToRemove = Console.ReadLine();

                    if (users.Remove(nameToRemove))
                    {
                        Console.WriteLine("Användaren togs bort");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (userChoice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string searchName = Console.ReadLine();

                    if (users.Contains(searchName))
                    {
                        Console.WriteLine("Användaren finns i listan");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte");
                    }
                }
                else if (userChoice == "5")
                
                        break;
            }
        }
    }
}
