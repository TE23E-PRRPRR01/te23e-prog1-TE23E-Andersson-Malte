Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Skriv i små bokstäver och klicka ENTER för att gå vidare.");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Du vaknar upp i ett rum...");
Console.ReadLine();
Console.Write("Framför dig finns två dörrar, 1 och 2. Vilken väljer du? ");
string svar = Console.ReadLine();
Console.Clear();

if (svar == "1")
{
    Console.WriteLine("Du passerar genom den första dörren...");
    Console.ReadLine();
      Console.WriteLine("och ner för en trappa...");
    Console.ReadLine();
    Console.Write("Du finner en halv brödbit på ett av trappstegen. Vill du äta den (j/n)? ");
    svar = Console.ReadLine();
}
else
{
    Console.WriteLine("Du passerar genom den andra dörren...");
}

