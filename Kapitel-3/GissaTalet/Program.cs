//Ett litet spel - gissa ett hemligt heltal
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(" ");
Console.WriteLine("ETT LITET SPEL DÄR DU SKA GISSA ETT HEMLIGT HELTAL");
Console.WriteLine(" ");

//slumpa talet
Console.ForegroundColor = ConsoleColor.White;
int slumptalet = Random.Shared.Next(1, 101); //1-100
Console.WriteLine($"Slumptalet är {slumptalet}");

Console.Write("Gissa ett tal 1-100: ");
//Läs in texten
 string gissningText= Console.ReadLine();
 //Konvertera texten till ett heltal
int gissning = int.Parse(gissningText);

if (gissning == slumptalet)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" ");
    Console.WriteLine("DU GISSADE RÄTT!");
}
else
{
   if (gissning < slumptalet)
{
    Console.ForegroundColor = ConsoleColor.Red;
       Console.WriteLine(" ");
    Console.WriteLine("DU GISSADE FÖR LÅGT!");
}
   else
{
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine(" ");
   Console.WriteLine("DU GISSADE FÖR HÖGT!"); 
}
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" ");




