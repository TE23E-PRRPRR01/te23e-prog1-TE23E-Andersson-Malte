//Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("SLUMPA KORT UR EN KORTLEK");
System.Console.WriteLine(" ");

//Skapa en lista för kort
Console.ForegroundColor = ConsoleColor.White;
//List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];
List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮","😃"];

int antal = 0;

while (antal < 5)
{
    //Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);

    //Plocka ut RANDOM KORT
    string kort = kortlek[index];

    //Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    //Skriv ut kortet
    Console.WriteLine($"DITT SLUMPADE KORT ÄR {kort}");
    
    //Räkna upp
    antal++;
}