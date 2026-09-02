# Voetbalcoach

Een team wenst statistische analyse uit te voeren op de prestaties van hun spelers (rugnummers 1 t.e.m. 12). Er moeten twee types acties bijgehouden worden: positieve en negatieve. Opdracht: Schrijf een programma dat interactief data kan invoeren. De gebruiker geeft een rugnummer en het type actie in (gebruik 'P' voor positief, 'N' voor negatief), gevolgd door het aantal keer dat deze actie voorkwam. De gebruiker bepaalt zelf wanneer de invoer stopt.

### Na afloop toont het programma een rapport met:

Per speler: aantal positieve acties, negatieve acties en het netto resultaat (positief - negatief).

Een aanduiding van de meest en minst performante speler(s).

### Een typische invoer kan dus zijn:

```
2
P
6
```

De coach kiest dus de speler met rugnummer 2, kiest voor een positieve actie ('P'), en voert 6 in als aantal.

In de array op index 1 (rugnummer -1) zal in de 0'de kolom (0 = positieve, 1 = negatieve) het getal 6 geplaatst worden.

Vervolgens kan de coach een ander rugnummer (of hetzelfde) invoeren en zo verder.

Wanneer de coach 99 invoert stopt het programma en worden de finale statistieken getoond

```
Rugnummer   Positief   Negatief   Verschil
1               5       2        3
2               6       7       -1
```
