# Persoon

## Specificaties

- Klassenaam: Persoon

## Properties

- Voornaam (string)

- Achternaam (string)

- GeboorteDatum (DateTime)
  - Validatie (in set): De datum moet liggen tussen 01/01/1990 en DateTime.Today.

  - Bij ongeldige invoer: Stel in op DateTime.Today.

- Methoden:
  - BerekenLeeftijd(): Geeft leeftijd (int) terug op basis van verschil tussen vandaag en GeboorteDatum.
