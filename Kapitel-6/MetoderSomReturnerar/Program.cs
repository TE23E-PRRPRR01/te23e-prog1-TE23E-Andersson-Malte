/* *****************************************************
***********************M A I N**************************
****************************************************** */
//Använd metoder här!
using System.Reflection.Metadata.Ecma335;

int svar = Addera(3, 5);
Console.WriteLine($"Svaret är {svar}");
Console.WriteLine(Addera(3, 5));
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

string namn = "Greger";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

Console.WriteLine($"Produkten är {Multiplicera(2, 7)}");

Console.WriteLine($"Kvoten är {Dividera(15, 3)}");

Längst("Hej", "Hejdå");
Console.WriteLine();

Console.Write("Ange ett tal: ");
int nyTal = LäsInHeltal();

/* *****************************************************
********************M E T O D E R***********************
****************************************************** */
//Skapa metoder här!
static int Addera(int tal1, int tal2) //Signatur
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>

static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

static double Multiplicera(double tal1, double tal2)
{
    double produkt = tal1 * tal2;
    return produkt;
}

static double Dividera(double tal1, double tal2)
{
    double kvot = tal1 / tal2;
    return kvot;
}

static string Längst(string text1, string text2)
{
    if (text1.Length > text2.Length)
    {
        Console.WriteLine($"{text1} är längst");
        return text1;
    }
    else
    {
        Console.WriteLine($"{text2} är längst");
        return text2;
    }
}

/// <summary>
/// Säkert sätta tt läsa in ett tal utan att det kraschar 
/// </summary>
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        //Läs in fråån användaren
        string textSomBlirTal = Console.ReadLine();

        //Kolla om text är tal
        bool lyckas = int.TryParse(textSomBlirTal, out tal);

        if (lyckas == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Försök igen");
        }
    }

    return tal;
}