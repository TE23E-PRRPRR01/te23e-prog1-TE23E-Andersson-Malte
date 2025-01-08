/* *****************************************************
***********************M A I N**************************
****************************************************** */

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejNamn("Greger");

TalIKvadrat();

/* *****************************************************
********************M E T O D E R***********************
****************************************************** */

/// <summary>
/// Skriv ut hälsning med namn
/// </summary>
/// <param name="namn">Namnet</param>

static void SägHejNamn(string namn)
{
    Console.WriteLine($"Var hälsad {namn}!");
}

/// <summary>
/// Metod för tal i kvadrat
/// </summary>

static void TalIKvadrat()
{
    Console.Write("Ange ett tal: ");
    int tal = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ditt tal i kvadrat: {tal*tal}");
    
}