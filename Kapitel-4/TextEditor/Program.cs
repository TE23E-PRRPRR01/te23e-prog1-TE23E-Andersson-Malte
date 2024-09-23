//Text editor
using System.IO.Compression;
using System.Runtime.InteropServices;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;


//Variabel för valet
string val = "";

//Programloop som snurrar tills användaren säger avsluta
while (true)
{
    //Visar en meny och läser in användarens val
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("VÄLJ ETT AN FÖLJANDE ALTERNATIV:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("""
    1. SKRIV TILL FIL
    2. LÄS FRÅN FIL
    3. AVSLUTA
    """);
    Console.WriteLine(" ");
    Console.Write("DITT SVAR: ");
    val = Console.ReadLine();

    //Hantera användarens val

    if (val == "1")
    {
        Console.Clear();
        Console.Write("SKRIV IN TEXT: ");
        string text = Console.ReadLine();
        File.WriteAllText("filnamn.txt", text);

    }
    else if (val == "2")
    {
        if (File.Exists("filnamn.txt"))
        {
        Console.Clear();
        string text = File.ReadAllText("filnamn.txt");
        Console.WriteLine($"{text}");
        Console.ReadLine();
        }
        else
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("FILEN FINNS INTE!");
        Thread.Sleep(1500);
        }

    }
    else if (val == "3")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("AVSLUTAR...");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("VÄNLIGEN VÄLJ ETT GILTIGT ALTERNATIV");
        Thread.Sleep(1500);
    }
}

Console.ForegroundColor = ConsoleColor.White;