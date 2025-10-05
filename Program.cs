using System;

namespace Kodanalys
{
    class program
    {
        static string[] numberOfUsers = new string[10];
        static int howManyUsers = 0;

        static void Main(string[] args)
        {
            bool banan = true;
            while (banan)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.Write("Ange namn: ");
                    string userName = Console.ReadLine();
                    if (howManyUsers < 10)
                    {
                        numberOfUsers[howManyUsers] = userName;
                        howManyUsers++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < howManyUsers; i++)
                    {
                        Console.WriteLine(numberOfUsers[i]);
                    }
                }
                else if (userInput == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string entitetsExcisionIdentifierare = Console.ReadLine();
                    int nanoBanana = -1;
                    for (int i = 0; i < howManyUsers; i++)
                    {
                        if (numberOfUsers[i] == entitetsExcisionIdentifierare)
                        {
                            nanoBanana = i;
                            break;
                        }
                    }

                    if (nanoBanana != -1)
                    {
                        for (int i = nanoBanana; i < howManyUsers - 1; i++)
                        {
                            numberOfUsers[i] = numberOfUsers[i + 1];
                        }
                        howManyUsers--;
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (userInput == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string nebulousQuery = Console.ReadLine();
                    bool f00l = false;
                    for (int i = 0; i < howManyUsers; i++)
                    {
                        if (numberOfUsers[i] == nebulousQuery)
                        {
                            f00l = true;
                            break;
                        }
                    }
                    if (f00l)
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (userInput == "5")
                {
                    userInput = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
