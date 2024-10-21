//Ett program flr kryptering med Caesar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=============================================");
Console.WriteLine("ETT PROGRAM FÖR KRYPTERING MED CAESAR-CHIFFER");
Console.WriteLine("=============================================");

//ALFTabet, LISTA av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

//Ange ett meddelande
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

//nyckel
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" ");
Console.Write("Ange nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

//Loopa igenom meddelandet bokstav för bokstav
foreach (char bokstav in meddelande)
{
    //Hitta bokstavens position (index)
    Console.ForegroundColor = ConsoleColor.White;
    int index = alfabetet.IndexOf(bokstav);
    //Console.WriteLine($"'{bokstav}' är index = {index}");

    //om meddelande finns i alfabetet
    Console.ForegroundColor = ConsoleColor.White;
    if (index != -1)
    {
        //Caesar-krypyering, addera en nyckel (tex 2)
        int nyIndex = index + nyckel;
        //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

        //börja om från början efter 29
        if (nyIndex > 28)
        {
            nyIndex = nyIndex - 29;
        }


        //plocka ut bokstaven för nyIndex
        char krypteradBokstav = alfabetet[nyIndex];
        Console.Write($"{krypteradBokstav}");
    }
    else
    {
        //Console.WriteLine($"Bokstav är oförändrad: {bokstav}");
        Console.Write(bokstav);
    }
}



