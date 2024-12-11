using System.Runtime.ConstrainedExecution;

Console.Clear();
Console.WriteLine("Filmregister");

//Lista för att lagra filmer
List<string> listaFilmer = [];

//Be användaren mata in antal
Console.Write("Ange antal filmer per sida(3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
}

//Programloop
while (true)
{
    //Visa en meny
    Console.Write("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ: 
""");
    string val = Console.ReadLine();

    Console.WriteLine();

    //Handskas med valen
    if (val == "1")
    {
        //Lägg till film i listan
        for (int i = 0; i < antal; i++)
        {
        Console.Write("Ange en film: ");
        string film = Console.ReadLine();
        listaFilmer.Add(film);
        }
    }
    else if (val == "2")
    {
        //SKriv ut alla filmer
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine($" - {filmnamn}");
        }
    }
    else if (val == "3")
    {
        //Sök en film
        Console.Write("Ange en bokstav att söka efter: ");
        string bokstav = Console.ReadLine();
          foreach (var filmnamn in listaFilmer)
        {
            //Kolla varje film om den börjar på bokstav
            if(filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine($" - {filmnamn}");
            }
        }
        
    }
    else if (val == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Felaktigt val, försök igen!");
    }
}
