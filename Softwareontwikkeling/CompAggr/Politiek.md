# Politiek

Maak een programma om de politieke situatie van een land te simuleren.

## Maak volgende klassen:

- Land

- Minister

- President

### Minister

Een Minister heeft geen speciale eigenschappen. Enkel een autoproperty om de Naam van de minister in bij te houden

### President

Een President is een minister maar met 1 extra property met private setter: hij heeft een Teller (autoproperty type int) die start op 4 alsook een methode JaarVerderdie deze teller bij iedere aanroep met 1 verlaagt.

### Land

- Een land heeft 0 of 1 president (of koning, kies zelf)

- Een land heeft 0 of 1 eerste minister

- Een land heeft 0 tot 4 ministers (via een List<Minister>)

Al deze compositieobjecten zijn private.

### Een land heeft volgende publieke methoden:

#### MaakRegering

Deze methode aanvaardt volgende parameters:

- 1 president object die aan de private president variabele wordt toegekend

- Een List<Minister> object waarin tussen de 1 tot en met 5 ministers in staan: de eerste minister in de lijst wordt toegewezen aan de private eerste minister variabele. De overige ministers in de lijst worden aan de private lijst van ministers toegewezen.

Deze methode zal enkel iets doen indien er geen president in het land is (null). Indien er reeds een regering is dan zal er een foutboodschap verschijnen.

#### JaarVerder

Deze methode aanroepen zal de JaarVerder aanroepen op de president indien deze er is (en dus niet null is). Deze methode controleert ook of de Teller van de president na deze aanroep op 0 staat. Als dat het geval is dan worden alle ministers en president in het land op null gezet.

## Eindfase

Controleer je klasse Land door enkele ministers en een president te maken en deze in een object van het type Land via MaakRegering door te geven. Test dan wat er gebeurt indien je enkele malen JaarVerder op het land aanroept.

## Verkiezingen

Maak klasse VerkiezingsUitslag. Deze klasse heeft volgende twee full properties:

- VerkozenPresident van het type President.

- VerkozenMinisters van het type List<Minister>.

De default constructor van VerkiezingsUitslag zorgt ervoor dat deze properties automatisch gevuld worden met willekeurige waarden:

- VerkozenPresident wordt een nieuw President-object met een willekeurige naam.

- VerkozenMinisters wordt een List<Minister> met 5 ministers, elk met een willekeurige naam.

```
Tip 1 – willekeurige naam: schrijf in de klasse een private string NaamGen()-methode die een string opbouwt met een willekeurige lengte (bv. tussen 5 en 10 tekens) waarbij elk teken een willekeurige kleine letter is (gebruik bv. (char)rng.Next('a', 'z')).

Tip 2 – ééns Random: declareer Random als static veld op klasseniveau (static Random rng = new Random();). Anders krijg je bij snel achter elkaar aanmaken van objecten dezelfde "willekeurige" namen.
```
