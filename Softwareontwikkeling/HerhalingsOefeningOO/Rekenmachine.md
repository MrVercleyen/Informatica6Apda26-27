# Rekenmachine

Maak een rekenmachine-klasse die bewerkingen uitvoert op twee getallen.

## Specificaties

    Klassenaam: Rekenmachine

## Properties

    Getal1 (type: int): Het eerste getal.

    Getal2 (type: int): Het tweede getal.

## Methoden

    Som(): returntype int

    Verschil(): returntype int

    Product(): returntype int

    Quotient(): returntype double

## Werking

Som, Verschil, Product: Voeren de standaard wiskundige bewerking uit (+, -, \*) en geven het resultaat terug.

- Quotient: Deelt Getal1 door Getal2.
  - Let op: Delen door nul mag niet.

  - Als Getal2 gelijk is aan 0: Toon foutboodschap "Kan niet delen door 0" in de console EN geef 0.0 terug.

  - Anders: Geef het resultaat van de deling terug.

## Voorbeeldgebruik:

```
NummerBerekenaar paar1 = new NummerBerekenaar();
paar1.Getal1 = 12;
paar1.Getal2 = 34;

Console.WriteLine($"Som = {paar1.Som()}");
// Output: 46
Console.WriteLine($"Verschil = {paar1.Verschil()}");
// Output: -22
```
