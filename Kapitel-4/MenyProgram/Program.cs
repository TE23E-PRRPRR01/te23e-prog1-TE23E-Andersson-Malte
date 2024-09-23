//Litet program emd meny
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("MENYPROGRAM");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;


//Variabel för valet
string val = "";

//Programloop som snurrar tills användaren säger avsluta
while (true)
{
    //Visar en meny och läser in användarens val
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("VÄLJ ETT AN FÖLJANDE ALTERNATIV:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("""
    1. OMVANDLA EN TEXT TILL VERSALER
    2. OMVANDLA EN TEXT TILL GEMENER
    3. AVSLUTA
    """);
    Console.WriteLine(" ");
    Console.Write("DITT SVAR: ");
    val = Console.ReadLine();

    //Hantera användarens val
    if (val == "1")
    {
        Console.Clear();
        Console.WriteLine("SKRIV IN EN TEXT: ");
        string texten = Console.ReadLine().ToUpper();
        Console.WriteLine($"TEXTEN I VERSALER BLIR: {texten}");
    }
    else
    {
        if (val == "2")
        {
        Console.Clear();
        Console.WriteLine("SKRIV IN EN TEXT: ");
        string texten = Console.ReadLine().ToLower();
        Console.WriteLine($"TEXTEN I GEMENER BLIR: {texten}");
        }
        else
        {
            if (val == "3")
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AVSLUTAR...");
            break;
            }
            else
            {
            Console.WriteLine("VÄNLIGEN VÄLJ ETT GILTIGT ALTERNATIV");
            }
        }
    }
}