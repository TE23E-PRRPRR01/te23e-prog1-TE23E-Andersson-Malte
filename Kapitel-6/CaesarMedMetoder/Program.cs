/* *****
Main
***** */

Introduktion();

while (true)
{
    VisaMeny();
    string svar = Console.ReadLine();

    if (svar == "1")
    {
        KrypteraMeddelande();
    }
    else if (svar == "2")
    {
        AvkrypteraMeddelande();
    }
    else if (svar == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Försök igen!");
    }

}

/* *****
Metoder
***** */
static void Introduktion()
{
    Console.Clear();
    Console.InputEncoding = System.Text.Encoding.Unicode;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=============================================");
    Console.WriteLine("ETT PROGRAM FÖR KRYPTERING MED CAESAR-CHIFFER");
    Console.WriteLine("=============================================");

}

static void VisaMeny()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("""
    1. Kryptera meddelande
    2. Avkryptera meddelande
    3. Avsluta Programmet
    Välj ett alternativ: 
    """);
}

static void KrypteraMeddelande()
{
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    Console.WriteLine("");

    //Läs in meddelande från användaren
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    //Läs in nyckel
    int nyckel = LäsInHeltal();

    Console.Write("\nDitt krypterade meddelande: ");
    //Loopa igenom meddelandet bokstav för bokstav
    foreach (char bokstav in meddelande)
    {
        //Hitta bokstavens position (index)
        int index = alfabetet.IndexOf(bokstav);

        //Om meddelande finns i alfabetet
        if (index != -1)
        {
            //Caesar-krypyering, addera en nyckel (tex 2)
            int nyIndex = index + nyckel;

            //Börja om från början efter 29
            if (nyIndex > 28)
            {
                nyIndex = nyIndex - 29;
            }

            //Plocka ut bokstaven för nyIndex
            char krypteradBokstav = alfabetet[nyIndex];
            Console.Write($"{krypteradBokstav}");
        }
        else
        {
            Console.Write(bokstav);
        }
    }
    Console.WriteLine("");
}

static void AvkrypteraMeddelande()
{
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    Console.WriteLine("");

    //Läs in meddelande från användaren
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    //Läs in nyckel
    int nyckel = LäsInHeltal();

    Console.Write("\nDitt krypterade meddelande: ");
    //Loopa igenom meddelandet bokstav för bokstav
    foreach (char bokstav in meddelande)
    {
        //Hitta bokstavens position (index)
        int index = alfabetet.IndexOf(bokstav);

        //Om meddelande finns i alfabetet
        if (index != -1)
        {
            //Caesar-krypyering, subrahera en nyckel
            int nyIndex = index - nyckel;

            //Börja om från slutet efter 0
            if (nyIndex < 0)
            {
                nyIndex = nyIndex + 29;
            }

            //Plocka ut bokstaven för nyIndex
            char krypteradBokstav = alfabetet[nyIndex];
            Console.Write($"{krypteradBokstav}");
        }
        else
        {
            Console.Write(bokstav);
        }
    }
    Console.WriteLine("");
}

static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        Console.Write("Ange krypteringsnyckel (1-9): ");
        string nyckel = Console.ReadLine();
        Console.WriteLine("");
        // Kolla om texten är ett tal
        bool lyckades = int.TryParse(nyckel, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Försök igen!");
        }
    }

    return tal;
}





