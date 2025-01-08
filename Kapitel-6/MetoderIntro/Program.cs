/* *****************************************************
**********************M A I N***************************
****************************************************** */

Console.Clear();
Console.WriteLine("Hej Metoder!");

//Anropa metoden
SägHej();

//Anropa metoden meny
VisaMeny();

//Anropa metoden registrear namn
RegisterNamn();

/* *****************************************************
********************M E T O D E R***********************
****************************************************** */

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>

static void SägHej()
{
    Console.WriteLine("Var hälsad!");
}

/// <summary>
/// Metod för att visa meny
/// </summary>

static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut uppgifter
    4. Avsluta
    """);
}

/// <summary>
/// metod för att ange namn
/// </summary>

static void RegisterNamn()
{
    Console.Write("Ange namn: ");
    string namn = Console.ReadLine();
    Console.WriteLine($"Hej, {namn}");
}