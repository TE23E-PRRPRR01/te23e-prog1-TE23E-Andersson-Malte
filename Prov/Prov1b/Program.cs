//Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.Write("Ange namn: ");
string namn = Console.ReadLine();

//programloop
while (true)
{
    Console.Write("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    //har användaren matat in vettiga siffror?
    if (bruttolön > 10000 || bruttolön > 1000000)
    {
        Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");
    }
    else
    {
        //vad är skattesatsen?
        //10000:- till 145000:- -> 22%
        int skattesatsen = 0; //skapa variabeln skattesatsen
        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            skattesatsen = 22;
        }
        //145000:- till 515000:- -> 33%
        if (bruttolön >= 145000 && bruttolön < 515000)
        {
            skattesatsen = 33;
        }
        //515000:- eller mer -> 53%
        if (bruttolön >= 515000)
        {
            skattesatsen = 53;
        }
        int nettolön = bruttolön * (100 - skattesatsen) / 100;
        //resultatet
        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {skattesatsen}%.");

        Console.Write("Vill du göra en ny beräkning? (j/n): ");
        string svar = Console.ReadLine().ToLower().Trim();
        if (svar != "j")
        {
            break;
        }
    }
}