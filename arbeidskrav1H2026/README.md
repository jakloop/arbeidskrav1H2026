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
eller når har gått gjennom hele samlingen (Gokstad Akademiet, n.d.a). Det betyr at i beste fall
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


# 4.0 Oppgave 3 - QuickSort()

### 1. Valg av algoritme og pivotstrategi
Jeg valgte QuickSort()-algoritmen fordi jeg syntes den virket spennende å implementere. Jeg
har ikke implementert verken MergeSort eller QuickSort før, så valget for meg var helt tilfeldig.

### 2. Hvordan QuickSort fungerer
QuickSort fungerer slik at den jobber seg gjennom arrayet ved hjelp av en pivot. I min kode er pivot-strategien slik
at man velger det siste elementet (del)arrayet som pivot. Deretter går man gjennom alle verdiene i (del)arrayet, 
bortsett fra pivoten, og setter de verdiene som er mindre enn pivoten til venstre. Når arrayet er gjennomgått, 
setter man pivoten på riktig plass, slik at verdiene som er mindre enn pivoten er til venstre, og resten er til høyre.

Deretter kjøres det i gang to nye QuickSort-funksjoner. Disse funksjonene jobber på hver sin side av pivoten. 
Hver av disse sidene deles nok en gang opp helt til delarrayet består av 0 eller 1 element. Da returnerer funksjonene 
uten å gjøre noe mer. Dette sørger for at rekursjonen stopper og forhindrer en uendelig loop.

- QuickSort() stopper når delarrayet har 0 eller 1 element.
- Partition() finner pivotens endelige plassering.
- Algoritmen kaller deretter QuickSort() rekursivt på området til venstre og høyre for pivoten.
- Når alle delområdene er ferdig behandlet, er hele arrayet sortert.

### 3. Sammenligninger og bytter
- Jeg teller sammenligninger mellom `arr[j]` og pivoten.
- Jeg teller også antall bytter som utføres når et element er mindre enn pivoten.
- [Sett inn resultatene fra testene dine.]
- Dette gjør det mulig å sammenligne hvor mye arbeid QuickSort gjør på forskjellige typer input.


### 4. Testresultater (AI hjalp til med å lage tabellen)
Jeg testet algoritmen med:
* Vanlig/usortert array
* Allerede sortert array
* Omvendt sortert array
* Array med duplikater
* Tomt array
* Array med ett element

| Test                   | Før                                    | Etter                                  | Comparisons | Swaps | Resultat    |
| ---------------------- | -------------------------------------- | -------------------------------------- | ----------: | ----: | ----------- |
| Vanlig/usortert array  | `[64, 34, 25, 12, 22, 11, 90]`         | `[11, 12, 22, 25, 34, 64, 90]`         |          19 |    16 | Test passed |
| Allerede sortert array | `[1, 2, 3, 4, 5]`                      | `[1, 2, 3, 4, 5]`                      |          10 |    14 | Test passed |
| Omvendt sortert array  | `[9, 8, 7, 6, 5]`                      | `[5, 6, 7, 8, 9]`                      |          10 |     8 | Test passed |
| Array med duplikater   | `[64, 34, 25, 12, 22, 22, 11, 34, 90]` | `[11, 12, 22, 22, 25, 34, 34, 64, 90]` |          25 |    23 | Test passed |
| Tomt array             | `[]`                                   | `[]`                                   |           0 |     0 | Test passed |
| Array med ett element  | `[1]`                                  | `[1]`                                  |           0 |     0 | Test passed |

Alle testene kontrollerer at resultatet er sortert og at kanttilfellene håndteres korrekt.

### 5. Tidskompleksitet
- Beste tilfelle: O(n log n)
- Gjennomsnittlig tilfelle: O(n log n)
- Verste tilfelle: O(n^2)
- Plasskompleksitet: O(log n) i gjennomsnitt på grunn av rekursjonen, men O(n) i verste tilfelle.

### 6. Betydningen av pivotvalg
I min strategi så velger jeg det siste elementet som pivot. Hvilken verdi dette elementet har kan påvirke ytelsen
og hvor jevnt arrayet blir delt.

Hvis pivoten havner omtrent på midten, vil de nye delarrayene bli ca. like store og man vil få en ganske balansert
rekursjon, hvor begge rekursjonene starter omtrent like mange nye nivåer. Siden jeg alltid velger det siste elementet
som pivot, kan pivotvalget påvirke hvor jevnt arrayet blir delt.
Både det beste og gjennomsnittlige utfallet av ytelse i QuickSort har O(n log n) (Gokstad Akademiet, n.d.). I disse
tilfellene får man et logaritmisk antall nivåer, fordi delarrayene blir omtrent halvert for hver gang en ny partition
aktiveres.

