// using System.Runtime.Intrinsics.Arm;

// Console.Clear();
// Console.WriteLine("Allt om listor");

// //Skapa en tom lista
// List<string> listaActionspel = [];
// List<string> listaÄventyrsspel = [];

// //Lägg till spel i lista
// for (int i = 0; i < 2; i++)
// {
//     Console.Write("Ange ett actionspel: ");
//     listaActionspel.Add(Console.ReadLine());
// }

// for (int i = 0; i < 3; i++)
// {
//     Console.Write("Ange ett äventyrsspel: ");
//     listaÄventyrsspel.Add(Console.ReadLine());
// }

// Console.WriteLine();

// //Skriv ut första 2 actionspelen i listan med index
// Console.WriteLine("Här är de två första action-spelen i listan:");

// for (int i = 0; i < 2; i++)
// {
// Console.WriteLine($"- Spel {i+1}: {listaActionspel[i]}");
// }

// Console.WriteLine();

// //Skriv ut alla spel i båda listorna
// int nummer = 1;
// Console.WriteLine("Här är alla actionspel i listan:");

// foreach (var spel in listaActionspel)
// {
//     Console.WriteLine($"- Spel {nummer}: {spel}");
//     nummer++;
// }

// nummer = 1;
// Console.WriteLine("Här är alla äventyrsspel i listan:");

// foreach (var spel in listaÄventyrsspel)
// {
//     Console.WriteLine($"- Spel {nummer}: {spel}");
//     nummer++;
// }

// Console.WriteLine();

// //Skriv ut de tre första spelen med en for-loop

// Console.WriteLine("Här är de tre första äventyrsspelen i listan:");

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"- Spel {i+1}: {listaÄventyrsspel[i]}");
// }

// Console.WriteLine();

// //Registrera fler spel
// for (int i = 0; i < 2; i++)
// {
//     Console.Write("Registrera ett till actionspel: ");
//     listaActionspel.Add(Console.ReadLine());
// }

// for (int i = 0; i < 2; i++)
// {
//     Console.Write("Registrera ett till äventyrsspel: ");
//     listaÄventyrsspel.Add(Console.ReadLine());
// }

// Console.WriteLine();

// //Skriv ut alla spel igen
// nummer = 1;
// Console.WriteLine("Här är alla spel i actionspel i listan igen:");

// foreach (var spel in listaActionspel)
// {
//     Console.WriteLine($"- Spel {nummer}: {spel}");
//     nummer++;
// }

// nummer = 1;
// Console.WriteLine("Här är alla spel i spel äventyrsspel listan igen:");

// foreach (var spel in listaÄventyrsspel)
// {
//     Console.WriteLine($"- Spel {nummer}: {spel}");
//     nummer++;
// }

// Console.WriteLine();

Console.Clear();

List<string> listaActionspel = [];
List<string> listaÄventyrsspel = [];
int svar = 0;

while (true)
{
    int nummer = 1;

    Console.Write("""
    1. Visa alla actionspel
    2. Registrera ett actionspel
    3. Visa alla äventyrsspel
    4. Registrera ett äventyrsspel
    5. Avsluta
    Välj ett alternativ: 
    """);
    bool success = int.TryParse(Console.ReadLine(), out svar);

    Console.WriteLine();

    if (svar == 1)
    {
        Console.WriteLine("Här är alla actionspel i listan:");
        foreach (var spel in listaActionspel)
        {
            Console.WriteLine($"- Spel {nummer}: {spel}");
            nummer++;
        }
    }
    else if (svar == 2)
    {
        Console.Write("Ange ett actionspel: ");
        listaActionspel.Add(Console.ReadLine());
    }
    else if (svar == 3)
    {
        Console.WriteLine("Här är alla äventyrsspel i listan:");
        foreach (var spel in listaÄventyrsspel)
        {
            Console.WriteLine($"- Spel {nummer}: {spel}");
            nummer++;
        }
    }
    else if (svar == 4)
    {
        Console.Write("Ange ett äventyrsspel: ");
        listaÄventyrsspel.Add(Console.ReadLine());
    }
    else if (svar == 5)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt svarsalternativ");
    }


    Console.WriteLine();
}