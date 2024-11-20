Console.Clear();

int startvärde;
int slutvärde;

Console.Write("Ange startvärde: ");
int.TryParse(Console.ReadLine(), out startvärde);
Console.Write("Ange slutvärde: ");
int.TryParse(Console.ReadLine(), out slutvärde );

int nummer = startvärde;
int antal = slutvärde - startvärde + 1;
int summa = 0;
int nummersumma = 0;

for (var i = 0; i < antal; i++)
{
    Console.WriteLine($"{nummer ++}");
}

for (var i = 0; i < antal + 1; i++)
{
    summa = summa + nummersumma++;
}

Console.WriteLine($"Summan av talen mellan {startvärde} och {slutvärde} är: {summa}");

Console.Write("Jämna tal: ");
for (var i = 2; i < 21; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();
Console.Write("Udda tal: ");

for (var i = 1; i < 21; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();

int tal = 0;
Console.Write("Ange ett tal: ");
int.TryParse(Console.ReadLine(), out tal);

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"{tal} x {i + 1} = {tal * (i + 1)}");
}