Om man er uheldig med pivotvalg, derimot, blir ytelsen svakere. Vi kan for eksempel se i testen med det sorterte
arrayet at det er flere swaps enn det er i det usorterte arrayet. Det kommer av at for hver ny partition blir det
siste elementet valgt som pivot. Når arrayet allerede er sortert, vil pivoten være det største elementet, og nesten
alle elementene vil bli 'satt' på venstre side i partisjoneringen. I verste tilfelle blir partitioneringen veldig 
ubalansert. Da kan det ene delarrayet inneholde nesten alle elementene,
mens det andre delarrayet nesten er tomt. Dette gjør at man får omtrent 'n' nivåer i rekursjonen i stedet for log₂(n),
og tidskompleksiteten blir O(n^2).


### 7. Styrker og svakheter
Styrken med quicksort er at den er ganske så effektiv når pivotstrategien passer godt til arrayet.
Da vil du kunne få en ytelse som er tilnærmet logaritmisk. En annen styrke er at alt foregår i det samme
arrayet hele tiden. Da slipper man å returnere et nytt array som må lagres.

Svakheten til quicksort er at pivotstrategien også kan føre til O(n^2).
Jeg har også hørt at lange lister med dype rekursjoner kan føre til stackoverflow. StackOverflow er når kjøringsstakken
går tom for plass til nye rekursjoner fordi den inneholder for mange nestede metodekall (Microsoft. n.da).

### 8. Refleksjon
//TODO!
Testene viste at 
- Hva viste testene om forskjellen mellom de ulike inputtypene?
- Hvordan påvirket pivotstrategien resultatene?
- Hva lærte jeg om rekursjon og del-og-hersk?


# 5.0 Breadth First Search

## 5.1 Forklaring av Graph

For å lage grafen som brukes i Breadth First Search og Depth First Search
så har jeg brukt en 'adjacecy list'. Det består av en dictionary med nøkkel/key og verdier/value.
Hvor nøkkelene består av stasjonene og verdiene er nabostasjonene. For eksempel, hvis Majorstuen
har to naboer, NationalTheateret og Blindern, vil nøkkelen være ["Majorstuen"] og verdien være ["Nationaltheateret", 
"Blindern"].
Når Nationaltheateret er nøkkel vil den ha ["Majorstuen", "Stortinget"] som sine values. Og sånn dannes kantene mellom
stasjonene. Verdiene er også satt om som HashSet<string> som gjør at man sikrer at man hindrer duplikatstasjoner i
verdilista. En annen grunn til at det er satt opp som HashSet er at dette er en rask value å hente fra, man slipper 
for eksempel å kjøre en loop. Man henter med ytesle O[1] fordi man kan hente objektet direkte ut, som i en liste med
en index.

For å lage stasjoner så bruker man 'AddStation()'. Her sjekkes det først om grafen allerede inneholder 
stasjonen, og hvis den ikke gjør det så oppretter den en ny Key med den verdien.
```
    public void AddStation(string station)
    {
        if (!graph.ContainsKey(station))
        {
            graph[station] = new HashSet<string>();
        }
    }

```

For å lage en knytning mellom to stasjoner så bruker man AddConnection(), denne metoden
sjekker først om stasjonene eksisterer som nøkler. Hvis de ikke eksisterer så opprettes de. 
Når denne sjekken passeres så legges de inn som nøkler hos hverandre
```
        graph[stationA].Add(stationB);
        graph[stationB].Add(stationA);
```

GetNeighbors() - lar oss see hvilke naboer en stasjon har.

ContainsStation() - lar oss sjekke om grafen inneholder den stasjonen vi er 
ute etter ved hjelp av.
```
return graph.ContainsKey(station);
```

IsEmpty() - Sjekker om grafen er tom.


## 5.2 Breadth First Search
Breadth First Search er en algoritme som fungerer slik at den går gjennom grafen horisontalt. 

Man går gjennom hver node og legger til naboene i køen som skal sjekkes. Når da en nabo sjekkes så så legger man også til
dens naboer i køen. I en kø (queue), så opererer man etter 'first in first out' prinsippet. Det gjør at man sjekker
elementene i den rekkefølgen de ble lagt inn i. 

Man kan for eksempel se på 'majorstuen', som er nabo med både 
'Nationaltheateret' og 'Blindern'. Via disse så går stasjonene ut i 2 ulike grener, og man kan se at begge disse naboene
som er 1 stasjon unna sjekkes først. Deretter går man løs på naboenes nabo som er 2 stasjoner unna 'majorstuen'.
På denne måten sjekkes hvert eneste 'nivå' slik at man har gått gjennom alle stasjonene som har kobling til 'majorstuen'.

