//Skapa ett program som skapar valfria åldersgränser
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ange ålder: ");
string ålderText = Console.ReadLine();
int ålder = int.Parse(ålderText);
Console.WriteLine(" ");

if (ålder > 17)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("DU FÅR SPELA:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("COUNTER STRIKE");
    Console.WriteLine("FORTNITE");
    Console.WriteLine("MINECRAFT");
    Console.WriteLine("ROBLOX");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("DU FÅR INTE SPELA:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("COUNTER STRIKE");

    if (ålder > 11)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" ");
        Console.WriteLine("DU FÅR SPELA:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("FORTNITE");
        Console.WriteLine("MINECRAFT");
        Console.WriteLine("ROBLOX");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("FORTNITE");

        if (ålder > 6)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
              Console.WriteLine("DU FÅR SPELA:");
              Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine("MINECRAFT");
              Console.WriteLine("ROBLOX");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MINECRAFT");

            if (ålder > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.WriteLine("DU FÅR SPELA:");
                Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine("ROBLOX");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ROBLOX");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DU ÄR INTE ENS FÖDD");
            }

        }

    }
}

Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine(" ");