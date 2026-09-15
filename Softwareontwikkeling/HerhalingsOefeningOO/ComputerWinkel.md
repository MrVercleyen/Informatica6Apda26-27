# ComputerWinkel

Een firma heeft een grote lijst met computeronderdelen en wil hier de nodige filters op kunnen toepassen.

## Computeronderdeel

De klasse computeronderdeel bestaat uit volgende autoproperties:

- Prijs (int)

- ID (int)

- InDoos (bool)

Voorts heeft de klasse een default constructor die voorgaande autoproperties op willekeurige waarden instelt (prijs positief tot max 1000, ID een getal tussen 100 en 999, en InDoos heeft 50% kan om true te zijn)

De klasse heeft 1 methode ToonInfo die de 3 waarden van het object naar het scherm stuurt:

```
Prijs: 845, ID: 45, InDoos: true
```

## Filteren

Maak in je hoofdprogramma een List dat je vult met 100 willekeurige aangemaakte objecten. Vervolgens:

Roep de ToonInfo methode aan van ieder computeronderdeel in de lijst aan.

Roep de ToonInfo methode aan van ieder computeronderdeel met een prijs boven de 400.

Idem nu voor alle onderdelen die in een doos zitten.

Idem nu voor alle onderdelen die een even ID hebben én wiens prijs onder de 200 ligt.

Tussen iedere filter toon je op het scherm wat de volgende lijst juist voorstelt (bv "Nu tonen we alle onderdelen in een doos").

## Managen

Vraag nu aan de gebruiker wat er met de lijst moet gebeuren:

Alle objecten in een doos verwijderen

Alle objecten met een prijs kleiner dan 100 verwijderen.

Toon het resultaat van de aangepaste lijst (door de ToonInfo van ieder object in de lijst aan te roepen.)

## Finale

Kan je hier een volledige applicatie van maken die een computerfirma als een soort inventaristool kan gebruiken? (en dus met de nodige menu's en mogelijkheden om bijvoorbeeld een nieuw onderdeel toe te voegen.) Kijk zeker eens naar volgende oefening daaromtrent.
