using System;

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

                switch (userChoice)
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        string name = Console.ReadLine();
                        users.Add(name);
                        Console.WriteLine("Användare är tillagd");
                        break;
                case "2":

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
                    break;

                case "3":

                    Console.Write("Ange namn att ta bort: ");
                    string nameToRemove = Console.ReadLine();

                    if (users.Remove(nameToRemove))
                        Console.WriteLine("Användaren togs bort");

                    else
                        Console.WriteLine("Användaren hittades inte.");
                    break; 
                case "4":

                        Console.Write("Ange namn att söka: ");
                        string searchName = Console.ReadLine();

                    if (users.Contains(searchName))
                        Console.WriteLine("Användaren finns i listan");

                    else
                        Console.WriteLine("Användaren hittades inte");
                    break;

                case "5":

                    return;
                
                    default:
                        Console.WriteLine("Ogiltigt val. FÖrsök igen.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
