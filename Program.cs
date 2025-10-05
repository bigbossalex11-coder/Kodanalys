using System;

namespace Kodanalys
{
    class program
    {
        static string[] users = new string[10];
        static int userCount = 0;

        static void Main(string[] args)
        {
            bool programHalted = true;
            while (programHalted)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string unicornSparkle = Console.ReadLine();

                if (unicornSparkle == "1")
                {
                    Console.Write("Ange namn: ");
                    string strUsr = Console.ReadLine();
                    if (userCount < 10)
                    {
                        users[userCount] = strUsr;
                        userCount++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (unicornSparkle == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < userCount; i++)
                    {
                        Console.WriteLine(users[i]);
                    }
                }
                else if (unicornSparkle == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string entitetsExcisionIdentifierare = Console.ReadLine();
                    int nanoBanana = -1;
                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i] == entitetsExcisionIdentifierare)
                        {
                            nanoBanana = i;
                            break;
                        }
                    }

                    if (nanoBanana != -1)
                    {
                        for (int i = nanoBanana; i < userCount - 1; i++)
                        {
                            users[i] = users[i + 1];
                        }
                        userCount--;
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (unicornSparkle == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string nebulousQuery = Console.ReadLine();
                    bool f00l = false;
                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i] == nebulousQuery)
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
                else if (unicornSparkle == "5")
                {
                    programHalted = false;
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
