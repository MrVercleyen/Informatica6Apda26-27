# Persoonregistratie

Gebruik constructors en object initializers om personen aan te maken.

## Specificaties

- Klassenaam: Persoon

## Properties (Auto)

- Voornaam (string)

- Achternaam (string)

- Geboortejaar (int)

- Email (string)

## Constructor:

Parameters: voornaam, achternaam.

## Validatie

Indien voornaam gelijk is aan achternaam -> Werp een ArgumentException op met de boodschap "Voornaam en achternaam mogen niet hetzelfde zijn".

## Methode

ToonInformatie() (void): Toont de tekst: "{Voornaam} {Achternaam} geboren in {Geboortejaar} heeft emailadres: {Email}".

## Opdracht in Main:

Maak een Persoon object aan met de constructor.

Gebruik Object Initializer Syntax om ook meteen Geboortejaar en Email in te stellen.

Voorbeeld: new Persoon("Jan", "Janssens") { Geboortejaar = 1990, ... }

Roep ToonInformatie() aan.

Schrijf code die test of je applicatie niet krasht als je een foutieve naam ingeeft (gebruik try-catch).
