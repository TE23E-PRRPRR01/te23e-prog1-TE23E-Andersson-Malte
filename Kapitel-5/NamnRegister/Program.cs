//Litet namnregister
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("Ett litet namnregister");

    string namn;
    List<string> namnLista = [];

//programloopne
while (true)
{
    Console.ForegroundColor = ConsoleColor.White;

    //visa en meny
    System.Console.Write("""
1. Registrera namn
2. Skriv ut alla namn
3. Avsluta
Ange ditt val: 
""");

    string val = Console.ReadLine();


    if (val == "1")
    {
        Console.Write("\nAnge ett namn: ");
        namn = Console.ReadLine();
        namnLista.Add(namn);
    }
    else if (val == "2")
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (var namnet in namnLista)
        {
            Console.Write($"{namnet}, ");
        }
    } else if (val == "3")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Avslutar...");
        break;
    }

System.Console.WriteLine(" ");
}

Console.ForegroundColor = ConsoleColor.White;