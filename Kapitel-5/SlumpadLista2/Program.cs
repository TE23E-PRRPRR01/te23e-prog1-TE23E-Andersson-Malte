// Skapa lista med slumpade tal

/* ************************************************************
**                            Main                           **
************************************************************ */

// Validera användarens inmatning
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("GENERERA SLUMPTAL");

//Deklarera variabler

//Skapa en tom lista för att spara dess slumpade tal
List<int> listaSlumptal = [];

//Fråga igen tills användaren matar in ett giltigt svar
int antal = LäsInHeltal();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Du vill ha {antal} slumptal!");
Console.WriteLine(" ");

//Användaren matar in min-värde
int min = LäsInHeltal();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Ditt minvärde är {min}");
Console.WriteLine(" ");

//Användaren matar in max-värde
int max = LäsInHeltal();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Ditt maxvärde är {max}");
Console.WriteLine(" ");

//Slumpa fram tal
for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"DITT SLUMPTAL ÄR {slumptal}");

}

/* ************************************************************
**                     Mina egna metoder                     **
 *********************************************************** */

static int LäsInHeltal()
{
    //Fråga använderan om max-värde
    int heltal = 0;
    while (true)
    {

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ange maximumvärde: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ange ett giltigt värde");
        }
    }
    return heltal;
}
