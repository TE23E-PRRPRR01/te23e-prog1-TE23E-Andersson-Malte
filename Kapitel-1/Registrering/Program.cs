﻿// Program för att registrera förnamn och efternamn...
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn...");
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej " + förnamn + " " + efternamn + "!");

if (efternamn == "Östräråg")
{
    Console.WriteLine("Du har det bästa efternamnet😎");
}
