//Slumpa städer
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("SLUMPA EN TYSK STAD");
System.Console.WriteLine(" ");

//Skapa en lista för kort
Console.ForegroundColor = ConsoleColor.White;
List<string> stader = ["BERLIN","HAMBURG","KÖLN","MÜNCHEN","FRANKFURT"];

int antal = 0;

while (antal < 2)
{
    //Slumpa index 0-12
    int index = Random.Shared.Next(0, 6);

    //Plocka ut RANDOM STAD
    string stad = stader[index];

    //Skriv ut STADEN
    Console.WriteLine($"DIN SLUMPADE STAD ÄR {stad}");
    
    //Räkna upp
    antal++;
}