
//En liten app för morsekod
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("APP FÖR MORSEKOD");
Console.InputEncoding = System.Text.Encoding.Unicode;

//Två listor
List<string> alfabetet = ["A","B","C","D","E","F","G","H","I","J","K","L",
                          "M","N","O","P","Q","R","S","T","U","V","W","X",
                          "Y","Z","Å","Ä","Ö"," ","1","2","3","4","5","6","7","8","9","0"];
List<string> morsekod = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                        "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
                        "--.-",".-.", "...", "-", "..-", "...-", ".--", "-..-",
                         "-.--","--..",".--.-", ".-.-", "---.", "/",".----","..---","...__",
                         "....-",".....","-....","--...","---..","----.","-----"];

//Läs in text
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

//Gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    //Uppslag i alfabetet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    //Hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        //Plocka ut morsetexknet för dett index
        string morsetecken = morsekod[index];
        //Console.WriteLine($"{bokstav} i morsekod är {morsetecken}");
        Console.Write($"{morsetecken}  ");

        //spela upp morse som ljud-beep
        // tex D = "-.."'
        //Dvs loopa igenom morsetecknet
        foreach (char signal in morsetecken)
        {
            if (signal == '.') // '.
            {
                //1000Hz, 200ms
                Console.Beep(1000, 200);
            }
            else // '-
            {
                //1000Hz, 600ms
                Console.Beep(1000, 600);
            }
        }

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("?");
    }

    //Paus i koden
    Thread.Sleep(100);
}

Console.ForegroundColor = ConsoleColor.White;