For å unngå å gjennomgå samme stasjon flere ganger så lagrer metodene de besøkte stasjonene i en HashSet verdi. HashSet
har den egenskapen at man ikke kan lagre like duplikater. Så hver gang man skal sjekke en nabo i køen så sjekkes
det om den allerede finnes i den listen. Da besøkes hver stasjon som er koblet til stasjonA kun en gang.

## 5.3 ShortestDistance - Korteste vei
I ShortestDistance() så kan man finne ut hva som er færrest mulig antall kanter mellom stasjonA og stasjonB.
Den fungerer ganske likt som Breadt First Search, men her sjekkes stasjonene i køen mot stasjonB for å se om man
har kommet frem. Hvis man har kommet frem så returneres distansen med 'distance[current]'. Dersom grafen går gjennom
hele køen uten å finne stasjonB så returneres -1, med en melding om at det ikke finnes en rute mellom stasjonene. 

## 5.4 Tests (AI help with making the table)
Dette er testene jeg kjørte på algoritmen

| Test                    | Hva testes                                      | Forventet resultat | Resultat |
| ----------------------- |-------------------------------------------------| -----------------: | -------: |
| BFS fra Majorstuen      | Besøksrekkefølgen gjennom alle nåbare stasjoner | 9 stasjoner besøkt |  Bestått |
| Majorstuen → Grønland   | Korteste antall stopp                           |                  4 |  Bestått |
| Tøyen → Ullevål Stadion | Færrest antall kanter mellom de to grenene      |                  8 |  Bestått |
| BFS fra isolert stasjon | Kun den isolerte stasjonen skal besøkes         |   1 stasjon besøkt |  Bestått |
| Sognsvann → Tøyen       | Ingen rute mellom isolert stasjon og Tøyen      |                 -1 |  Bestått |
| Ukjent startstasjon     | Håndtering av stasjon som ikke finnes           |                 -1 |  Bestått |
| Ukjent mål              | Håndtering av mål som ikke finnes               |                 -1 |  Bestått |
| Tom graf                | Håndtering av tom graf uten krasj               |                 -1 |  Bestått |

BFS fra `Majorstuen` besøkte stasjonene i følgende rekkefølge:

`Majorstuen → Nationaltheateret → Blindern → Stortinget → Forskningsparken → Jernbanetorget → Ullevål Stadion → Grønland → Tøyen`

Alle testene ga forventet resultat.

## 5.5 Plass og tidsskompleksitet
BFS har tidskompleksitet O(V + E). V er antall noder(eller stasjoner i dette tilfellet og E er antall kanter.

O(V+E) forklares ved at hver stasjon (V) bare besøkes maks en gang, og at hver forbindelse undersøkes når naboene
blir gått gjennom.

BFS har en plasskomplekistet: O(V), fordi BFS i aller verste konsekvens må lagre et veldig langt nivå i 
køen samtidig (Gokstad Akakademiet, n.d.b) . La oss si at 'majorstuen' ikke er koblet til bare to naboer, men for eksempel 1000. Da må
alle de naboene ligge i køen samtidig.



# 6.0 Depth First Search

## 6.1 Recursive

## 6.2 Iterative

## 6.3 RouteExists
Jeg har valgt ruteteliknykting som utvidelse for depth first search.
Metoden sjekker om det finnes en rute mellom to stasjoner. Den sier ikke noe avstand
eller andre ting.

## 6.4 Testing


## 6.5 DFS og BFS
Begge DFS-metodene besøker de samme stasjonene, men rekkefølgen blir forskjellig. Den iterative metoden bruker en Stack,
som følger LIFO-prinsippet. Når flere naboer legges på stacken, blir den siste naboen som ble lagt inn behandlet først.
Dette gjør at den iterative DFS-en kan følge en annen gren først enn den rekursive DFS-en. Rekkefølgen på naboene
påvirker derfor besøksrekkefølgen, selv om alle nåbare stasjoner blir besøkt.

Sammenlignet med BFS --

## Tidskompleksitet

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
Gokstad Akademiet. (n.d.a) Teori: sortering og ytelse. Økt 2 - Uke 35 - https://lms.gokstadakademiet.no/mod/scorm/player.php?a=15&currentorg=ORG_1&scoid=119
Gokstad Akademiet. (n.d.b) 03-teori. Økt 3 - Uke 36 - https://lms.gokstadakademiet.no/mod/scorm/player.php?a=18&currentorg=ORG_1&scoid=144
Implementing Depth First Search into C# using List and Stack - https://stackoverflow.com/questions/5804844/implementing-depth-first-search-into-c-sharp-using-list-and-stack
Microsoft. (n.d.). Stack<T> class. Microsoft Learn - https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-10.0#remarks
Microsoft. (n.da). Debug StackOverflow errors. Microsoft Learn - https://learn.microsoft.com/en-us/dotnet/core/diagnostics/debug-stackoverflow?tabs=linux