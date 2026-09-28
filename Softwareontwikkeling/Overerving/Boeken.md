# Boeken

Maak een klasse Boek en gebruik auto-properties voor de velden:

- ISBN (long)

- Titel (string)

- Auteur (string)

- Maak voorts een full property voor Prijs (double)

## TekstBoek

Maak een child-klasse die van Boek overerft genaamd TekstBoek. Een TekstBoek heeft één extra property:

- SchoolGraad (int)

## KoffietafelBoek

Maak een child-klasse die van Boek overerft genaamd KoffietafelBoek. Deze klasse heeft geen extra velden.

Voorts kunnen boeken "opgeteld" worden om als omnibus uitgebracht te worden. De titel wordt dan "Omnibus van X". waarbij X de Auteurs bevat, gescheiden met een komma. De prijs van een Omnibus is steeds de som van beide boeken gedeeld door 2. Schrijf een static methode TelOp die twee Boek objecten als parameter aanvaardt en als returntype een nieuw Boek teruggeeft. Deze methode voeg je toe aan de klasse Boek

In beide child-klassen, override de Prijs-setter zodat:

a) Bij TekstBoek de prijs enkel tussen 20 en 80 kan liggen

b) Bij KoffietafelBoek de prijs enkel tussen 35 en 100 kan liggen

Zorg ervoor dat boeken de ToString overriden zodat je boekobjecten eenvoudig via Console.WriteLine(mijnBoek) hun info op het scherm tonen. Ze tonen deze info als volgt: "Titel - Auteur (ISBN) _ Prijs" (bv The Shining - Stephen King (05848152) _ 50)

Maak boeken aan van de 3 klassen, toon dat de prijs niet altijd zomaar ingesteld kan worden.
