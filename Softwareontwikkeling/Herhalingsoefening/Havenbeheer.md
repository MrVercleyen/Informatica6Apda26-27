# Havenbeheer

Je bent de havenmeester en moet de lading van een schip beheren. Er is plaats voor een vast aantal containers (bijvoorbeeld 3).

## Maak een programma dat:

Twee arrays aanmaakt: één voor de containercodes (text) en één voor de gewichten (kommagetallen) in ton.

Aan de gebruiker vraagt om de gegevens voor de containers in te voeren.

Een manifest afdrukt: een lijst van alle containers met hun gewicht.

Het totaal gewicht en het gemiddelde gewicht berekent en toont.

De gebruiker toelaat om een container op te zoeken op basis van de code. Als de container gevonden wordt, toon je het gewicht. Zo niet, meld je dat deze nergens staat.

## Voorbeeld uitvoer:

"Tekst die start met ">" is invoer van de gebruiker."

```
Geef de code voor container 1:
> MAS88
Geef het gewicht voor container 1 (ton):
> 12,5
Geef de code voor container 2:
> XEL11
Geef het gewicht voor container 2 (ton):
> 4,2
Geef de code voor container 3:
> OPO99
Geef het gewicht voor container 3 (ton):
> 20

--- Manifest ---
Container MAS88: 12,5 ton
Container XEL11: 4,2 ton
Container OPO99: 20 ton

Totaal gewicht: 36,7 ton
Gemiddeld gewicht: 12,23 ton

Welke container zoek je?
> XEL11
Container XEL11 weegt 4,2 ton.
```
