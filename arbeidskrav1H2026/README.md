# Arbeidskrav 1, HØST 2026, Backend Programmering
- Student: Jakob Sørli
- Date: 04 - 25th September


## Table of contents
 - Introduction
 - Analyse (oppgave 1)



# 2. Søkealgoritmer – Lineært søk og binærsøk
I denne oppgaven har jeg implementert LinearSearch, og BinarySearch.
jeg har kjørt en rekke tester og svart på spørsmål i oppgaven.

## 2.0 Implementasjon

### 2.1 Lineært søk
Lineært søk og binært søk er to veldig ulike måter å søke i et array. Linære søk søker sekvensielt
gjennom elementene. Hvert eneste element sammenlignes med måleverdien. Algorimen stopper ved første treff
eller når har gått gjennom hele samlingen (Gokstad Akademiet, Økt1 uke 34). Det betyr at i beste fall
så blir den ferdig veldig tidlig, ved f.eks, tom liste, kort liste eller at den treffer verdien tidlig i listen.
I verste fall så går den gjennom en veldig lang liste og bruker lang tid.


### 2.2 Binærsøk
I binærsøk er vi avhengige av at arrayet er sortert. Dette er fordi den hele tiden prøver å peile seg
inn på verdien basert på de grenseverdiene man har satt. Dersom dataene ikke er sorterte vil denne peilingen
bli helt feil og man kan ikke gjennomføre et gyldig søk fordi data som kanskje skulle vært søkt blir valgt bort.
Om man for eksempel søker etter
I binærsøk så sammenligner man alltid den midterste verdien med "target". Hvis målverdien er større eller mindre
forkaster man den delen hvor måleverdien umulig kan være. Dersom man treffer måleverdien med "mid", lagrer man treffet
og fortsetter søket mot venstre, forutsett at arrayet er sortert i stigende rekkefølge mot høyre. På den måten
får finner man den laveste indexen av verdien.

## 2.3 Hvordan sammenligninger telles
<!-- Definer nøyaktig hva du teller som én sammenligning. -->
<!-- Forklar at samme definisjon brukes for begge algoritmene. -->
I denne oppgaven har jeg tolket en sammenligning som når målverdien måles
mot en annen verdi. I linear search så sammenlignes det hver eneste verdi i 
arrayet helt til verdien treffes.
```for (int i = 0; i < array.Length; i++)
{
counter++;
if (value == array[i])
{
result = i;
break;
}
}
```
I BinarySearch så har jeg telt sammenligninger når mid verdien sammenlignes med et 
en annen verdi. Den første sammenligningen skjer når man sjekker om mid er = målverdien.
Den andre sjekken kommer etterpå og da sjekkes det om mid er større enn value.
```
int mid = (left + right) / 2;
comparisons++;
if (array[mid] == value)
{
result = mid;
right = mid - 1;
}

else if (array[mid] > value)
{
comparisons++;
right = mid - 1;
}
// if the value is greater than the value in the mid index,
// move left one index above mid (it's already checked)
else
{
left = mid + 1;
}
```

## 2.4 Testresultater

### 2.4.1 Lineært søk – testdata
<!-- Test på [8, 3, 11, 7, 2, 9, 5]. -->

| Målverdi  | Forventet indeks  | Faktisk indeks | Antall sammenligninger |
|:----------|:------------------|:---------------|:-----------------------|
| 7         | 3                 | 3              | 4                      |
| 42        | -1                | -1             | 7                      |


### 2.4.2 Binærsøk – testdata
<!-- Test på [2, 5, 7, 9, 11, 13, 17]. -->

| Målverdi  | Forventet indeks | Faktisk indeks | Antall sammenligninger |
|:----------|:-----------------|:---------------|:-----------------------|
| 13        | 5                | 5              | 3                      |
| 4         | -1               | -1             | 5                      |


### 2.4.3 Binærsøk på usorterte data
I testene hvor binærsøk ble testet på usorterte lister så kan man ikke stole på resultatet. Listen
var [8, 3, 11, 7, 2, 9, 5].
Jeg kjørte to forsøk, i det ene forsøket søkte den etter tallet 5 som har index 6. Her fant ikke
algoritmen fram til tallet. Det er naturligvis fordi den er programmert til å bruke sorterte lister
og styres av tallene den ser. Den gjorde akkurat som den var programmert til, den fant mid på index 3
hvor tallet 7 befinner seg. Her forkaster den hele høyresiden og søker på venstre hvor måltallet ikke
finnes og algoritmen gjør seg ferdig.

Men når jeg søker etter tallet 9 så finner den riktig index. Det er fordi den søker på høyre
side etter den treffer mid 7. Når den kalkulerer et nytt midtpunkt så tar den 4 + 6 / 2 og finner index
5, hvor tallet 9 befinner seg. Det betyr at algoritmen var i stand til å finne fram til indeksen, til
tross for at listen var usortert. Dette er likevel bare flaks og en grunn til at den ikke kan stoles på.


## 2.5 Tidskompleksitet
// TODO!

### 2.5.1 Lineært søk
<!-- Beste tilfelle: -->
<!-- Verste tilfelle: --> om hele arrayet må undersøkes
<!-- Big-O: --> antall sammenligninger øker omtrent propsjonalt med antall elementer


### 2.5.2 Binærsøk
<!-- Beste tilfelle: -->
<!-- Verste tilfelle: -->
<!-- Big-O: -->

### 2.6 Sammenligning av de to logaritmene
// TODO!


# 3.0 Oppgave 2 - egen generisk datastruktur

### 3.1 Custom stakk
I denne oppgaven valgte jeg å lage stakk. Jeg har verken laget stakk, sirklulær kø, lenket liste eller kø før,
så uansett hvilken jeg lagde visste jeg at dette ville bli en lærerik oppgave.

