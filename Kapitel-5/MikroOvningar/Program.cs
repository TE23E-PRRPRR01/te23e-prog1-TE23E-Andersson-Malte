//Mikroövningar (listor)
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

//Skapa lista
List<string> namnLista = ["George", "Torkel", "Bengt"];

while (true)
{
    Console.WriteLine("""
    1. Visa lista
    2. Lägg till i lista
    3. Ta bort från lista
    4. Sök i lista
    5. Sortera lista
    6. Avsluta
    """);

    Console.Write("Vad vill du göra?: ");
    int menySvar = int.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    if (menySvar == 1)
    {
        //Skriv ut lista
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Nuvarande lista: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(string.Join(", ", namnLista));
    }
    if (menySvar == 2)
    {
        Console.Write("Ange ett namn att lägga till: ");
        namnLista.Add(Console.ReadLine());

    }
    if (menySvar == 3)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ange ett namn att ta bort: ");
            string namnAttTaBort = Console.ReadLine();

            if (namnLista.Contains(namnAttTaBort))
            {
                namnLista.Remove(namnAttTaBort);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Lista efter borttagning: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(string.Join(", ", namnLista));
                Console.WriteLine("");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fel: {namnAttTaBort} finns inte i listan.");
                Console.WriteLine(" ");
            }
        }
    }

    if (menySvar == 4)
    {
        Console.Write("Ange ett namn att söka efter: ");
        string namnAttSökaEfter = Console.ReadLine();

        if (namnLista.Contains(namnAttSökaEfter))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{namnAttSökaEfter} finns i listan.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{namnAttSökaEfter} finns inte i listan.");
        }
    }
    if (menySvar == 5)
    {
        namnLista.Sort();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Listan är sorterad");
    }
    if (menySvar == 6)
    {
        break;
    }
Console.ReadLine();
    Console.Clear();
}