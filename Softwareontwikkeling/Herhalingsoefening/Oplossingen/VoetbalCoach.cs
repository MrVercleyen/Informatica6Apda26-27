int[][] rugnummers = new int[100][];

int rugnummer = int.Parse(Console.ReadLine());

while(rugnummer != 99)
{
    string choice = Console.ReadLine();


    if (rugnummers[rugnummer -1] == null)
    {
        rugnummers[rugnummer - 1] = new int[2];
    }
    if (choice == "P")
    {
        rugnummers[rugnummer -1][0] = int.Parse(Console.ReadLine());
    }
    else if(choice == "N")
    {
        rugnummers[rugnummer -1][1] = int.Parse(Console.ReadLine());
    } else
    {
        Console.WriteLine("Ongeldige invoer");
    }

    rugnummer = int.Parse(Console.ReadLine());
}

Console.WriteLine("Rugnummer    Positief    Negatief    Verschil");
for(int i = 0; i < rugnummers.Length; i++)
{
    if (rugnummers[i] != null) { Console.WriteLine($"{i + 1}            {rugnummers[i][0]}           {rugnummers[i][1]}           {rugnummers[i][1] - rugnummers[i][0]}"); }
}