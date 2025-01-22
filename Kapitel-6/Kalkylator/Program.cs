/**********
Main
**********/

using System.Security.Claims;

VisaPresentation();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        UtförAddition();
    }
    else if (val == "2")
    {
        UtförSubtraktion();
    }
    else if (val == "3")
    {
        UtförMultiplikation();
    }
    else if (val == "4")
    {
        UtförDivision();
    }
    else if (val == "5")
    {
        Console.WriteLine("Hejdå");
        break;
    }
    else
    {
        Console.WriteLine("Försök igen");
    }
}

/**********
Metoder
**********/

/// <summary>
/// visar Välkomsttext
/// </summary>

static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("""
    ===========================
    Välkommen till miniräknaren
    ===========================
    """);
}

static void VisaMeny()
{
    Console.Write("""
    1. Addition
    2. Subtraktion
    3. Multiplikation
    4. Division
    5. Avsluta programmet
    Ange ett alternativ: 
    """);
}

static void UtförAddition()
{
    Console.Write("Ange första talet: ");
    int förstaTalet = int.Parse(Console.ReadLine());
    Console.Write("Ange andra talet: ");
    int andraTalet = int.Parse(Console.ReadLine());
    Console.WriteLine($"{förstaTalet} + {andraTalet} = {förstaTalet + andraTalet}");
}

static void UtförSubtraktion()
{
    Console.Write("Ange första talet: ");
    int förstaTalet = int.Parse(Console.ReadLine());
    Console.Write("Ange andra talet: ");
    int andraTalet = int.Parse(Console.ReadLine());
    Console.WriteLine($"{förstaTalet} - {andraTalet} = {förstaTalet - andraTalet}");
}

static void UtförMultiplikation()
{
    Console.Write("Ange första talet: ");
    int förstaTalet = int.Parse(Console.ReadLine());
    Console.Write("Ange andra talet: ");
    int andraTalet = int.Parse(Console.ReadLine());
    Console.WriteLine($"{förstaTalet} * {andraTalet} = {förstaTalet * andraTalet}");
}

static void UtförDivision()
{
    Console.Write("Ange första talet: ");
    int förstaTalet = int.Parse(Console.ReadLine());
    Console.Write("Ange andra talet: ");
    int andraTalet = int.Parse(Console.ReadLine());
    Console.WriteLine($"{förstaTalet} / {andraTalet} = {förstaTalet / andraTalet}");
}
