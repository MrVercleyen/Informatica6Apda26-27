# Worldbuilding

In deze oefening werk je een vereenvoudigd model uit van een RPG-spelwereld. Spelers kunnen reizen door verschillende werelden (Worlds), waarin zich verschillende zones (Zones) bevinden, zoals een mystiek bos of een verzengende woestijn. In elke zone kunnen voorwerpen (Items) gevonden worden, zoals magische wapens, geneeskrachtige drankjes of schatten.

Je modelleert de relaties tussen deze elementen, waarbij:

- Een World verantwoordelijk is voor het beheren van zijn Zones.

- Elke Zone verantwoordelijk is voor het beheren van de Items die erin liggen.

- Items zelfstandig bestaan (ze kunnen later bijvoorbeeld ook door spelers meegenomen worden).

## World (Wereld)

Een World stelt één volledig spelgebied voor. Spelers kunnen pas een wereld binnengaan als ze een bepaald minimum level hebben.

### Properties:

- Name (string): de naam van de wereld (bv. "Mystica", "Darklands").

- LevelRequirement (int): het minimum level dat spelers moeten hebben om toegang te krijgen.

- Zones (List): alle zones die deel uitmaken van deze wereld. Dit is compositie: een wereld beheert zijn eigen zones.

### Methoden:

- AddZone(Zone zone): voegt een nieuwe zone toe aan de wereld.

- GetZonesAboveDifficulty(int difficulty): geeft een lijst van alle zones waarvan de moeilijkheidsgraad hoger is dan een opgegeven waarde.

- PrintWorldInfo(): toont alle informatie over de wereld, inclusief alle zones en hun gegevens.

## Zone (Gebied)

Een Zone is een deelgebied binnen een wereld, bijvoorbeeld een magisch bos of een ruïne.

### Properties:

- Name (string): de naam van de zone.

- DifficultyLevel (int): hoe moeilijk het is om in deze zone te overleven (op schaal bv. 1–10).

- Items (List): de voorwerpen die in deze zone te vinden zijn. (tip: dit is aggregatie: de zone bevat verwijzingen naar bestaande items, maar vernietigt ze niet automatisch als de zone wordt verwijderd.)

### Methoden:

- AddItem(Item item): voegt een item toe aan de lijst van beschikbare voorwerpen in deze zone.

- GetValuableItems(int minimumValue): geeft alle items terug die minstens zoveel waard zijn als de opgegeven minimumwaarde.

- PrintZoneInfo(): toont de gegevens van de zone, inclusief een opsomming van de items.

## Item (Voorwerp)

Een Item is een los object dat spelers kunnen vinden of verzamelen.

### Properties:

- Name (string): naam van het voorwerp (bv. "Magic Sword", "Healing Potion").

- Weight (double): het gewicht van het item (belangrijk voor inventarisbeheer).

- Value (int): de marktwaarde of verkoopprijs van het item in goudstukken.

### Methoden:

- static CompareValue(Item item1, Item item2): vergelijkt twee items en toont welk item meer waard is, of dat ze evenveel waard zijn.

## Functionele vereisten

- Werelden en zones beheren
  - Een World moet zones kunnen toevoegen.
  - De Zones worden volledig eigendom van de World (compositie).

- Zones en voorwerpen beheren
  - Een Zone kan items bevatten.
  - Items kunnen onafhankelijk bestaan; ze kunnen bv. ook aan spelersinventarissen toegevoegd worden.

- Zoeken en filteren
  - Vanuit een wereld kunnen zones opgehaald worden die moeilijker zijn dan een bepaald niveau.
  - Vanuit een zone kunnen waardevolle items opgehaald worden boven een bepaalde waarde.

- Vergelijken van items
  - Gebruik een statische methode om twee items qua waarde te vergelijken.

- Informatie printen
  - Print methoden zorgen voor duidelijke overzichten, bruikbaar voor bijvoorbeeld debugging of simpele spelinterface.

## Voorbeeldcode

```
// Wereld aanmaken
World myWorld = new World("Mystica", 10);

// Zones aanmaken
Zone forest = new Zone("Enchanted Forest", 5);
Zone desert = new Zone("Burning Desert", 8);

// Items aanmaken en toevoegen
forest.AddItem(new Item("Magic Sword", 3.5, 1200));
forest.AddItem(new Item("Healing Potion", 0.5, 150));
desert.AddItem(new Item("Sand Cloak", 1.2, 300));

// Zones toevoegen aan wereld
myWorld.AddZone(forest);
myWorld.AddZone(desert);

// Informatie ophalen
Console.WriteLine("--- Zones moeilijker dan level 6 ---");
var hardZones = myWorld.GetZonesAboveDifficulty(6);
foreach (var zone in hardZones)
{
    Console.WriteLine(zone.Name);
}

// Items filteren
Console.WriteLine("--- Waardevolle items in het bos ---");
var valuableItems = forest.GetValuableItems(500);
foreach (var item in valuableItems)
{
    Console.WriteLine($"{item.Name}: {item.Value} gold");
}

// Items vergelijken
Console.WriteLine("--- Vergelijk items ---");
Item.CompareValue(forest.Items[0], desert.Items[0]);

// Wereldinfo tonen
myWorld.PrintWorldInfo();
```
