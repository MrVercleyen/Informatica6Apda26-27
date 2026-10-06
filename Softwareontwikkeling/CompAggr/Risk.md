# Risk

**Land** In het bordspel Risk heeft ieder Land-object volgende eigenschappen:

- Naam van het land

- Leger dat in het land gestationeerd staat.

Voorts implementeert het de **ToString** methode en zal het de informatie oplijsten als volgt:

```
_[Naamland]
 Grootte gestationeerd leger: _[grootte van het leger]
 [of als er geen leger aanwezig is:]: geen leger.
```

## Leger

De Leger klasse heeft een capaciteit (sterkte) die enkel positief kan zijn.

Ieder Leger-object houdt via een referentie ook bij waar het leger gestationeerd is (referentie naar het Land-object).

## Bordspel

Maak een klasse Bordspel dat een lijst van Land-objecten bevat.

Voeg aan de Bordspel klasse een methode "ToonKaart": deze methode zal de landen in de lijst onder elkaar schrijven (via de ToString methode van Land).

Maak een methode VerplaatsLeger dat 2 referenties naar 2 landen aanvaardt. Wanneer de aanroept gebeurt zal eerst gecontroleerd worden of het eerste land een leger bevat (zoniet wordt er een exception opgeworpen). Indien dit in orde is dan zal het leger in kwestie verhuizen naar 2e land op voorwaarde dat daar ook geen leger al is. Als dat wél het geval is dan wordt het leger in het eerste land verwijderd, en wordt de capaciteit van het 2e leger verhoogd met die van het eerste leger.
