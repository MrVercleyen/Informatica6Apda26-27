# Oefening 3 – Boodschappenbudget

Maak een eenvoudige **WinForms-applicatie** waarmee je je boodschappen en uitgaven kunt bijhouden.

## Opdracht

Maak een formulier waarin de gebruiker boodschappen kan toevoegen.

Voorzie invoervelden voor:

- Naam van het product
- Categorie (Voeding, Drank, Huishouden)
- Prijs
- Aantal

Gebruik een **ListView** om alle boodschappen weer te geven.

### Werking

Wanneer de gebruiker op **Toevoegen** klikt:

1. Lees de gegevens uit de invoervelden.
2. Bereken de totale prijs van het product (`prijs × aantal`).
3. Voeg het product toe aan de ListView.
4. Toon de productnaam, categorie, aantal en totale prijs in aparte kolommen.

Wanneer de gebruiker op **Totaalbedrag** klikt:

1. Bereken de som van alle productprijzen in de ListView.
2. Toon het totale bedrag in een messagebox.

### Bonus

Voeg een knop **Verwijderen** toe waarmee je een geselecteerd product uit de boodschappenlijst kunt verwijderen.
