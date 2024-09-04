Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Klicka ENTER för att gå vidare.");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Du vaknar upp i ett rum...");
Console.ReadLine();
Console.Write("Framför dig finns två dörrar, 1 och 2. Vilken väljer du? ");
string svar = Console.ReadLine().ToLower();
Console.Clear();

if (svar == "1")
{
    Console.WriteLine("Du passerar genom den första dörren...");
    Console.ReadLine();
      Console.WriteLine("...och ner för en trappa.");
    Console.ReadLine();
    Console.Write("Du finner en halv brödbit på ett av trappstegen. Vill du äta den (j/n)? ");
    svar = Console.ReadLine().ToLower();

    if (svar == "j")
    {
        Console.Clear();
        Console.WriteLine("Du äter upp brödbiten och fortsätter ner för trappen.");
        Console.ReadLine();
        Console.WriteLine("Du kommer in i en stor sal.");
        Console.ReadLine();
        Console.WriteLine("Du känner dig trött och somnar på golvet...");
        Console.WriteLine(" ");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Du struntar i brödbiten och fortsätter ner för trappen.");
        Console.ReadLine();
        Console.WriteLine("Plötsligt halkar du på brödbiten och slår i huvudet!");
        Console.ReadLine();
        Console.WriteLine("Det blir svart för ögonen...");
        Console.WriteLine(" ");
    }
}
else
{
    Console.WriteLine("Du passerar genom den andra dörren...");
    Console.ReadLine();
      Console.WriteLine("...och genom en lång korridor.");
    Console.ReadLine();
    Console.Write("Du finner en flaska med en märklig vätska. Vill du dricka den (j/n)? ");
    svar = Console.ReadLine().ToLower();

    if (svar == "j")
    {
        Console.Clear();
        Console.WriteLine("Du dricker upp vätskan i flaskan och fortsätter genom korridoren.");
        Console.ReadLine();
        Console.WriteLine("Plötsligt mår du inte så bra.");
        Console.ReadLine();
        Console.WriteLine("Du kollapsar på golvet i korridoren...");
        Console.WriteLine(" ");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Du plockar upp flaskan och slänger den i väggen...");
        Console.ReadLine();
        Console.WriteLine("...sedan fortsätter du genom korridoren.");
        Console.ReadLine();
        Console.WriteLine("Du går så länge att du somnar på golvet...");
        Console.WriteLine(" ");
    }
}

Console.ForegroundColor = ConsoleColor.White;