/***************
******MAIN******
***************/

VisaPresentation();

//Variabler
string filnamn = "meddelande.txt";

//Programloop
while(true)
{
    VisaMeny();
    string val = Console.ReadLine();
    
    if (val == "1")
    {
        SparaMeddelande(filnamn);
    }
    else if (val == "2")
    {
        LäsaMeddelande(filnamn);
    }
    else if (val == "3")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Avslutar...");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Försök igen!");
    }
}

/***************
*****METODER****
***************/

/// <summary>
/// Visar presentation av programmet
/// </summary>

static void VisaPresentation()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("""
    --------------------------------------------
     Program för att spara meddelande på disken
    --------------------------------------------
    """);
}

/// <summary>
/// Visar menyn med alla funktioner för programmet
/// </summary>

static void VisaMeny()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.Write("""
    1. Spara meddelande
    2. Läs meddelande
    3. Avsluta programmet
    Ange ditt val: 
    """);
}

/// <summary>
/// Sparar meddelande från användaren
/// </summary>

static void SparaMeddelande(string filen)
{
    Console.Write("\nAnge ett meddelande: ");
    string meddelande = Console.ReadLine();
    File.WriteAllText(filen, meddelande);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ditt meddelande har sparats!");

}

/// <summary>
/// Läser upp senaste meddelandet
/// </summary>

static void LäsaMeddelande(string filen)
{
    string meddelande = File.ReadAllText(filen);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nDitt meddelande:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(meddelande);
}