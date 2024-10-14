//Använda listor för att skapa och hantera samlingar
Console.Clear();

//Lista på trevliga frukter,tex "äpple", "apelsin", "ananas"
List<string> frukter = ["äpple", "apelsin", "ananas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

//Ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

//gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

//skapa en lista för valfri sak (4st)
List<string> bönor = ["grön böna","lång böna","brun böna","rund böna"];
//Skriv ut varje sak på samma rad
foreach (var böna in bönor)
{
    Console.Write($"{böna} ");
}

for (int i = 0; i < bönor.Count; i++)
{
    Console.Write($"{bönor[i]}");
}

//Skapa ett register 
Console.Clear();
//en tom lista 
List<string> namnLista = [];

//while-loop
while (true)
{
    Console.Write("\nAnge ett namn: ");
    string namn = Console.ReadLine();
    namnLista.Add(namn);

    //skriv ut listan på en rad
    foreach (var namnet in namnLista)
    {
        Console.Write($"{namnet}, ");
    }
}