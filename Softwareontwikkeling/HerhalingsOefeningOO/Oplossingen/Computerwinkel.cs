class ComputerOnderdeel
{
    private static Random rng = new Random();

    public int Prijs { get; set; }

    public int ID { get; set; }

    public bool InDoos { get; set; }

    public ComputerOnderdeel()
    {
        Prijs = rng.Next(0, 1001);
        ID = rng.Next(100, 1000);

        if (rng.Next() % 2 == 0)
        {
            InDoos = true;
        }
    }

    public void ToonInfo()
    {
        Console.WriteLine($"Prijs: {Prijs}, ID: {ID}, InDoos: {InDoos}");
    }
}


//Main klasse code

static void Main(string[] args)
{
    //Console.WriteLine("Hello World!");

    List<ComputerOnderdeel> onderdelen = new List<ComputerOnderdeel>();

    //100 computeronderdelen aanmaken
    for (int i = 0; i < 100; i++)
    {
        onderdelen.Add(new ComputerOnderdeel());
    }

    //ToonInfo() voor alle onderdelen
    Console.WriteLine("ToonInfo() voor alle onderdelen in de lijst:");
    ToonInfo_Alle(onderdelen);

    //ToonInfo() voor onderdelen met prijs > 400
    ToonInfo_PrijsGroterDan400(onderdelen);

    //ToonInfo() voor onderdelen in een doos
    ToonInfo_OnderdelenInDoos(onderdelen);

    //ToonInfo() voor onderdelen met even ID & prijs < 200
    ToonInfo_EvenIDPrijsGroterDan200(onderdelen);


    //verwijder alle onderdelen waarvoor InDoos == true
    Verwijder_InDoos(onderdelen);

    //verwijder alle onderdelen waarvoor price < 100
    Verwijder_PrijsOnder100(onderdelen);


    //ToonInfo() van overgebleven onderdelen
    Console.WriteLine("\n\n\nInformatie van de overgebleven onderdelen:");
    ToonInfo_Alle(onderdelen);
}

static void ToonInfo_Alle(List<ComputerOnderdeel> onderdelen)
{
    foreach (var item in onderdelen)
    {
        item.ToonInfo();
    }
}

static void ToonInfo_PrijsGroterDan400(List<ComputerOnderdeel> onderdelen)
{
    Console.WriteLine("\n\n\nToonInfo() voor alle onderdelen met een prijs > 400:");
    foreach (var item in onderdelen)
    {
        if (item.Prijs > 400)
        {
            item.ToonInfo();
        }
    }
}

private static void ToonInfo_OnderdelenInDoos(List<ComputerOnderdeel> onderdelen)
{
    Console.WriteLine("\n\n\nToonInfo() voor alle onderdelen in een doos:");
    foreach (var item in onderdelen)
    {
        if (item.InDoos == true)
        {
            item.ToonInfo();
        }
    }
}

private static void ToonInfo_EvenIDPrijsGroterDan200(List<ComputerOnderdeel> onderdelen)
{
    Console.WriteLine("\n\n\nToonInfo() voor alle onderdelen met een even ID & prijs < 200");
    foreach (var item in onderdelen)
    {
        if (item.ID % 2 == 0 && item.Prijs < 200)
        {
            item.ToonInfo();
        }
    }
}

private static void Verwijder_InDoos(List<ComputerOnderdeel> onderdelen)
{
    string userInput = "";

    do
    {
        Console.WriteLine("\n\n\nWil je alle onderdelen die in een doos zitten verwijderen? (y/n)");
        userInput = Console.ReadLine();
    } while (userInput != "y" && userInput != "n" && userInput != "yes" && userInput != "no");

    if (userInput == "y" || userInput == "yes")
    {
        for (int i = onderdelen.Count - 1; i >= 0; i--)
        {
            if (onderdelen[i].InDoos)
            {
                onderdelen.Remove(onderdelen[i]);
            }
        }
        Console.WriteLine("Verwijderd.");
    }
}

private static void Verwijder_PrijsOnder100(List<ComputerOnderdeel> onderdelen)
{
    string userInput = "";

    do
    {
        Console.WriteLine("\n\n\nWil je alle onderdelen met een prijs lager dan 100 verwijderen? (y/n)");
        userInput = Console.ReadLine();
    } while (userInput != "y" && userInput != "n" && userInput != "yes" && userInput != "no");

    if (userInput == "y" || userInput == "yes")
    {
        for (int i = onderdelen.Count - 1; i >= 0; i--)
        {
            if (onderdelen[i].Prijs < 100)
            {
                onderdelen.Remove(onderdelen[i]);
            }
        }
        Console.WriteLine("Verwijderd");
    }
}