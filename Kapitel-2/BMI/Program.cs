//BMI-räknare
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("NU SKA VI SE HUR TJOCK DU ÄR...");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ange längd (m); ");
double längd = double.Parse(Console.ReadLine());
Console.Write("Ange vikt (kg): ");
double vikt = double.Parse(Console.ReadLine());

double BMI = vikt / (längd * längd);

Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Din BMI är {BMI:00.0}");

if (BMI > 18.5)
{
    if (BMI < 25)
    {
        Console.WriteLine("DU ÄR NORMALVIKT");
    }
    else
    {
        Console.WriteLine("DU ÄR TJOCK (ÖVERVIKT)");
    } 
}
else
{
    Console.WriteLine("DU ÄR VERKLIGEN INTE TJOCK (UNDERVIKT)");
}

Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.White;
