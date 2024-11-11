// slumpa många tal och spara i lista
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("SLUMPA MÅNGA TAL OCH SPARA I LISTA");
Console.WriteLine(" ");

//Globala variabler
//EN lista för heltal
List<int> listaSlumptal = [];

//Be användaren ange antal slumptal
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ange antal slumptal: ");
int antal = int.Parse(Console.ReadLine());

//Be användaren ange min & max slumptal
Console.Write("Ange minvärde: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange maxvärde: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine(" ");


//Loopa 5 ggr
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < antal; i++)
{
    //Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    //Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);

    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");

}

Console.ForegroundColor = ConsoleColor.White;