class Kleur
{
    public int Rood { get; set; }
    public int Groen { get; set; }
    public int Blauw { get; set; }

    public void MengKleur(Kleur voegToeKleur)
    {
        Rood = (voegToeKleur.Rood + Rood) / 2;
        Groen = (voegToeKleur.Groen + Groen) / 2;
        Blauw = (voegToeKleur.Blauw + Blauw) / 2;
    }
}