Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

//1. Skapa en lista med 5 namn
List<string> namnLista = ["Greger", "Torkel", "Magnus","Roger", "Hjalmar"];
//Skriv ut namnen
Console.WriteLine($"Mina kompisar är: {string.Join(", ", namnLista)}");

//2. Skapa en lista med 5 orter
List<string> ortLista = ["Boden", "Stockholm", "Västerås", "Örebro", "Uppsala"];
//Skriv ut orterna
Console.WriteLine($"Fem orter ({string.Join(", ", ortLista)}) ligger i Sverige.");

//3. Skapa en lista med 5 årtal
List<int> årtalLista = [1776, 1945, 1918, 1914, 0];
//Skriv ut årtal
Console.WriteLine($"Fem viktiga årtal är '{string.Join("', '", årtalLista)}'");

//4. Visa första och sista namet i en lista
List<string> namnLista2 = ["Bengt", "Sture", "Bert", "Jan", "Sten"];
Console.WriteLine("Jag har en namnlista med 5 namn:");
Console.WriteLine("Första namnet: " + namnLista2[0]);
Console.WriteLine("Sista namnet: " + namnLista2[4]);

//5. Lista med drycker
List<string> dryckesLista = ["Vatten", "Bubbelvatten", "Kranvatten", "Varmt vatten", "Iskallt vatten"];
Console.WriteLine("Mina favoritdrycker:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i + 1}. {dryckesLista[i]}");
}

List<string> namnLista3 = ["Greg", "Bo"];
Console.WriteLine($"Nuvarande lista: {string.Join(", ", namnLista3)}");
Console.Write("Ange ett namn att lägga till: ");
string namn = Console.ReadLine();
namnLista3.Add(namn);
Console.WriteLine($"Uppdaterad lista: {string.Join(", ", namnLista3)}");