### 3.2 Hvordan datastrukturen fungerer
<!-- Forklar hvordan strukturen fungerer. -->
Stacken fungerer slik at jeg har to felter T[] items og int count. Disse initialiseres av
konstruktøren. Begge feltene er private, slik at de kun kan behandles gjennom 
APIet. T gjør stacken generisk, som betyr at den kan brukes med ulike datatyper, eks. string, 
float, int etc. 
Jeg har satt en begrensning på 10 items for å kunne teste edgecase på full stack. 
Push(T item) -  setter inn en verdi i den nåværende indeksen og plusser deretter på 1 på count.
Da vil count nå være på èn verdi høyere enn indexen på det siste elementet. Man setter for inn verdi
i index 0 og setter count til 1.
Pop() - reduserer først count med en, og returnerer items[count], da får du den siste
verdien som ble satt inn i stacken.
Peek() - gjør ingenting med count, men returnerer items[count - 1] slik at man kan se det
siste som har blitt satt inn.

Alle API funksjonene har innebygd exception handlers som gjør at de hånderer kall som kan 
krasje koden. For eksempel, en push på full stack, pop() på tom stack osv.

### 3.3 Tester og resultater
Jeg har testet følgende normaltilfeller:
- Pop() på stakk
- Push() på stakk
Jeg har testet følgende kanttilfeller
- Pop() på tom stakk
- Peek() på tom liste
- Push() på full stakk

Testene viste at:
- Push() legger elementer inn i riktig rekkefølge
- Pop() returnerer det siste plasserte elementet først - i tråd med LIFO (last in first out).
- Peek() returnerer det siste innsatte elementet uten å endre på count
- Pop() og Peek() på tom stakk kaster IndexOutOfRangeException
- Push() på full stack kaster IndexOutOfRangeException

### 3.4 Tidskompleksitet
Operasjonenene i denne stakken har tidskompleksitet O(1). Det batyr at antall operasjoner er konstant
og ikke påvirkes av hvor mange elementer som ligger i stakken. 
som gjennomføres hver gang (Microsoft, n.db). Det tar for eksempel ikke lengere tid å
sette inn stakken'1000' i algoritmen enn tallet '1'. Alle operasjonene i dette APIet setter
direkte inn eller returnerer verdier basert på index. Denne indexen får den av count som også
kun gjennomfører en konstant operasjon hver gang, enten legger til eller fjerner 1. Det vil si
at også count++ count--  er O(1)
- Push() - O(1)
- Pop() - O(1)
- Peek() - O(1)

### 3.5 Bruksområder
Denne datastrukturen kan være nyttig mange sammenhenger. Er nyttig når du trenger midlertidig minne
for informasjon, for eksempel når du vil forkaste informasjonen etter du har mottatt den (Microsoft, ingen
dato). 
Eksempler på dette er funksjonskall og rekursjon er det siste funksjonskallet må avsluttes før tidliger
kall kan fortsette. Stakk overflyt er et eksempel på når stakken flyter over fori den inneholder for mange
nestede kall(Microsoft, n.da).

Den kan også være nyttig når man skal implementere angre-funksjonaliteter, som når du skriver
i word og skal angre og andre algoritmer der du ofte vil tilbake til tidligere steg. Man kan 
for eksempel se på Git som en slags stakk, hvor du legger en ny versjon oppå stakken for hver gang.

### 3.6 Refleksjon
Jeg fikk mer erfaring om hvordan man kan styre hva som er synlig for brukeren ved hjelp
av private felter som kun kan returneres ved hjelp av API-kall. Dette har vi allerede lært
om, men jeg føler at jeg fikk enda mer forståelse. Det var også artig å tenke på at man kan bruke 
Pop() en liste, og returnere mange verdier uten at de er slettet. Du får ikke returnert verdiene 
flere ganger, fordi count er redusert, så det eneste du kan gjøre med de indexene som fortsatt lagrer
verdiene er å sette inn.
Når man går fra å ikke kjenne til hvordan slike datastrukturer fungerer til å skulle lage en selv
så møter man mange utfordringer. For min del løste jeg dette med å se videoforklaringer og å gå 
gjennom fagstoff på Gokstad sine hjemmesider. Det har vært svært lærerikt, men også vanskelig.


# Oppgave 3 - QuickSort()

I denne oppgaven valgte jeg QuickSort().


Learning materials:
Videos -
Bro Code "Learn Quick Sort in 13 minutes" -https://www.youtube.com/watch?v=Vtckgz38QHs
Michael Sambol "Quick sort in 4 minutes" - https://www.youtube.com/watch?v=Hoixgm4-P4M
Michael Sambol "Breadth-first search in 4 minutes - https://www.youtube.com/watch?v=HZ5YTanv5QE
tutorialsEUC "How to use queues in C#" - https://www.youtube.com/watch?v=4MQwKvsGCms

Sources:

AlgorithmsNotesForProfessionals  - pdf
Breadth First Search or BFS for a Graph - https://www.geeksforgeeks.org/dsa/breadth-first-search-or-bfs-for-a-graph/
Depth First Search or DFS for a Graph - https://www.geeksforgeeks.org/dsa/depth-first-search-or-dfs-for-a-graph/
Implementing Depth First Search into C# using List and Stack - https://stackoverflow.com/questions/5804844/implementing-depth-first-search-into-c-sharp-using-list-and-stack
Microsoft. (n.d.). Stack<T> class. Microsoft Learn - https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-10.0#remarks
Microsoft. (n.da). Debug StackOverflow errors. Microsoft Learn - https://learn.microsoft.com/en-us/dotnet/core/diagnostics/debug-stackoverflow?tabs=linux