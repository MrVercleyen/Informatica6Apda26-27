//de array voor de codes van de containers
string[] containercodes = new string[3];
//de array voor de gewichten van de containers
int[] containerweights = new int[3];

//loopcounter
int counter = 0;
//totale gewicht voor de manifest
int totalWeight = 0;

do
{
    //start elke loop met het opvragen van een code
    Console.WriteLine($"Geef de code voor container {counter + 1} :");
    //opvragen invoer van de gebruiker
    string codeAnswer = Console.ReadLine();
    //de invoer opslaan op de positie in de array overeenkomstig met de loopcounter
    containercodes[counter] = codeAnswer;

    //vervolgens het gewicht opvragen van de container
    Console.WriteLine("Geef het gewicht voor container " +(counter + 1) + " (ton):");
    //opvragen invoer van de gebruiker
    int weightAnswer = int.Parse(Console.ReadLine());
    //de invoer opslaan op de positie in de array overeenkomstig met de loopcounter
    containerweights[counter] = weightAnswer;

    //de loopcounter verhogen met 1 op het einde van de loop
    counter++;

//Voer de loop 3 keer uit
} while (counter < 3);
Console.WriteLine("--- Manifest ---");

//loop over de array om het overzicht uit te printen
for (int i = 0; i < containercodes.Length; i++)
{
    Console.WriteLine($"Container {containercodes[i]}: {containerweights[i]} ton");
    //in dezelfde loop het totale gewicht berekenen
    totalWeight += containerweights[i];
}

//Het totale en gemiddelde gewicht uitprinten
Console.WriteLine();
Console.WriteLine($"Totaal gewicht: {totalWeight} ton");
Console.WriteLine($"Gemiddeld gewicht: {totalWeight/3} ton");

//Als laatste een specifieke container op laten zoeken
Console.WriteLine();
Console.WriteLine("Welke container zoek je?");

string searchAnswer = Console.ReadLine();

//loopen over alle containercodes tot de juiste code overeenkomt
for(int i = 0; i < containercodes.Length; i++)
{
    //als de code bestaat en overeenkomt print je het resultaat uit
    if(searchAnswer == containercodes[i])
    {
        Console.WriteLine($"Container {containercodes[i]} weeg {containerweights[i]} ton.");
    }
}

