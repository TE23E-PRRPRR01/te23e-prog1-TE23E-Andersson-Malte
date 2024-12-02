//Bordsbokning
using System.Runtime.ConstrainedExecution;

Console.Clear();
Console.WriteLine("Detta är Centralrestaurangens bordshanterare");

//Variabler
int svar = 0;
int antalBord = 8;

//Skapa en lsita på alla bord
List<string> bordsInformation = [];

//Hur EN bokning ser ut tom
string tomtBordBeskrivning = "0,Inga gäster";

//Fylla med 8 tomma bokningar
for (int i = 0; i < antalBord; i++)
{
    bordsInformation.Add(tomtBordBeskrivning);
}

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("""
    1. Visa alla bord
    2. Ändra bordsinformation
    3. Markera att ett bord är ledigt
    4. Avsluta programmet.
    """);
    Console.Write("Välj ett alternativ: ");
    bool lyckas = int.TryParse(Console.ReadLine(), out svar);

    if (svar == 1)
    {
        foreach (var bord in bordsInformation)
        {
            Console.WriteLine($"{bordsInformation}");
        }
    }
    else if (svar == 2)
    {
        //Boka ett bord
        Console.Write("Ange bordsnummer vill du ändra för? (1-8): ");
        int bordsnummer = int.Parse(Console.ReadLine());
        Console.Write("Ange bokningsnamn: ");
        string namn = Console.ReadLine();
        Console.Write("Ange antal gäster: ");
        int gäster = int.Parse(Console.ReadLine());
        bordsInformation[bordsnummer - 1] = $"{gäster},{namn}";
    }
    else if (svar == 3)
    {

    }
    else if (svar == 4)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Avslutar programmet...");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ogiltigt alternativ. Försök igen!");
    }
}
