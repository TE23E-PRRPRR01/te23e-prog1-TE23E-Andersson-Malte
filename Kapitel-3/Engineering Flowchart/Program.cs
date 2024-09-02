//Program som simulerar kända Engineering Flowchart
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

Console.Clear();


//Visa en ASCII-art
Console.WriteLine($"""
        .--'''''''''--.
     .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
     '-._| | | | | | |_.-'
         | '-' | '-' |
          \___/ \___/
       _.-'  /   \  `-._
     .' _.--|     |--._ '.
     ' _...-|     |-..._ '
            |     |
            '.___.'


""");

Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

//Kolla om svar är ja eller nej

if (answer == "y")
{
    Console.Write("Shodit? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem");
    }
    else
    {
        Console.WriteLine("Use duck tape");
    }
}
else
{
    Console.Write("Shodit? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Use WD-40");
    }
    else
    {
        Console.WriteLine("No problem");

    }

}