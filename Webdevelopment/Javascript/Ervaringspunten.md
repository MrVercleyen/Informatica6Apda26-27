# Ervaringspunten

Je werkt voor een bedrijf dat een online fantasy-survivalgame maakt.

Wanneer een speler een level voltooit, krijgt hij of zij energiepunten toegekend. Het aantal toegekende energiepunten hangt af van welke magische voorwerpen de speler tijdens het verkennen van dat level heeft gevonden.

## Opdracht

Het is jouw taak om de code te schrijven die de energiepunten berekent die aan spelers worden toegekend wanneer ze een level voltooien.

### De toegekende punten zijn afhankelijk van twee dingen:

- Het level (een getal) dat de speler heeft voltooid.
- De basiswaarde van elk magisch voorwerp dat de speler tijdens dat level heeft verzameld.

### De energiepunten worden toegekend volgens de volgende regels:

- Neem voor elk magisch voorwerp de basiswaarde en zoek alle veelvouden van die waarde die kleiner zijn dan het levelnummer.
- Voeg de reeksen getallen samen.
- Verwijder eventuele duplicaten.
- Bereken de som van alle overgebleven getallen.

### Laten we eens naar een voorbeeld kijken:

De speler heeft level 20 voltooid en twee magische voorwerpen gevonden met basiswaarden van 3 en 5.

Om de energiepunten te berekenen die de speler heeft verdiend, moeten we alle unieke veelvouden van deze basiswaarden vinden die kleiner zijn dan level 20.

- Veelvouden van 3 kleiner dan 20: {3, 6, 9, 12, 15, 18}
- Veelvouden van 5 kleiner dan 20: {5, 10, 15}
- Voeg de verzamelingen samen en verwijder dubbele getallen: {3, 5, 6, 9, 10, 12, 15, 18}
- Tel de unieke veelvouden bij elkaar op: 3 + 5 + 6 + 9 + 10 + 12 + 15 + 18 = 78
- De speler verdient dus 78 energiepunten voor het voltooien van niveau 20 en het vinden van de twee magische voorwerpen met basiswaarden van 3 en 5.
