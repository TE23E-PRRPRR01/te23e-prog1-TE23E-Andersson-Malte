// Program för quiz

Console.Clear();
int score = 0;

//ange namn
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine();

//Fråga 1

while (true)
{
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 1: Vad är Sveriges huvudstad?");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("a) Danmark");
System.Console.WriteLine("b) Stockholm");
System.Console.WriteLine("c) Kiruna");
Console.Write("Ditt svar: ");
string f1 = Console.ReadLine();

if (f1 == "b")
{
     Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Helt rätt {namn}!");
        Thread.Sleep(1000);

    score++;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Helt fel {namn}!");
        Thread.Sleep(1000);

}

//Fråga 2

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 2: Vilken är Svergies högsta berg?");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("a) Kebabnekaise");
System.Console.WriteLine("b) Mt. Everest");
System.Console.WriteLine("c) Kebnekaise");
Console.Write("Ditt svar: ");
string f2 = Console.ReadLine();

if (f2 == "c")
{
     Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Helt rätt {namn}!");
        Thread.Sleep(1000);

    score++;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Helt fel {namn}!");
        Thread.Sleep(1000);
}

//Fråga 3

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 3: Är Afrika ett land?");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("a) Nej, det är något annat");
System.Console.WriteLine("b) Nej, det är en stad i Danmark");
System.Console.WriteLine("c) Ja, det är ett land");
Console.Write("Ditt svar: ");
string f3 = Console.ReadLine();

if (f3 == "a")
{
     Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Helt rätt {namn}!");
    Thread.Sleep(1000);
    score++;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Helt fel {namn}!");
    Thread.Sleep(1000);
}

//Fråga 4

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 4: Vilka är de officiella språken i Schweiz?");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("a) Schweiziska och tyska");
System.Console.WriteLine("b) Tyska, franska, italienska och rätoromanska");
System.Console.WriteLine("c) Franska, tjeckiska och danska");
Console.Write("Ditt svar: ");
string f4 = Console.ReadLine();

if (f4 == "b")
{
     Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Helt rätt {namn}!");
        Thread.Sleep(1000);

    score++;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Helt fel {namn}!");
        Thread.Sleep(1000);

}

//Fråga 5

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 5: Vilket land är det här?");
Console.WriteLine(@"%%%#**#%%%%%%%%%%%%%
%%%##***#%%%%%%%%%%%
%%%%#+=+++#%%%%%%%%%
%%###++=+=+#%%%%%%%%
%%%#++=++++=+%%%%%%%
%%%#+++++++=++#%%%%%
%%#++++++++=+++#%%%%
%%*+++++++=++++*%%%%
%%*+++++++=+++++*#%%
%%#+++++=+++=+++++#%
%%#++++==+++++==++*%
%%%+++++==+++=+++++%
%%%*+===++=+++++++*%
%%%#+++++++==+++++#%
%%%%*====+++==++*%%%
%%%%#*+++=++*#%%%%%%
%%%%%%%%##%%%%%%%%%%");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("a) Kenya");
System.Console.WriteLine("b) Uruguay");
System.Console.WriteLine("c) Rumänien");
System.Console.WriteLine("d) Sri Lanka");
System.Console.WriteLine("e) Vatikanstaten");
Console.Write("Ditt svar: ");
string f5 = Console.ReadLine();

if (f5 == "d")
{
     Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Helt rätt {namn}!");
        Thread.Sleep(1000);

    score++;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Helt fel {namn}!");
        Thread.Sleep(1000);

}

//slutet som berättar poäng och frågar om man vill spela igen
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.WriteLine($"Du kämpade på bra {namn}. Du fick {score}/5 poäng");

System.Console.Write("Vill du spela igen? (j/n): ");
string svar = Console.ReadLine();

if (svar == "j")
{
    Console.Clear();
    System.Console.WriteLine("Lycka till grabben!");
    Thread.Sleep(1000);
}
else
{
    break;
}
}

Console.Clear();
System.Console.WriteLine($"Hejdå {namn}!");
