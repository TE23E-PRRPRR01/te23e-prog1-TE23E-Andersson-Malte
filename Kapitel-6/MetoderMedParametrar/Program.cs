/* *****************************************************
***********************M A I N**************************
****************************************************** */
Console.Clear();

//Skriv ett meddelande verikalt
string meddelande1 = "MÅNDAG";
SkrivVertikalt(meddelande1);

//Skriv ett meddelande verikalt nummer 2
string meddelande2 = "TISDAG";
SkrivVertikalt(meddelande2);

//Skriv ett meddelande verikalt nummer 3
string meddelande3 = "ONSDAG";
SkrivVertikalt(meddelande3);

//Rita fyrkant med sidlängd 3
RitaKvadrat(3);
Console.WriteLine();
RitaKvadrat(4);

//Upprepa text
UpprepaText("Hej", 3);
UpprepaText("Hejsan", 5);

//Överföra celcius till fahrenheit
ÖverföraCTillF(20);

//Kasta tärning
tärning(5);

/* *****************************************************
*********************M E T O D E R**********************
****************************************************** */

/// <summary>
/// Skriv meddelande vertikalt
/// </summary>
/// <param name="meddelande"></param>

static void SkrivVertikalt(string meddelande)
{
    for (int i = 0; i < meddelande.Length; i++)
    {
        Console.WriteLine(meddelande[i]);
    }

}

/// <summary>
/// Rita fyrkant med sidlängd 
/// </summary>
/// <param name="SidLängd"></param>

static void RitaKvadrat(int SidLängd)
{
    for (int i = 0; i < SidLängd; i++)
    {
        for (int a = 0; a < SidLängd; a++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}

/// <summary>
/// Upprepa text
/// </summary>
/// <param name="text"></param>
/// <param name="antal"></param>

static void UpprepaText(string text, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

/// <summary>
/// Överföra celscius till fahrenheit
/// </summary>
/// <param name="tempCelsius"></param>

static void ÖverföraCTillF(int tempCelsius)
{
    int tempFahrenheit = tempCelsius * 9/5 + 32;
    Console.WriteLine($"{tempCelsius}C är {tempFahrenheit}F");
}

/// <summary>
/// Kasta tärning
/// </summary>
/// <param name="antalKast"></param>

static void tärning(int antalKast)
{
    for (int i = 0; i < antalKast; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1, 7)}");
    }
}