# Arbeidskrav 1, HØST 2026, Backend Programmering
- Student: Jakob Sørli
- Date: 04 - 25th September


## Table of contents
 - Introduction
 - Analyse (oppgave 1)



# Søkealgoritmer – Lineært søk og binærsøk

## 1. Formål
I denne oppgaven har jeg implementert LinearSearch, og BinarySearch.
jeg har kjørt en rekke tester og svart på spørsmål i oppgaven.

## 2. Implementasjon

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

## 3. Hvordan sammenligninger telles
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

## 4. Testresultater

### 4.1 Lineært søk – testdata
<!-- Test på [8, 3, 11, 7, 2, 9, 5]. -->

| Målverdi  | Forventet indeks  | Faktisk indeks | Antall sammenligninger |
|:----------|:------------------|:---------------|:-----------------------|
| 7         | 3                 | 3              | 4                      |
| 42        | -1                | -1             | 7                      |


### 4.2 Binærsøk – testdata
<!-- Test på [2, 5, 7, 9, 11, 13, 17]. -->

| Målverdi  | Forventet indeks | Faktisk indeks | Antall sammenligninger |
|:----------|:-----------------|:---------------|:-----------------------|
| 13        | 5                | 5              | 3                      |
| 4         | -1               | -1             | 5                      |


### 4.3 Binærsøk på usorterte data
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


## 5. Tidskompleksitet
// TODO!

### 5.1 Lineært søk
<!-- Beste tilfelle: -->
<!-- Verste tilfelle: -->
<!-- Big-O: -->


### 5.2 Binærsøk
<!-- Beste tilfelle: -->
<!-- Verste tilfelle: -->
<!-- Big-O: -->

### 6. Sammenligning av de to logaritmene



# Oppgave 2 - egen generisk datastruktur





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
