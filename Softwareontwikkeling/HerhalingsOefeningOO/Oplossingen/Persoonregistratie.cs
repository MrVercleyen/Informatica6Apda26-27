class Persoon
{
    public Persoon(string vNaam, string aNaam)
    {

        if (vNaam == aNaam)
            throw new Exception("Voornaam en achternaam mag niet hetzelfde zijn");

        Voornaam = vNaam;
        Achternaam = aNaam;
    }

    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public int Geboortejaar { get; set; }
    public string Email { get; set; }

    internal void ToonInformatie()
    {
        Console.WriteLine($"{Voornaam} {Achternaam} geboren in {Geboortejaar} heeft emailadres: {Email}");
    }
}


//Main klasse code
class main
{
    public static void main(string[] args)
    {
        try
        {
            Persoon p = new Persoon("Tim", "Dams") { Geboortejaar = 1981, Email = "tim.dams@ap.be" };
            p.ToonInformatie();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
