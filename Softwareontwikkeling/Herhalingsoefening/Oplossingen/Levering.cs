int[] postcodes = { 1000, 2020, 2013, 4500, 2340, 1200, 9999, 6666, 2362, 2340 };

int[] kgpergemeente = { 12, 214, 3, 15, 56, 900, 13, 5, 111, 43 };

Console.WriteLine(Geef gewicht pakket);
int gewicht = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Naar welke postcode wenst u dit pakket te versturen);
int postcode = Convert.ToInt32(Console.ReadLine());

//Zoek postcode
bool gevonden = false;
int index = 0;
do
{

    if (postcodes[index] == postcode)
    {
        gevonden = true;
    }
    else
        index++;
} while (!gevonden && index  postcodes.Length);
//berekenprijs
if (gevonden)
{
    int prijs = gewicht  kgpergemeente[index];
    Console.WriteLine($Dit zal {prijs} euro kosten.);
}
else
    Console.WriteLine(Postcode niet gevonden!);
