// Ett dungeon-spel med massa rum, saker, fiender, skatter...
Console.Clear();

//Programvariabler (state variables)
string rum = "hallen";
List<string> inventarie = [];
int liv = 1;

//Spelloop
while (true)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("""
------------
DUNGEON SPEL
------------
""");
Console.ForegroundColor = ConsoleColor.White;
    //Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt och ser en bild på din morsa.");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine("...du går in i nästa rum...");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i köket.");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till rummet på höger");
        Console.WriteLine("3. Gå till rummet på vänster");
        Console.WriteLine("4. Gå tillbaka till hallen");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            if(!inventarie.Contains("nyckel"))
            {Console.WriteLine("Du tittar runt och finner en nyckel.");
            Console.Write("Vill du plocka upp nyckeln? (j/n) ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventarie.Add("nyckel");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("NYCKELN LADES TILL I DITT INVENTARIE");
            }
            }
            else
            {
                Console.WriteLine("Du finner ingenting");
            }
        }
        else if (val == "2")
        {
            rum = "rum 2";
            Console.WriteLine("...du går in i rummet till höger...");
        }
        else if (val == "3")
        {
            rum = "rum 3";
            Console.WriteLine("...du går in i rummet till vänster...");

        }
        else if (val == "4")
        {
            rum = "hallen";
            Console.WriteLine("...du går tillbaka till hallen...");

        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i sovrummet");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till köket");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            if(!inventarie.Contains("ficklampa"))
            {Console.WriteLine("Du tittar runt och finner en ficklampa.");
             Console.Write("Vill du plocka upp ficklampan? (j/n) ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventarie.Add("ficklampa");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FICKLAMPAN LADES TILL I DITT INVENTARIE");
            }
            }
            else
            {
                Console.WriteLine("Du finner ingenting");
            }
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine("...du går tillbaka till köket...");
        }
    }

    else if (rum == "rum 3")
    {
        Console.WriteLine("Du är i vardagsrummet");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.WriteLine("3. Gå tillbaka till köket");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            if(!inventarie.Contains("mynt"))
            {Console.WriteLine("Du tittar runt och finner ett mynt.");
             Console.Write("Vill du plocka upp myntet? (j/n) ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventarie.Add("mynt");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MYNTET LADES TILL I DITT INVENTARIE");
            }
            }
            else
            {
                Console.WriteLine("Du finner ingenting");
            }
        }
        else if (val == "2")
        {
            Console.WriteLine("...dörren till nästa rum är låst...");
            Console.Write("Vill du låsa upp den? (j/n)");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                if(inventarie.Contains("nyckel"))
                {
                    rum = "rum 4";
                    Console.WriteLine("Du låser upp dörren och går ner för en trappa.");
                }
                else
                {
                    Console.WriteLine("Du har ingen nyckel...");
                }
            }

        }
        else if (val == "3")
        {
            rum = "rum 1";
            Console.WriteLine("...du går tillbaka till köket...");
        }
    }
    else if (rum == "rum 4")
    {
        Console.WriteLine("Du är i källaren");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till vardagsrummet");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            if(inventarie.Contains("ficklampa"))
            {
                Console.WriteLine("Rummet är mörkt. Du tänder ficklampan.");
                int händelse = Random.Shared.Next(1, 3);
            if (händelse == 1)
            {
                Console.WriteLine("En elak tomtenisse dyker upp framför dig!");
                Console.Write("Vill du gå till anfall? (j/n) ");
                val = Console.ReadLine().ToLower();
                if (val == "j")
                {
                    int slagsmål = Random.Shared.Next(1, 3);
                    if (slagsmål == 1)
                    {
                        Console.WriteLine("Du vann slagsmålet mot den elaka tomtenissen");
                    }
                    else if (slagsmål == 2)
                    {
                        Console.WriteLine("Du förlorade slagsmålet mot den elaka tomtenissen");
                        liv--;
                        //Är liven slut?
                        if (liv <= 0)
                        {
                            break;
                        }
                    }

                }
                else if(val == "n")
                {
                    rum = "rum 3";
                    Console.WriteLine("Du flyr tillbaka till vardagsrummet");
                }
            }
            else if (händelse == 2)
            {
                Console.WriteLine("Något annat händer");
            }

            }
            else
            {
                Console.WriteLine("Det är för mörkt för att se något...");
            }
        }
        else if (val == "2")
        {
            rum = "rum 3";
            Console.WriteLine("...du går tillbaka till vardagsrummet...");
        }  
        }
       Thread.Sleep(2000);

        Console.Clear();
        
}

