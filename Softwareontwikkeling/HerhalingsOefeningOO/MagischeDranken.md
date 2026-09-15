# Magische Dranken

Ontwerp een systeem waarin verschillende dranken een magische kracht”\* hebben.

- Maak een basis‑klasse Drank met:
  - Een property voor de naam van de drank.

  - Een constructor die de naam instelt.

  - Een virtuele methode BerekenKracht() die een standaard krachtwaarde (50) teruggeeft.

- Maak een sub‑klasse Elixer die erft van Drank en een extra property IsZeldzaam bevat.
  - Overschrijf de methode BerekenKracht() zodat eerst de basiskracht (verkregen via base.BerekenKracht()) wordt berekend en vervolgens een bonus wordt opgeteld: +20 als IsZeldzaam true is, anders +10.

  - Implementeer een hoofdprogramma waarin je meerdere drankobjecten (bijv. een gewoon drankje en een zeldzaam elixer) aanmaakt en hun berekende kracht op de console toont.
