# Bowlen

Bereken de score van een bowlingwedstrijd.

Bowlen is een spel waarbij spelers een zware bal rollen om kegels (pins) omver te werpen die in een driehoek zijn opgesteld. Schrijf code om de score van een bowlingwedstrijd bij te houden.

## Bowlingpuntentelling

Het spel bestaat uit 10 'frames' (beurten). Een frame bestaat uit één of twee worpen, waarbij aan het begin van het frame 10 kegels staan ​​opgesteld. Er zijn drie scenario's voor de puntentelling van een frame.

- Een 'open frame' is een frame waarin minder dan 10 punten worden gescoord. In dit geval is de score voor het frame gelijk aan het aantal omvergeworpen kegels.

- Een 'spare' houdt in dat alle tien de kegels bij de tweede worp omver worden geworpen. De totale waarde van een spare is 10 plus het aantal kegels dat bij de daaropvolgende worp wordt omvergeworpen.

- Een 'strike' houdt in dat alle tien de kegels bij de eerste worp omver worden geworpen. De totale waarde van een strike is 10 plus het aantal kegels dat bij de volgende twee worpen wordt omvergeworpen. Als een strike direct wordt gevolgd door een tweede strike, kan de waarde van de eerste strike pas worden bepaald nadat er nogmaals is geworpen.

### Hier is een voorbeeld met drie frames:

Frame 1 Frame 2 Frame 3
X (strike) 5/ (spare) 9 0 (open frame)
Frame 1 is (10 + 5 + 5) = 20

Frame 2 is (5 + 5 + 9) = 19

Frame 3 is (9 + 0) = 9

Dit betekent dat het huidige totaal 48 is.

Schrijf code om de score van een bowlingwedstrijd bij te houden.
