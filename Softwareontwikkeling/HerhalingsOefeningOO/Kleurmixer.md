# Kleurmixer

Meng twee kleuren door het gemiddelde te nemen van hun RGB-waarden.

## Specificaties

- Klassenaam: Kleur

## Properties

- Rood (int)

- Groen (int)

- Blauw (int)

## Methode

MengKleur(Kleur andereKleur) (void)

Werking (MengKleur): Wanneer MengKleur wordt aangeroepen, veranderen de eigenschappen van de huidige kleur (de kleur van het object zelf waarin de methode wordt aangeroepen). De kleur die als parameter wordt meegegeven verandert niet.

## Gebruik deze formules (gehele deling):

- Nieuw Rood = (Huidig Rood + Ander Rood) / 2

- Nieuw Groen = (Huidig Groen + Ander Groen) / 2

- Nieuw Blauw = (Huidig Blauw + Ander Blauw) / 2

## Voorbeeldgebruik

```
Kleur k1 = new Kleur(); // Basiskleur (wordt aangepast)
k1.Rood= 10; k1.Groen= 0; k1.Blauw= 20;

Kleur k2 = new Kleur(); // Mengkleur (blijft hetzelfde)
k2.Rood= 10; k2.Groen= 10; k2.Blauw= 50;

// Meng k2 in k1
k1.MengKleur(k2);

Console.WriteLine($"{k1.Rood},{k1.Groen},{k1.Blauw}");
// Verwachte output: 10,5,35
```
