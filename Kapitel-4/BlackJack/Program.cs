//Spelet Black Jack även kallat 21:an
Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" ♦️ ♠️ BLACK JACK ♥️ ♣️ ");
//Kortens värden är
//2-10 = 2-10
//Knekt, dam, kung = 10
//Ess = 1 (eller 11)
//@todo slump måste efterlikna riktig kortlek, dsv 4x1, 4x2....

// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

//Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
summaSpelare += kort;

//Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
summaDator += kort;

//Flera gånger (loop)
while (true)
{


    //Skriv ut summorna
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"DU HAR {summaSpelare} poäng");
    Console.WriteLine($"DATORN HAR {summaDator} poäng");

    //Stanna eller dra ett kort?
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("VILL DU DRA ETT TILL KORT? (J/N): ");
    string svar = Console.ReadLine().ToUpper();
    if (svar == "N")
    {

        while (summaDator < 17)
        {
            kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
            summaDator += kort;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine($"DATORN DROG ETT KORT TILL OCH FICK {kort}");
            Thread.Sleep(1000);

            if (summaDator > 21)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DATORN BLEV TJOCK");
            }
        }

        //Den som är närmast 21 har vunnit
        if (summaSpelare > summaDator && summaSpelare < 22)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("DU VANN!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.WriteLine("DATORN VANN!");
        }


        break;
    }

    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(" ♦️ ♠️ BLACK JACK ♥️ ♣️ ");

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow; ;
    //Ta ett extra kort
    kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
    summaSpelare += kort;

    //Skriv ut kort
    Console.WriteLine($"DU FICK {kort}");

    //Dator får ett nytt kort
    kort = Random.Shared.Next(1, 11); // @todo hur får man knekt, dam och kung?
    summaDator += kort;
    //Skriv ut kort
    Console.WriteLine($"DATORN FICK {kort}");
    //Vem har vunnit?
    //Har spelaren fått 21 har hen vunnit
    if (summaDator == 21)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"DU HAR {summaSpelare} poäng");
        Console.WriteLine($"DATORN HAR {summaDator} poäng");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ");
        Console.WriteLine("DATORN FICK 21 OCH VANN!");
        break;
    }
    //Har datorn fått 21 har den vunnit
    if (summaSpelare == 21)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"DU HAR {summaSpelare} poäng");
        Console.WriteLine($"DATORN HAR {summaDator} poäng");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" ");
        Console.WriteLine("DU FICK 21 OCH VANN!");
        break;
    }
    //Är spelaren tjock?
    if (summaSpelare > 21)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"DU HAR {summaSpelare} poäng");
        Console.WriteLine($"DATORN HAR {summaDator} poäng"); Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ");
        Console.WriteLine("DU BLEV TJOCK OCH HAR FÖRLORAT!");
        break;
    }
    //Är datorn tjock?
    if (summaDator > 21)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"DU HAR {summaSpelare} poäng");
        Console.WriteLine($"DATORN HAR {summaDator} poäng");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" ");
        Console.WriteLine("DATORN BLEV TJOCK HAR FÖRLORAT!");
        break;
    }
}

Console.ForegroundColor = ConsoleColor.White;