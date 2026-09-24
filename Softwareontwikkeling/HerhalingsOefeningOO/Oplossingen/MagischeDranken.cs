class Drank
{
    public string Naam { get; set; }

    public Drank(string naam)
    {
        Naam = naam;
    }

    public virtual int BerekenKracht()
    {
        return 50;
    }
}


class Elixer : Drank
{
    public bool IsZeldzaam { get; set; }

    public Elixer(string naam, bool isZeldzaam) : base(naam)
    {
        IsZeldzaam = isZeldzaam;
    }

    public override int BerekenKracht()
    {
        int basisKracht = base.BerekenKracht();
        int bonus 10;
        if (IsZeldzaam)
        {
            bonus = 20;
        }
        return basisKracht + bonus;
    }
}


class Program
{
    static void Main(string[] args)
    {

        Drank gewoonDrank = new Drank("Gewone Cola");
        Elixer zeldzaamElixer = new Elixer("Mystiek Elixer", true);
        Elixer standaardElixer = new Elixer("Standaard Elixer", false);

        Console.WriteLine($"{gewoonDrank.Naam} heeft kracht: {gewoonDrank.BerekenKracht()}");
        Console.WriteLine($"{zeldzaamElixer.Naam} heeft kracht: {zeldzaamElixer.BerekenKracht()}");
        Console.WriteLine($"{standaardElixer.Naam} heeft kracht: {standaardElixer.BerekenKracht()}");
    }
}