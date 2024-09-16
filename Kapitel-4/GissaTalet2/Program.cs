// Användaren bestämmer max- och minvärde
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("GISSA TALET");


//variabel för antal gissningar
int antal =  0;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("ANGE MINIMUM VÄRDE: ");
int minVarde = int.Parse(Console.ReadLine());
Console.Write("ANGE MAXIMUM VÄRDE: ");
int maxVarde = int.Parse(Console.ReadLine());

//Slumpa tal från användaren
int slumptal = Random.Shared.Next(minVarde, maxVarde+1);

//Upprepning (loop)
while (true)
{
    //Ställer frågan till användaren
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Gissa ett tal ({minVarde}-{maxVarde}): ");
    int gissning = int.Parse(Console.ReadLine());

    //Räkna upp antal med 1
    antal++;

    //Kontrollera om gissningen är rätt eller fel
    if (gissning == slumptal)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("RÄTT!");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        if (gissning > slumptal)
        {
            Console.WriteLine("FÖR HÖGT!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("FÖR LÅGT!");
        }

        //Vill användaren gissa igen?
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("GISSA IGEN? (j/n): ");
        string gissaIgen = Console.ReadLine();

        if (gissaIgen == "n")
        {
            break;
        }

    }

}

//Slut på spelet
Console.ForegroundColor = ConsoleColor.Yellow;   
Console.WriteLine($"DU GISSADE PÅ {antal} GISSNINGAR");
Console.ForegroundColor = ConsoleColor.White;   

