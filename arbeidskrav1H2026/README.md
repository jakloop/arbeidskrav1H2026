

# Arbeidskrav 1, HØST 2026, Backend Programmering
- Modul 1: Algoritmer 
- Student: Jakob Sørli
- Date: 04 - 25th September

## Filstruktur
```
Assignment1.App/
├── Assignment1.Tasks/
│   ├── Task1/
│   │   ├── SearchAlgorithms.cs
│   │   └── SearchTests.cs
│   ├── Task2/
│   │   ├── CustomStack.cs
│   │   └── CustomStackTests.cs
│   ├── Task3/
│   │   ├── QuickSort.cs
│   │   └── QuickSortTests.cs
│   ├── Task4/
│   │   ├── BFSearch.cs
│   │   └── BFSearchTests.cs
│   ├── Task5/
│   │   ├── DFSearch.cs
│   │   └── DFSearchTests.cs
│   ├── GraphClass.cs
│   └── TestCheck.cs
├── Program.cs
├── AI_DOCUMENTATION.md
└── README.md
```

## Innholdsfortegnelse
(AI hjalp med å lage innholdsfortegnelse)
- [Filstruktur](#filstruktur)
- [2.0 Søkealgoritmer – Lineært søk og binærsøk](#2-søkealgoritmer--lineært-søk-og-binærsøk)
    - [2.0 Implementasjon](#20-implementasjon)
        - [2.1 Lineært søk](#21-lineært-søk)
        - [2.2 Binærsøk](#22-binærsøk)
    - [2.3 Hvordan sammenligninger telles](#23-hvordan-sammenligninger-telles)
    - [2.4 Testresultater](#24-testresultater)
    - [2.5 Tidskompleksitet](#25-tidskompleksitet)
    - [2.6 Sammenligning av tidskompleksitet](#26-sammenligning-av-tidskompleksitet)
- [3.0 Egen generisk datastruktur](#30-oppgave-2---egen-generisk-datastruktur)
    - [3.1 Egen stakk](#31-egen-stakk)
    - [3.2 Hvordan datastrukturen fungerer](#32-hvordan-datastrukturen-fungerer)
    - [3.3 Tester og resultater](#33-tester-og-resultater)
    - [3.4 Tidskompleksitet](#34-tidskompleksitet)
    - [3.5 Bruksområder](#35-bruksområder)
    - [3.6 Refleksjon](#36-refleksjon)
- [4.0 QuickSort()](#40-oppgave-3---quicksort)
    - [4.1 Valg av algoritme og pivotstrategi](#41-valg-av-algoritme-og-pivotstrategi)
    - [4.2 Hvordan QuickSort fungerer](#42-hvordan-quicksort-fungerer)
    - [4.3 Sammenligninger og bytter](#43-sammenligninger-og-bytter)
    - [4.4 Testresultater](#44-testresultater)
    - [4.5 Tidskompleksitet](#45-tidskompleksitet)
    - [4.6 Betydningen av pivotvalg](#46-betydningen-av-pivotvalg)
    - [4.7 Styrker og svakheter](#47-styrker-og-svakheter)
    - [4.8 Refleksjon](#48-refleksjon)
- [5.0 Breadth First Search](#50-breadth-first-search)
    - [5.1 Forklaring av Graph](#51-forklaring-av-graph)
    - [5.2 Breadth First Search](#52-breadth-first-search)
    - [5.3 ShortestDistance - Korteste vei](#53-shortestdistance---korteste-vei)
    - [5.4 Tests](#54-tests)
    - [5.5 Plass og tidskompleksitet](#55-plass-og-tidskompleksitet)
- [6.0 Depth First Search](#60-depth-first-search)
    - [6.1 Recursive Depth First Search](#61-recursive)
    - [6.2 Iterative Depth First Search](#62-iterative)
    - [6.3 RouteExists](#63-routeexists)
    - [6.4 Testing](#64-testing)
    - [6.5 DFS og BFS](#65-dfs-og-bfs)
    - [6.6 Tids- og plasskompleksitet](#66-tids-og-plasskompleksitet)
- [Learning materials](#learning-materials)
- [Sources](#sources)


# 1. Introduksjon
Dette er det første arbeidskravet på år. 2 Backend Programmering. Det dreier seg om algorimer, Big-O og datastrukturer.
I dette arbeidskravet har jeg jobbet med, lineærsøk, binærsøk, stack, quicksort, breadth-first search og depth-first
search og mye annet knyttet til dette. En annen sentral del av oppgaven var også å teste algoritmene mot vanlig bruk
og kanttilfeller.

I tillegg til dette, består oppgaven av å lage en videopresentasjon hvor man skal reflektere. Den ligger vedlagt i 
innleveringsfilen


# 2. Søkealgoritmer – Lineært søk og binærsøk
I denne oppgaven har jeg implementert LinearSearch, og BinarySearch.

## 2.0 Implementasjon
### 2.1 Lineært søk
Lineært søk og binært søk er to veldig ulike måter å søke i et array. Lineære søk søker sekvensielt
gjennom elementene og hvert eneste element sammenlignes med målverdien. Algortimen stopper ved første treff
eller når har gått gjennom hele samlingen (Gokstad Akademiet, ingen dato A). Det betyr at i beste fall,
så blir den ferdig veldig tidlig, ved f.eks, tom liste, kort liste eller at den treffer verdien tidlig i listen.
I verste fall så går den gjennom en veldig lang liste og må dermed utføre flere handlinger.

### 2.2 Binærsøk
I binærsøk er vi avhengige av at arrayet er sortert. Dette er fordi den hele tiden prøver å peile seg
inn på verdien basert på de grenseverdiene man har satt. Dersom dataene ikke er sorterte vil denne peilingen
bli helt feil og man kan ikke gjennomføre et gyldig søk, fordi data som potensielt skulle vært søkt blir valgt bort.

I binærsøk så sammenligner man alltid den midterste verdien med målverdien. Hvis målverdien er større eller mindre enn
'mid', forkaster man den delen hvor måleverdien umulig kan være. I min implementasjon har jeg gjort det slik at når
man treffer måleverdien med 'mid', lagrer man treffet
og fortsetter søket mot venstre, forutsatt at arrayet er sortert i stigende rekkefølge mot høyre. På den måten
finner man den laveste indexen av verdien om det finnes duplikater. Dette var en del oppgaven.

## 2.3 Hvordan sammenligninger telles
I denne oppgaven har jeg tolket en sammenligning som, når målverdien måles
mot en annen verdi. I linear search så sammenlignes det hver eneste verdi i 
arrayet helt til man treffer målverdien eller søket er ferdig.
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

I BinarySearch så har jeg talt sammenligninger når mid verdien sammenlignes med målverdien.
Den første sammenligningen skjer når man sjekker om mid er = målverdien.
Den andre sjekken kommer etterpå og da sjekkes det om mid er større enn målverdien.

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

### Testresultater

| Algoritme   | Test                                          | Søkeverdi | Forventet indeks | Faktisk indeks | Sammenligninger | Resultat |
| ----------- |-----------------------------------------------| --------: | ---------------: | -------------: | --------------: | -------- |
| Lineært søk | Verdi finnes                                  |         7 |                3 |              3 |               4 | Bestått  |
| Lineært søk | Verdi finnes ikke                             |        42 |               -1 |             -1 |               7 | Bestått  |
| Binærsøk    | Verdi finnes                                  |        13 |                5 |              5 |               3 | Bestått  |
| Binærsøk    | Verdi finnes ikke                             |         4 |               -1 |             -1 |               5 | Bestått  |
| Binærsøk    | Usortert array, verdi ikke funnet             |         5 |               -1 |             -1 |               5 | Bestått  |
| Binærsøk    | Usortert array, verdi funnet ved tilfeldighet |         9 |                5 |              5 |               3 | Bestått  |
| Binærsøk    | Tomt array                                    |         1 |               -1 |             -1 |               0 | Bestått  |
| Binærsøk    | Array med duplikater                          |         7 |                3 |              3 |               4 | Bestått  |
| Binærsøk    | Array med ett element                         |         1 |                0 |              0 |               1 | Bestått  |


### 2.4.3 Binærsøk på usorterte data
I testene hvor binærsøk ble testet på usorterte lister så kan man ikke stole på resultatet. Listen
jeg testet var denne:  [ 8, 3, 11, 7, 2, 9, 5].
Jeg kjørte to forsøk. I det ene forsøket søkte den etter tallet 5, som har index 6. Her fant
algoritmen ikke fram til tallet. Dette er naturligvis fordi den er programmert til å bruke sorterte lister
og styres av tallene den ser. Den gjorde akkurat som den var programmert til, den fant mid på index 3
hvor tallet 7 befinner seg. Og så forkaster den hele høyresiden (hvor tallet 5 ligger) og søker på venstre siden hvor 
måltallet ikke finnes og algoritmen gjør seg ferdig. Indexen med målverdien ble altså forkastet i søket.

Men når jeg søker etter tallet '9' i den samme listen, så finner den faktisk riktig index. Det er fordi den søker på høyre
side etter den treffer mid 7. Når den kalkulerer et nytt midtpunkt så tar den (4 + 6) / 2 og finner index
5, hvor tallet 9 befinner seg. Det betyr at algoritmen var i stand til å finne fram til indeksen, til
tross for at listen var usortert. Dette er likevel bare flaks, så man må ikke tro at denne typen søk egner
seg til usorterte lister.

## 2.5 Tidskompleksitet
### 2.5.1 Lineært søk
Lineært søk har tidskompleksitet med O(n). Det er n tall som bestemmer hvor mange sammenligninger man må
gjøre. I det verste tilfellet, så må man gå gjennom hele listen før man finner eller ikke finner måltallet.

I det beste tilfellet så er O(1), og dette er om man treffer verdien på første sammenligning.

### 2.5.2 Binærsøk
Binærsøk har tidskompleksitet O(log n), fordi den halverer søkeområdet hver runde. Den oppfører seg da
logaritmisk.
I det beste tilfellet så har binærsøk O(1), da treffer den verdien på første sammenligning. Men i min kode
så skal den derimot lete etter duplikater og skal fortsette å søket til venstre etter treff. Min kode har derfor 
fortsatt O(log n), med mindre listen kun inneholder et element.

### 2.6 Sammenligning av de to logaritmene
Binærsøk er mer effektivt enn lineært søk når arrayet er stort fordi søkeområdet halverers for hver runde.
Lineærsøk har tidskompleksitet O(n), som betyr
at antall sammenligninger øker i takt med elementene. Binærsøk har O(log n), fordi søkeoområdet
halveres for hver sammenligning. 

Til gjengjeld krever binærsøk sorterte lister, noe lineærsøk
ikke krever. Lineærsøk trenger heller ikke være mindre effektiv en binærsøk på små lister, her 
presterer de ganske likt. Man kan se at det er få antall sammenligninger som skiller de to algoritmene
i tester på små lister.

# 3.0 Oppgave 2 - egen generisk datastruktur

### 3.1 Custom stakk
I denne oppgaven valgte jeg å lage stakk. Jeg har verken laget stakk, sirklulær kø, lenket liste eller kø før,
så uansett hvilken jeg lagde visste jeg at dette ville bli en lærerik oppgave.

### 3.2 Hvordan datastrukturen fungerer
Stacken fungerer slik at jeg har to felter T[] items og int count. Disse initialiseres av
konstruktøren. Begge feltene er private, slik at de kun kan behandles gjennom 
API-et. T gjør stacken generisk, som betyr at den kan brukes med ulike datatyper, eks. string, 
float, int etc. 
```
    private T[] items;
    private int count;

    public CustomStack()
    {
        items = new T[10];
        count = 0;
```

Jeg har satt en begrensning på 10 items for å kunne teste edgecase på full stack. 
Push(T item) -  setter inn en verdi i den nåværende indeksen og plusser deretter på 1 på count.
Da vil count nå være på èn verdi høyere enn indexen på det siste elementet. Man setter altså inn verdi
'i' index 0 og setter count til 1.

Pop() - reduserer først count med 1, og returnerer items[count], da får du den siste
verdien som ble satt inn i stacken.

Peek() - gjør ingenting med count, men returnerer items[count - 1] slik at man kan se det
siste som har blitt satt inn.

Alle API funksjonene håndterer ugyldige verdier ved å kaste exceptions. 
For eksempel, en push på full stack, pop() på tom stack vil hånderes slik at programmet ikke krasjer.

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
og ikke påvirkes av hvor mange elementer som ligger i stakken. Stakkens størrelse er også konstant.

Det tar for eksempel ikke lengere tid å
sette inn tallet '1000' i stakken enn tallet '1'. Alle operasjonene i dette APIet setter
direkte inn eller returnerer verdier basert på index. Denne indexen får den av count som også
kun gjennomfører en konstant operasjon hver gang, enten legger til eller fjerner 1. Det vil si
at også count++ count--  er O(1)
- Push() - O(1)
- Pop() - O(1)
- Peek() - O(1)

Jeg vil også påpeke at det går an å lage en stakk hvor kapasiteten blir gradvis større, og da vil Push() bli en O(n) 
operasjon, og Pop() fortsatt være en O(1) operasjon(Microsoft, ingen dato A).

### 3.5 Bruksområder
Stakk kan være nyttig mange sammenhenger. Den er nyttig når du trenger midlertidig minne
for informasjon, for eksempel når du vil forkaste informasjonen etter du har mottatt den (Microsoft, ingen
dato A). 

Eksempler på dette er funksjonskall og rekursjon der det siste funksjonskallet må avsluttes før tidligere
kall kan fortsette. Stakk overflyt er et eksempel på når kallstakken flyter over fordi den inneholder for mange
nestede kall(Microsoft, ingen dato B).

Den kan også være nyttig når man skal implementere angre-funksjonaliteter, som når du skriver
i word og skal angre en bokstav, og andre algoritmer der du ofte vil tilbake til tidligere steg.

### 3.6 Refleksjon
Jeg fikk mer erfaring om hvordan man kan styre hva som er synlig for brukeren ved hjelp
av private felter, som kun kan returneres ved hjelp av API-kall. Dette har vi allerede lært
om, men jeg føler at jeg fikk enda mer forståelse. Det var også artig å tenke på at man kan bruke 
Pop() på en liste, og returnere mange verdier uten at de er fysisk er slettet. Du får ikke returnert verdiene 
på nytt, fordi count er redusert, så det eneste du kan gjøre med de indexene som fortsatt lagrer
verdiene er å sette inn nye.

Når man går fra å ikke kjenne til hvordan slike datastrukturer fungerer til å skulle lage en selv
så møter man mange utfordringer. For min del løste jeg dette med å se videoforklaringer og å gå 
gjennom fagstoff på Gokstad sine hjemmesider. Det har vært svært lærerikt, men også vanskelig.


# 4.0 QuickSort()

### 4.1 Valg av algoritme og pivotstrategi
Jeg valgte QuickSort()-algoritmen fordi jeg syntes den virket spennende å implementere. Jeg
har ikke implementert verken MergeSort eller QuickSort før, så valget ble derfor ganske tilfeldig.

### 4.2 Hvordan QuickSort fungerer
QuickSort fungerer slik at den jobber seg gjennom arrayet ved hjelp av en pivot. I min kode er pivot-strategien
at man velger det siste elementet i (del)arrayet som pivot. Deretter går man gjennom alle verdiene i (del)arrayet, 
bortsett fra pivoten, og setter de verdiene som er mindre enn pivoten til venstre. Når arrayet er gjennomgått, 
setter man pivoten på riktig plass, slik at verdiene som er mindre enn pivoten er til venstre, og resten er til høyre.

Deretter kjøres det i gang to nye QuickSort-funksjoner. Disse funksjonene jobber på hver sin side av pivoten. 
Hver av disse sidene deles nok en gang opp helt til delarrayet består av 0 eller 1 element. Da returnerer funksjonene 
uten å gjøre noe mer. Dette sørger for at rekursjonen stopper og forhindrer en uendelig loop.


### 4.3 Sammenligninger og bytter
Jeg holder kontroll på antall sammenligninger og bytter ved å bruke to verdier og en funksjon:

```
    public static int Comparisons { get; private set; }
    public static int Swaps { get; private set; }
    public static void ResetComparisonsAndSwapsCount()
    {
        Comparisons = 0;
        Swaps = 0;
    }
```
Disse ligger inne i partition() og teller antall sammenligninger og bytter som skjer.

Jeg har valgt å telle sammenligninger mellom arr[j] og pivoten. Dette skjer når man går gjennom
alle tallene i arrayet som ikke er pivoten. I koden kan du se at man først setter 'Comparisons++' og etterpå 
sammenligner.
```
        for (int j = low; j <= high - 1; j++)
        {
            Comparisons++;
            if (arr[j] < pivot)
``` 
Når et element i arrayet er mindre enn pivoten så settes så settes det til venstre og man plusser på 'Swaps'. Da har man
gjort et bytte. Dette skjer først flere ganger inne loopen.

```
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                Swaps++;
```

Etter hele arrayet er gjennomgått skjer det enda en swap, og pivoten settes til høyre for de verdiene som er mindre
enn den

```
        int temp2 = arr[i];
        arr[i] = arr[high];
        arr[high] = temp2;
        Swaps++;
        
// location of pivot
    return i;

```
På denne måten kan man se hvor mange sammenligninger og bytter som skjer inne i en quicksort funksjon.

### 4.4 Testresultater (AI hjalp til med å lage tabellen)

| Test                   | Før                                    | Etter                                  | Sammenligninger | Bytter | Resultat    |
| ---------------------- | -------------------------------------- | -------------------------------------- |----------------:|-------:| ----------- |
| Vanlig/usortert array  | `[64, 34, 25, 12, 22, 11, 90]`         | `[11, 12, 22, 25, 34, 64, 90]`         |              19 |     16 | Test passed |
| Allerede sortert array | `[1, 2, 3, 4, 5]`                      | `[1, 2, 3, 4, 5]`                      |              10 |     14 | Test passed |
| Omvendt sortert array  | `[9, 8, 7, 6, 5]`                      | `[5, 6, 7, 8, 9]`                      |              10 |      8 | Test passed |
| Array med duplikater   | `[64, 34, 25, 12, 22, 22, 11, 34, 90]` | `[11, 12, 22, 22, 25, 34, 34, 64, 90]` |              25 |     23 | Test passed |
| Tomt array             | `[]`                                   | `[]`                                   |               0 |      0 | Test passed |
| Array med ett element  | `[1]`                                  | `[1]`                                  |               0 |      0 | Test passed |

Alle testene kontrollerer at resultatet er sortert og at kanttilfellene håndteres korrekt.

### 4.5 Tidskompleksitet
- Beste tilfelle: O(n log n), når pivoten deler arrayet i omtrent like store deler.
- Gjennomsnittlig tilfelle: O(n log n)
- Verste tilfelle: O(n^2) - Ved ubalansert oppdeling, for eksempel når pivoten blir den største eller minste verdien i
arrayet.
- Plasskompleksitet: O(log n) i gjennomsnitt på grunn av rekursjonen, men O(n) i verste tilfelle, når det blir mange
ubalanserte kall.

### 4.6 Betydningen av pivotvalg
I min strategi så velger jeg det siste elementet som pivot. Hvilken verdi dette elementet har kan påvirke ytelsen
og hvor jevnt arrayet blir delt.

Hvis pivoten havner omtrent på midten, vil de nye delarrayene bli ca. like store og man vil få en ganske balansert
rekursjon, hvor begge rekursjonene starter omtrent like mange nye nivåer. Siden jeg alltid velger det siste elementet
som pivot, kan pivotvalget påvirke hvor jevnt arrayet blir delt.
Både det beste og gjennomsnittlige utfallet av ytelse i QuickSort har O(n log n) (Gokstad Akademiet, ingen dato B). I disse
tilfellene får man et logaritmisk antall nivåer, fordi delarrayene blir omtrent halvert for hver gang en ny partition
aktiveres.

Om man er uheldig med pivotvalg, derimot, blir ytelsen svakere. Vi kan for eksempel se i testen med det sorterte
arrayet at det er flere swaps enn det er i det usorterte arrayet. Det kommer av at for hver ny partition blir det
siste elementet valgt som pivot. Når arrayet allerede er sortert, vil pivoten være det største elementet, og nesten
alle elementene vil bli 'satt' på venstre side i partisjoneringen. I verste tilfelle blir partisjoneringen veldig 
ubalansert. Da kan det ene delarrayet inneholde nesten alle elementene,
mens det andre delarrayet nesten er tomt. Dette gjør at man får omtrent 'n' nivåer i rekursjonen i stedet for log2(n),
og tidskompleksiteten blir O(n^2).

### 4.7 Styrker og svakheter
Styrken med quicksort er at den er ganske så effektiv når pivotstrategien passer godt til arrayet.
Da vil du kunne få en tidskompleksitet på O(n log n). En annen styrke er at alt foregår i det samme
arrayet hele tiden. Da slipper man å returnere et nytt array som må lagres.

Svakheten til quicksort er at pivotstrategien også kan føre til O(n^2).
Jeg har også hørt at lange lister med dype rekursjoner kan føre til stackoverflow. StackOverflow er når kjøringsstakken
går tom for plass til nye rekursjoner fordi den inneholder for mange nestede metodekall (Microstoft, ingen dato B).

### 4.8 Refleksjon
Det jeg har lært ved å jobbe med quicksort, er at pivotstrategien har enormt mye å si for utfallet av ytelsen. Når det
siste elementet velges som pivot så kan for eksempel sorterte arrays føre til en ubalansert oppdeling.

Jeg lærte også mer om hvordan rekursjon fungerer. De rekursjonsfunksjonene jeg har vært borte i før har alltid returnert
et nytt array, så det var gøy å se hvordan man kan jobbe rekursivt i det samme arrayet.

# 5.0 Breadth First Search

## 5.1 Forklaring av Graph
For å lage grafen som brukes i Breadth First Search og Depth First Search
så har jeg brukt en 'adjacency list'. Det består av en dictionary med nøkkel/key og verdier/value.
Hvor nøkkelene består av stasjonene og verdiene er nabostasjonene. For eksempel, hvis Majorstuen
har to naboer, NationalTheateret og Blindern, vil nøkkelen være ["Majorstuen"] og verdiene være ["Nationaltheateret", 
"Blindern"].
Når Nationaltheateret er nøkkelen vil den ha ["Majorstuen", "Stortinget"] som sine verdier. Og sånn dannes kantene mellom
stasjonene. Verdiene er også satt om som HashSet<string> som gjør at man sikrer at man hindrer duplikatstasjoner i
verdilista. HashSet har også gjennomsnittlig ytelse O[1] for Contains() og Add(), noe som gjør den raksk når jeg skal
sjekke om en stasjon finnes eller skal legge til en ny nabo.

For å lage stasjoner, så bruker man 'AddStation()'. Her sjekkes det først om grafen allerede inneholder 
stasjonen, og hvis den ikke gjør det, så oppretter den en et nytt element.
```
    public void AddStation(string station)
    {
        if (!graph.ContainsKey(station))
        {
            graph[station] = new HashSet<string>();
        }
    }

```

For å lage en knytning mellom to stasjoner så bruker man AddConnection(). Denne metoden
sjekker først om stasjonene eksisterer som nøkler. Hvis de ikke eksisterer, så opprettes de, og når
denne sjekken passeres så legges de inn som verdier hos hverandre.

```
        graph[stationA].Add(stationB);
        graph[stationB].Add(stationA);
```

GetNeighbors() - lar oss see hvilke naboer en stasjon har.

ContainsStation() - lar oss sjekke om grafen inneholder den stasjonen vi er 
ute etter ved hjelp av kodelinja under.

```
return graph.ContainsKey(station);
```

IsEmpty() - Sjekker om grafen er tom.


## 5.2 Breadth First Search
Breadth First Search er en algoritme som fungerer slik at den går gjennom grafen horisontalt. 

Man går gjennom hver node og legger til naboene i køen som skal sjekkes. Når da en nabo sjekkes så legger man også til
dens naboer i køen. I en kø (queue), så opererer man etter 'first in first out' (FIFO) prinsippet. Det gjør at man sjekker
elementene i den rekkefølgen de ble lagt inn i. Når køen er tom så er stopper søket. 

Man kan for eksempel se på 'majorstuen', som er nabo med både 
'Nationaltheateret' og 'Blindern'. Via disse så går stasjonene ut i to ulike grener, og man kan se at begge disse naboene,
som er 1 stasjon unna, sjekkes først. Deretter går man løs på naboenes nabo, som er 2 stasjoner unna 'majorstuen'.
På denne måten sjekkes hvert eneste 'nivå' slik at man har gått gjennom alle stasjonene som har kobling til 'majorstuen'.

For å unngå å gjennomgå samme stasjon flere ganger så lagrer metodene de besøkte stasjonene i en HashSet verdi 'visited.
HashSet har den egenskapen at man ikke kan lagre like duplikater. Så hver gang man skal sjekke en nabo i køen så sjekkes
det om den allerede finnes i den HashSeth visited. Da besøkes hver stasjon som er koblet til stasjonA kun en gang.

## 5.3 ShortestDistance - Korteste vei
I ShortestDistance() så kan man finne ut hva som er færrest mulig antall kanter mellom stasjonA og stasjonB.
Den fungerer ganske likt som Breadth First Search, men her sjekkes stasjonene i køen mot stasjonB for å se om man
har kommet frem. Hvis man har kommet frem så returneres distansen med 'distance[current]'. Dersom grafen går gjennom
hele køen uten å finne stasjonB så returneres '-1', med en melding om at det ikke finnes en rute mellom stasjonene. 

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

## 5.5 Plass og tidskompleksitet
BFS har tidskompleksitet O(V + E). V er antall noder og E er antall kanter.

O(V+E) forklares ved at hver stasjon (V) bare besøkes maks en gang, og at hver kant/naboforbindelse E undersøkes når vi går 
gjennom naboene.

BFS har en plasskompleksitet: O(V), fordi BFS i aller verste konsekvens må lagre et veldig langt nivå i 
køen samtidig (Gokstad Akakademiet, ingen dato C) . La oss si at 'majorstuen' ikke er koblet til bare to naboer, men for eksempel 1000. Da må
alle de naboene ligge i køen samtidig.


# 6.0 Depth First Search
Depth First Search er en søkemetode, som i motsetning til BFS, går i dybden i hvert søk. I forklaringen av BFS
så nevnte jeg at om man tar utgangspunkt i 'majorstuen' stasjonen, så vil den besøke begge naboene før den går videre til
naboenes nabo. I DFS så går man rett fra utgangspunkt -> nabo -> nabos nabo -> etc. På den måten så går søket ut til
en ende før den backtracker. Deretter vil eventuelle andre grener på veien bli undersøkt. Den fullfører alltid
en gren før den går tilbake til et tidligere forgreiningspunkt.

## 6.1 Recursive Depth First Search
I min rekursive metode, så fungerer det som følger: Jeg har først en wrappermetode som sjekker
om grafen er tom og at grafen inneholder stasjonen man søker ut fra.
```
public static void RecursiveDFSearch(Graph graph, string station)
```

Det er denne metoden man bruker når man skal kalle på den rekursive metoden.
Deretter opprettes det et HashSet som holder kontroll på hvilke stasjoner som er besøkt, som igjen brukes i 
den rekursive metoden.

```
    private static void RecursiveDFSearch(Graph graph, string station, HashSet<string> visited)
```

Det første som skjer i denne metoden er at man kontrollerer 'visited'.

```
        if (visited.Contains(station))
        {
            return;
        }
```

Hvis stasjonen allerede finnes i 'visited' så returnerer metoden. På denne måten unngår vi en loop hvor 
naboer aktiverer hverandre i det uendelige. Dette er også særlig relevant når det finnes sykler i grafen.

Deretter setter man til stasjonen som 'besøkt'.

```
  visited.Add(station);
```

Nå er stasjonen lagt inn i 'visited', og neste gang den eventuelt blir sendt med den rekursive funksjonen
```
RecursiveDFSearch(graph, neighbor, visited)
```
så vet vi at den vil returnere og stanse.


Til slutt så sjekkes alle naboene til stasjonen, og alle naboene blir sendt ut med hver sin 
rekursive metode.

```
        foreach (string neighbor in graph.GetNeighbors(station))
        {
            // here the new search will begin at each neighbor
            RecursiveDFSearch(graph, neighbor, visited);
        }
```



## 6.2 Iterative Depth First Search
I den iterative metoden så fungerer det litt annerledes.
Her tar man inn grafen og stasjonen som verdier,
og det opprettes en tom Stack og et HashSet
```
public static void IterativeDFSearch(Graph graph,  string station)
{
        Stack<string> stack = new Stack<string>();
        HashSet<string> visited = new HashSet<string>();
```
Stacken holder stasjonene som skal besøkes, og HashSet brukes, i likhet med den 
rekursive metoden, til å se hvilke stasjoner som har blitt besøkt. 

Deretter er gjennomføres det kontroller som sjekker om grafen er tom. Den sjekker også om den inneholder stasjonen man
søker ut fra.

Det første som skjer etter det, er at stasjonen legges inn i stakken med 'stack.Push(station);'. Da har vi
et element i stakken, og dette elementet skal behandles i en 'while-loop', som går så lenge 'stack.Count > 0'.

Deretter henter man ut stasjonen av stakken med stack.Pop().

```
            string currentStation = stack.Pop();
```

Hvis 'currentStation' stasjonen du har hentet ut ikke allerede ligger i 'HashSet visited', så legger man den inn i 'visited',
og skriver ut at den er besøkt.

Og så, for hver nabo av 'currenstation', som ikke er besøkt, så legger man de til i stakken. Deretter begynner man 
i 'while-loopen' igjen og tar ut det øverste elementet i stakken. På denne måten så vil stakken fylles på, så lenge det
kommer nye naboer. Disse naboene vil havne øverst stakken og den sist innlagte av naboene vil bli behandlet først. På den
måten så kommer man lengere og lengere ut i forgreiningene helt til man når enden. Da går while loopen løs på det neste
øverste elementet i stakken. Når alle er passert og er registert i visited vil stakken være tom og metoden er ferdig.


## 6.3 RouteExists
Jeg har valgt ruteteliknykting som utvidelse for depth first search.
RouteExists tar inn grafen, stasjonA og stasjonB og kjører et iterativt depth first search.

Den bruker også visited for å unngå samme stasjon flere ganger, og når den treffer stasjonB
så vil metoden returnerer true og hele søket er ferdig.

Metoden sjekker om det finnes en rute mellom to stasjoner, men sier ikke noe avstand
eller andre ting. I BFS så vet man at det ikke finnes noen færre antall stopp fordi man har søkt nivå for nivå. 
Mens i DFS så vil den stoppe med en gang den har fulgt en forgreining som treffer. Det kan hende det finnes andre
forgreininger som er både kortere og lengere til det punktet.

## 6.4 Testing (AI help with making the table)
| Test                                     | Hva testes                              | Forventet resultat         | Resultat |
|:-----------------------------------------|:----------------------------------------|:---------------------------|:---------|
| Rekursiv DFS fra Majorstuen              | Besøker alle nåbare stasjoner           | 9 stasjoner besøkt         | Bestått  |
| Iterativ DFS fra Majorstuen              | Besøker alle nåbare stasjoner med Stack | 9 stasjoner besøkt         | Bestått  |
| DFS fra isolert Sognsvann                | Håndtering av isolert stasjon           | Kun Sognsvann besøkes      | Bestått  |
| Iterativ DFS fra isolert Sognsvann       | Håndtering av isolert stasjon           | Kun Sognsvann besøkes      | Bestått  |
| RouteExists Majorstuen → Ullevål Stadion | Sjekker om det finnes en rute           | `true`                     | Bestått  |
| RouteExists Majorstuen → Sognsvann       | Sjekker rute til isolert stasjon        | `false`                    | Bestått  |
| Ukjent startstasjon – rekursiv DFS       | Håndtering av stasjon som ikke finnes   | Feilmelding, ingen krasj   | Bestått  |
| Ukjent startstasjon – iterativ DFS       | Håndtering av stasjon som ikke finnes   | Feilmelding, ingen krasj   | Bestått  |

## 6.5 DFS og BFS
Begge DFS-metodene besøker de samme stasjonene, men rekkefølgen blir forskjellig. Den iterative metoden bruker en Stack,
som følger LIFO-prinsippet. Når flere naboer legges på stacken, blir den siste naboen som ble lagt inn behandlet først.
Dette gjør at den iterative DFS-en og den rekursive DFS-en kan begynne på ulike grener. Rekkefølgen på naboene
påvirker derfor besøksrekkefølgen.

BFS bruker Queue og vil gjennomføre sjekkene i tur og orden, altså nivå for nivå. Først en kant unna og deretter to
kanter unna.

BFS og DFS har ulike bruksområder. Jeg vil tro at BFS vil passe godt til å undersøke grafer når avstand er viktig,
som for eksempel om du skal ta t-banen og vil kjøre forbi færrest antal stasjoner.
DFS kan passe godt når du bare skal verifisere at det finnes en
kobling mellom to punkter, som for eksempel i RouteExists() når jeg kun skulle sjekke om det var en forbindelse og 
ikke noe mer. 

## 6.5 Tidskompleksitet
BFS har en tidskompleksistet på O(V + E), hvor V er antall noder og E er antall kanter. Det har en plasskompleksitet
på O(V), fordi BFS i verste fall må lagre hele nivået i køen samtidig (Gokstad Akademiet, ingen dato C).
Som i eksempelelet jeg illustrerte med 1000 nabostasjoner for majorstuen.
Når DFS brukes på en naboliste så bruker traverseringen O(V + E) og optil O(V) plasskompleksitet (Gokstad Akademiet,
n.d.c) . De har samme tidskompleksitet og samme verste utfall.

Noe som er annerledes er at rekursiv DFS bruker programmets kallstakk, og man kan i likhet med det jeg nevnte i om
rekursiv quicksort få stackoverflow. 
Den iterative metoden derimot, bruker en vanlig Stack<string> og unngår denne typen rekursiv stackoverflow.


# Learning materials:
Videos -
Bro Code "Learn Quick Sort in 13 minutes" -https://www.youtube.com/watch?v=Vtckgz38QHs
Michael Sambol "Quick sort in 4 minutes" - https://www.youtube.com/watch?v=Hoixgm4-P4M
Michael Sambol "Breadth-first search in 4 minutes - https://www.youtube.com/watch?v=HZ5YTanv5QE
tutorialsEUC "How to use queues in C#" - https://www.youtube.com/watch?v=4MQwKvsGCms

# Sources:
- AlgorithmsNotesForProfessionals  - pdf
- Breadth First Search or BFS for a Graph - https://www.geeksforgeeks.org/dsa/breadth-first-search-or-bfs-for-a-graph/
- Depth First Search or DFS for a Graph - https://www.geeksforgeeks.org/dsa/depth-first-search-or-dfs-for-a-graph/
- Gokstad Akademiet. (ingen dato A) Teori: lineært og binært søk. Økt 1 - Uke 34 - https://lms.gokstadakademiet.no/mod/scorm/player.php?a=14&currentorg=ORG_1&scoid=110
- Gokstad Akademiet. (ingen dato B) Teori: sortering og ytelse. Økt 2 - Uke 35 - https://lms.gokstadakademiet.no/mod/scorm/player.php?a=15&currentorg=ORG_1&scoid=119
- Gokstad Akademiet. (ingen dato C) 03-teori. Økt 3 - Uke 36 - https://lms.gokstadakademiet.no/mod/scorm/player.php?a=18&currentorg=ORG_1&scoid=144
- Gokstad Akademiet. (n.d.c) Teori: Depth-First Search - Uke 36 - https://lms.gokstadakademiet.no/mod/scorm/player.php?a=19&currentorg=ORG_1&scoid=152
- Implementing Depth First Search into C# using List and Stack - https://stackoverflow.com/questions/5804844/implementing-depth-first-search-into-c-sharp-using-list-and-stack
- Microsoft. (ingen dato A). Stack<T> class. Microsoft Learn - https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-10.0#remarks
- Microsoft. (ingen dato B). Debug StackOverflow errors. Microsoft Learn - https://learn.microsoft.com/en-us/dotnet/core/diagnostics/debug-stackoverflow?tabs=linux