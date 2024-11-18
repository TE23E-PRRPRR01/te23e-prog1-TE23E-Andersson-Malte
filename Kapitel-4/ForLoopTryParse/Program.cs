// ForLoopTryParse
Console.Clear();

int antal = 0;
int tal = 0;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("ForLoopTryParse");
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Hur många gångar ska namnet loopas?: ");
        bool lyckad = int.TryParse(Console.ReadLine(), out antal);
        if (antal >= 1 && antal <= 10)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Talet måste vara mellan 1 och 10. Försök igen!");
        }
    }

    Console.ForegroundColor = ConsoleColor.White;
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine($"{i}. Malte A");
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nAnge ett tal: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out tal);

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Multiplicerat med 2: {tal * 2}");
    Console.WriteLine($"Dividerat med 2: {tal / 2}");
    Console.WriteLine($"Adderat med 2: {tal + 2}");
    Console.WriteLine($"Subtraherat med 2: {tal - 2}");
    Console.WriteLine($"Upphöjt med 2: {tal * tal}");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nVill du köra programmet igen? (j/n):");
    string svar = Console.ReadLine().ToLower();
    if (svar == "n")
    {
        break;
    }
    Console.Clear();
}