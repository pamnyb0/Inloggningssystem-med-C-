using System;

class Program
{
    static void Main(string[] args)
    {
        // Arrayer för användarnamn och lösenord
        string[] användarnamn = new string[10];
        string[] lösenord = new string[10];
        int antalAnvändare = 0;

        bool körProgram = true;

        while (körProgram)
        {
            // Ställ in färg för välkomstmeddelande
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Välkommen till inloggningssidan!");

            // Ställ in ("Dark Magenta") färg för menyalternativ
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Log in");
            Console.WriteLine("3. Avsluta");

            // Läsa användarens val
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nAnge ditt val: ");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    // Skapa nytt konto
                    if (antalAnvändare < användarnamn.Length)
                    {
                        Console.WriteLine("\n== Sign In ==");
                        Console.Write("Ange ett användarnamn: ");
                        string nyttAnvändarnamn = Console.ReadLine();

                        Console.Write("Ange ett lösenord: ");
                        string nyttLösenord = Console.ReadLine();

                        användarnamn[antalAnvändare] = nyttAnvändarnamn;
                        lösenord[antalAnvändare] = nyttLösenord;
                        antalAnvändare++;

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Du har skapat ett konto. Gå tillbaka till huvudmenyn för att logga in.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Användarlistan är full. Kan inte registrera fler konton.");
                    }
                    break;

                case "2":
                    // Logga in :)
                    Console.WriteLine("\n== Log In ==");
                    Console.Write("Användarnamn: ");
                    string inloggningsAnvändarnamn = Console.ReadLine();

                    Console.Write("Lösenord: ");
                    string inloggningsLösenord = Console.ReadLine();

                    bool inloggad = false;

                    for (int i = 0; i < antalAnvändare; i++)
                    {
                        if (användarnamn[i] == inloggningsAnvändarnamn && lösenord[i] == inloggningsLösenord)
                        {
                            inloggad = true;
                            break;
                        }
                    }

                    if (inloggad)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Inloggning lyckades!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Inloggning misslyckades! Försök igen.");
                    }
                    break;

                case "3":
                    // Avsluta programmet
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Programmet avslutas. Tack för att du använde systemet!");
                    körProgram = false;
                    break;

                default:
                    // Felaktigt val
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Felaktigt val. Försök igen.");
                    break;
            }
        }
    }
}
