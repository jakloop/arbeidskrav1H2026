
# AI statement
AI bruk som er tillat på gokstad er følgende: Man kan bruke AI som støtte til læring,
ideutvikling, strukturering og problemløsing.

I denne oppgaven har jeg brukt AI til følgende.
- Spørsmål om struktur på oppgaven
- Spørsmål for å kunne forstå konsepter rundt datastrukturer og algoritmer.
- Veiledning, ideutvikling og hjelp til å løse problemer.
- Noe språkvask og tilbakemelding på tekster.
- Forklaring av konsepter og kode jeg ikke forstår.

Jeg har også gjort mitt ytterste for å prøve å finne andre kilder før jeg velger
å bruke AI assistanse, eksempelvis, videoer på YouTube, pensum og digitale læreverk.
Likevel, er det svært nyttig å bruke AI som diskusjonpartner nå du trenger hjelp til
å forstå. I de tilfellene hvor AI har hjulpet meg med å løse kodeproblemer har jeg kommentert
det i koden, og lagt det inn i dette dokumentet. Det gjelder også hjelp med struktur og generering av tabeller
hvor jeg har gitt AI verdiene de skal fylle inn.
Jeg har ikke lagt inn lengre diskusjoner og spørsmål for å hjelp med forståelse.

# Contents
- 1. Structure help
- 2. Help with finding the lowest instance in a sorted array
- 3. getting access to neighboring stations
- 4. check if the stations exist in the graph
- 5. Help with structuring the analysis part of all tasks
- 6. Help with changing from xunit testing to printable tests
- 7. checking if lists are equal
- 8. Help with making a test result table 
- 9. Help with making table for tests in BFS
- 10. Help with making test table
- 11. help with test result table in linear and binary search


## 1. Guidance with project structure:


(Gemini, 5. September)
Input: How would you go about the structure in this assignment?

Output:
Repository & Project structure
```
BackendAssignment/
├── BackendAssignment.sln
├── src/
│   ├── Assignment.App/                      # Console interface / runner
│   │   ├── Program.cs
│   │   └── Assignment.App.csproj
│   └── Assignment.Core/                     # Core logic, data structures, & algorithms
│       ├── Task1_Searching/
│       │   └── SearchAlgorithms.cs
│       ├── Task2_DataStructures/
│       │   └── CustomQueue.cs               # Or CustomStack, LinkList, etc.
│       ├── Task3_Sorting/
│       │   └── QuickSortImplementation.cs  # Or MergeSortImplementation.cs
│       ├── Task4_Graphs/
│       │   ├── Graph.cs
│       │   └── BreadthFirstSearch.cs
│       └── Task5_DFS/
│           ├── DepthFirstSearchRecursive.cs
│           └── DepthFirstSearchIterative.cs
├── tests/
│   └── Assignment.Tests/                    # Unit tests for all tasks
│       ├── Task1Tests.cs
│       ├── Task2Tests.cs
│       ├── Task3Tests.cs
│       ├── Task4Tests.cs
│       └── Task5Tests.cs
├── README.md                                # Build instructions, analyses, reflections
└── AI_DOCUMENTATION.md                      # AI prompt logs (or included in README)
```

## 2. Help with finding the lowest instance in a sorted list (ChatGPT)
Here I tried to find the lowest instance in a sorted list.
The help made me use "return result", letting the code narrow down to
the leftmost instance of a value instead of returning the first one.

input:
if (array[mid] == value) { while (array[mid] == value ?? array[mid - 1] == value) { mid -= 1; } return mid; }
I'm struggling with this code
I need it to find the lowest instance of a value if there are duplicates. give me a hint please


Used output:
Save mid as the current best answer.
Move right to mid - 1.
Let the binary search continue.
So you'll need another variable, something like:
int result = -1;
Then conceptually:
if (array[mid] == value)
{
result = mid;      // "This is a match, for now"
right = mid - 1;   // "But let's see if there's one further left"
}

## 3 Giving access to neighbors in graphs
input: Input code of BFS with issues on this line. Tried to use indexing on HashSet...

foreach (string linkingStation in graph[current])

output:

You're actually very close. The BFS logic itself is basically correct. The main issue is this line:
foreach (string linkingStation in graph[current]) : 
Give Graph a way to access neighbors
   For example, inside your Graph class:
   public HashSet<string> GetNeighbors(string station)
   {
   return graph[station];
   }

## 4: Check if one of the stations do not exist in the HashSet/graph

Input: I need to check if the stations exist before running the method. how can I do that?

output:
In your Graph class, add:
public bool ContainsStation(string station)
{
return graph.ContainsKey(station);
}

## 5: Help with structure and headers in README analysis:

Input: I need help with structuring my analysis in the README. Please help me create headers I can fill in this task
*filled in task 1. Repeated this for all the tasks

Output: (this an example of one of the outputs, but this was done on all the tasks
before I started writing the analysis
````
# Søkealgoritmer – Lineært søk og binærsøk

## 1. Formål
<!-- Kort beskrivelse av hva oppgaven undersøker og hva du har implementert. -->


## 2. Implementasjon

### 2.1 Lineært søk
<!-- Forklar kort hvordan LinearSearch fungerer. -->
<!-- Legg gjerne inn eller lenk til relevant kode. -->


### 2.2 Binærsøk
<!-- Forklar kort hvordan BinarySearch fungerer. -->
<!-- Beskriv hvordan nedre grense, øvre grense og midtpunkt brukes. -->
<!-- Forklar også hvordan du finner første forekomst ved duplikater. -->


## 3. Hvordan sammenligninger telles
<!-- Definer nøyaktig hva du teller som én sammenligning. -->
<!-- Forklar at samme definisjon brukes for begge algoritmene. -->


## 4. Testresultater

### 4.1 Lineært søk – testdata
<!-- Test på [8, 3, 11, 7, 2, 9, 5]. -->

| Målverdi | Forventet indeks | Faktisk indeks | Antall sammenligninger |
|----------|------------------|----------------|------------------------|
| 7        |                  |                |                        |
| 42       |                  |                |                        |


### 4.2 Binærsøk – testdata
<!-- Test på [2, 5, 7, 9, 11, 13, 17]. -->

| Målverdi | Forventet indeks | Faktisk indeks | Antall sammenligninger |
|----------|------------------|----------------|------------------------|
| 13       |                  |                |                        |
| 4        |                  |                |                        |


### 4.3 Binærsøk på usorterte data
<!-- Beskriv testen med usortert array. -->
<!-- Hva returnerte algoritmen? Hvorfor kan resultatet ikke stoles på? -->


### 4.4 Kanttilfeller

#### Tomt array
<!-- Resultat og forklaring. -->

#### Array med ett element
<!-- Test både treff og ikke-treff. -->

#### Målverdi utenfor området
<!-- Test en verdi mindre enn minste og/eller større enn største verdi. -->

#### Duplikater
<!-- Vis at første/laveste indeks returneres. -->


## 5. Tidskompleksitet

### 5.1 Lineært søk
<!-- Beste tilfelle: -->
<!-- Verste tilfelle: -->
<!-- Big-O: -->


### 5.2 Binærsøk
<!-- Beste tilfelle: -->
<!-- Verste tilfelle: -->
<!-- Big-O: -->


### 5.3 Sammenligning av algoritmene
<!-- Forklar forskjellen i effektivitet basert på testresultatene. -->


## 6. Hvorfor må binærsøk ha sorterte data?
<!-- Forklar hvorfor algoritmen er avhengig av at dataene er sortert. -->
<!-- Forklar hva som kan gå galt på usorterte data. -->


## 7. Kostnaden ved sortering
<!-- Diskuter når det kan lønne seg å sortere data før man bruker binærsøk. -->
<!-- Tenk på hvor ofte dataene skal søkes i og hvor store datasett man har. -->


## 8. Analyse og refleksjon
<!-- Hva viser resultatene dine? -->
<!-- Hvordan stemmer resultatene med Big-O-analysen? -->
<!-- Hvilke forutsetninger har de to algoritmene? -->
<!-- Hva har du lært om effektivitet og algoritmevalg? -->


## 9. Konklusjon
<!-- Oppsummer kort forskjellen mellom lineært søk og binærsøk. -->
<!-- Oppsummer hva testene og sammenligningene viste. -->
````

## 6

How can i do these tests in a printable.cs testfile, the same way i did the first tests
```
   [Fact]
    public void CustomStack_PeekShowsLatestPushedValue()
    {
        //arrange 
        CustomStack<int> stack = new CustomStack<int>();
        stack.Push(10);
        stack.Push(20);
        // act
        int result = stack.Peek();
        // assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void CustomStack_PopReturnsTheLastValue()
    {
        // arrange
        CustomStack<string> stack = new CustomStack<string>();
        stack.Push("Some");
        stack.Push("Body");
        stack.Push("Once");
        stack.Push("Told");
        stack.Push("Me");
        // act
        string result = stack.Pop();
        // assert
        Assert.Equal("Me", result);
    }
    
    [Fact]
    public void CustomStack_ThrowsErrorWhenStackIsFull()
    {
        // arrange
        CustomStack<string> stack = new CustomStack<string>();
        for (int i = 0; i < 10; i++)
        {
            stack.Push("Hello");
        }
        Assert.Throws<IndexOutOfRangeException>(() => stack.Push("Goodbye"));
    }

    [Fact]
    public void CustomStack_PopOnEmptyStack()
    {
        // arrange
        CustomStack<string> stack = new CustomStack<string>();
        // assert
        Assert.Throws<IndexOutOfRangeException>(() => stack.Pop());
    }
```

- output:
  Yes. What you have now is basically the manual version of those xUnit tests. 
   You can translate each test into a section inside Run().
  The pattern is:
  Arrange → create/setup the stack
  Act     → call Push/Pop/Peek
  Assert  → use your TestCheck class
  For the tests involving exceptions, you can use try/catch instead of Assert.Throws.


## 7 checking if lists are equal

input (in the context of having discussed ways to compare equal lists):
```
how can I compare lists to see if they are equal or not?

```
output:
```
For List<T>, the simplest way to compare whether they contain the same elements in the same order is SequenceEqual():`

using System.Linq;

List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = new List<int> { 1, 2, 3 };

if (list1.SequenceEqual(list2))
{
    Console.WriteLine("The lists are equal");
}
else
{
    Console.WriteLine("The lists are different");
}
```

## 8. Help with making test result table 

input:
```
kan du gjøre om dette til en md tabell som passer til dette
========== Task 3: Quick Sort ==========
Normal array
Before:
64, 34, 25, 12, 22, 11, 90
After
11, 12, 22, 25, 34, 64, 90
Test passed
Comparisons: 19
Swaps: 16
Sorted array
Before:
1, 2, 3, 4, 5
After
1, 2, 3, 4, 5
Test passed
Comparisons: 10
Swaps: 14
Reverse sorted array
Before:
9, 8, 7, 6, 5
After
5, 6, 7, 8, 9
Test passed
Comparisons: 10
Swaps: 8
Array with duplicates
Before:
64, 34, 25, 12, 22, 22, 11, 34, 90
After
11, 12, 22, 22, 25, 34, 34, 64, 90
Test passed
Comparisons: 25
Swaps: 23
Empty array
Before:
After
Test passed
Comparisons: 0
Swaps: 0
Array with one element
Before:
1
After
1
Test passed
Comparisons: 0
Swaps: 0
### 4. Testresultater
Jeg testet algoritmen med:
- Vanlig/usortert array
- Allerede sortert array
- Omvendt sortert array
- Array med duplikater
- Tomt array
- Array med ett element

```

Output:
```
### 4. Testresultater

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

```

## 9. Help with making table for tests in BFS

input:
```
Kan du hjelpe meg å gjøre om disse testene til en tabell
========== Task 4: Breadth First Search ==========
Documentation: Order of visits
Nåværende stopp: Majorstuen, antall stopp: 0
La til Nationaltheateret i besøkt. Besøk nr: 1
La til Blindern i besøkt. Besøk nr: 2
Nåværende stopp: Nationaltheateret, antall stopp: 1
La til Stortinget i besøkt. Besøk nr: 3
Nåværende stopp: Blindern, antall stopp: 1
La til Forskningsparken i besøkt. Besøk nr: 4
Nåværende stopp: Stortinget, antall stopp: 2
La til Jernbanetorget i besøkt. Besøk nr: 5
Nåværende stopp: Forskningsparken, antall stopp: 2
La til Ullevål Stadion i besøkt. Besøk nr: 6
Nåværende stopp: Jernbanetorget, antall stopp: 3
La til Grønland i besøkt. Besøk nr: 7
Nåværende stopp: Ullevål Stadion, antall stopp: 3
Nåværende stopp: Grønland, antall stopp: 4
La til Tøyen i besøkt. Besøk nr: 8
Nåværende stopp: Tøyen, antall stopp: 5
9
Shortest amount of stops from Majorstuen to Grønland
Endestasjon funnet, antall stopp: 4
Expected value: 4, result: 4
Test passed
Shortest amount of stops from Tøyen to Ullevål Stadion
Endestasjon funnet, antall stopp: 8
Expected value: 8, result: 8
Test passed
BFS from isolated station, only one node visited
Nåværende stopp: Sognsvann, antall stopp: 0
Expected value: 1, result: 1
Test passed
BFS from isolated station, only one node visited
No route found from Sognsvann to Tøyen
Expected value: −1, result: −1
Test passed
Unknown departure station
One of the stations was not found.
Expected value: −1, result: −1
Test passed
Unknown destination
One of the stations was not found.
Expected value: −1, result: −1
Test passed
Empty graph traversal, handeled without crash
The graph is empty
Expected value: −1, result: −1
Test passed

TestCheck testcheck = new TestCheck(); // BSF from majorstuen // Shortest distance from majorstuen -> grønland korteste
 avstand = 4 // ullevål -> tøyen rute mellom grenene // BFS fra isolert stasjon - bare en node besøkes // Isolert -> 
 tøyen ingen rute = -1 // ukjent start hånderes uten krasj // ukjent mål hånderes uten krasj // tom graf håndteres uten
  krasj Console.WriteLine("========== Task 4: Breadth First Search =========="); // BSF from majorstuen 
  Console.WriteLine("Documentation: Order of visits"); var graph = new Graph(); graph.AddConnection("Majorstuen",
   "Nationaltheateret"); graph.AddConnection("Nationaltheateret", "Stortinget"); graph.AddConnection("Stortinget",
    "Jernbanetorget"); graph.AddConnection("Jernbanetorget", "Grønland"); graph.AddConnection("Grønland" , "Tøyen");
     graph.AddConnection("Majorstuen", "Blindern"); graph.AddConnection("Blindern", "Forskningsparken"); 
     graph.AddConnection("Forskningsparken", "Ullevål Stadion"); int normalTraversal = BFSearch.BFS(graph, 
     "Majorstuen"); Console.WriteLine(normalTraversal); Console.WriteLine(" "); // Shortest distance from majorstuen 
     -> grønland korteste avstand = 4 Console.WriteLine(" Shortest amount of stops from Majorstuen to Grønland"); 
     int shortestDistanceM2G = BFSearch.ShortestDistance(graph, "Majorstuen", "Grønland"); 
     Console.WriteLine($"{TestCheck.Check(4, shortestDistanceM2G)}"); Console.WriteLine(" "); // ullevål -> 
     tøyen rute mellom grenene Console.WriteLine("Shortest amount of stops from Tøyen to Ullevål Stadion"); int route
     BetweenBranches = BFSearch.ShortestDistance(graph, "Tøyen", "Ullevål Stadion"); Console.WriteLine($"{T
     estCheck.Check(8, routeBetweenBranches)}"); Console.WriteLine(" "); // BFS fra isolert stasjon - bare en node 
     besøkes Console.WriteLine("BFS from isolated station, only one node visited"); var graphWithIsolatedStation = 
     new Graph(); graphWithIsolatedStation.AddConnection("Majorstuen", "Nationaltheateret"); graphWithIsolatedStatio
     n.AddConnection("Nationaltheateret", "Stortinget"); graphWithIsolatedStation.AddConnection("Stortinget", "Jernb
     anetorget"); graphWithIsolatedStation.AddConnection("Jernbanetorget", "Grønland"); graphWithIsolatedStation.AddC
     onnection("Grønland" , "Tøyen"); graphWithIsolatedStation.AddConnection("Majorstuen", "Blindern"); 
     .AddConnection("Blindern", "Forskningsparken"); graphWithIsolatedStation.AddConnection("Forskningsparken", "Ulle
     vål Stadion"); graphWithIsolatedStation.AddStation("Sognsvann"); int lonelyNode = BFSearch.BFS(
     , "Sognsvann"); Console.WriteLine($"{TestCheck.Check(1, lonelyNode)}"); Console.WriteLine(" "); // Isolert -> tø
     yen ingen rute = -1 Console.WriteLine("BFS from isolated station, only one node visited"); int lonelyNode2 = BFS
     earch.ShortestDistance(graphWithIsolatedStation, "Sognsvann", "Tøyen"); Console.WriteLine($"{TestCheck.Check(-1,
      lonelyNode2)}"); Console.WriteLine(" "); // var graph = new Graph(); // ukjent start hånderes uten krasj Consol
      e.WriteLine("Unknown departure station"); int unknownStart = BFSearch.ShortestDistance(graph, "Sesam Stasjon", 
      "Grønland"); Console.WriteLine($"{TestCheck.Check(-1, unknownStart)}"); Console.WriteLine(" "); // ukjent mål h
      ånderes uten krasj Console.WriteLine("Unknown destination"); int unknownEnd = BFSearch.ShortestDistance(graph, 
      "Majorstuen", "Sesam Stasjon"); Console.WriteLine($"{TestCheck.Check(-1, unknownEnd)}"); Console.WriteLine(" 
      // tom graf håndteres uten krasj Console.WriteLine("Empty graph traversal, handeled without crash"); var empty
      Graph = new Graph(); int emptyGraphTraversal = BFSearch.BFS(emptyGraph, "Majorstuen"); Console.WriteLine($"{
      .Check(-1, emptyGraphTraversal)}"); Console.WriteLine(" ");
```

output:
```
### Testing

| Test                    | Hva testes                                      | Forventet resultat | Resultat |
| ----------------------- | ----------------------------------------------- | -----------------: | -------: |
| BFS fra Majorstuen      | Besøksrekkefølgen gjennom alle nåbare stasjoner | 9 stasjoner besøkt |  Bestått |
| Majorstuen → Grønland   | Korteste antall stopp                           |                  4 |  Bestått |
| Tøyen → Ullevål Stadion | Korteste rute mellom de to grenene              |                  8 |  Bestått |
| BFS fra isolert stasjon | Kun den isolerte stasjonen skal besøkes         |   1 stasjon besøkt |  Bestått |
| Sognsvann → Tøyen       | Ingen rute mellom isolert stasjon og Tøyen      |                 -1 |  Bestått |
| Ukjent startstasjon     | Håndtering av stasjon som ikke finnes           |                 -1 |  Bestått |
| Ukjent mål              | Håndtering av mål som ikke finnes               |                 -1 |  Bestått |
| Tom graf                | Håndtering av tom graf uten krasj               |                 -1 |  Bestått |

BFS fra `Majorstuen` besøkte stasjonene i følgende rekkefølge:

`Majorstuen → Nationaltheateret → Blindern → Stortinget → Forskningsparken → Jernbanetorget → Ullevål Stadion → Grønland → Tøyen`

Alle testene ga forventet resultat.

```

## 10. Help with making test table

input:
```
Hjelp meg å implementere en tabell som passer til dette i testene
namespace arbeidskrav1H2026.searchalgorithms;

public class DFSearchTests
{

    public void Run()
    {
        
        Console.WriteLine("========== Task 5: Depth First Search ===========");
        
        
        // Recursive DFS from majorstuen
        Console.WriteLine("Rekursiv metode DFS Search fra majorstuen");
        var graphDFS = new Graph();
        graphDFS.AddConnection("Majorstuen", "Nationaltheateret");
        graphDFS.AddConnection("Nationaltheateret", "Stortinget");
        graphDFS.AddConnection("Stortinget", "Jernbanetorget");
        graphDFS.AddConnection("Jernbanetorget", "Grønland");
        graphDFS.AddConnection("Grønland" , "Tøyen");
        graphDFS.AddConnection("Majorstuen", "Blindern");
        graphDFS.AddConnection("Blindern", "Forskningsparken");
        graphDFS.AddConnection("Forskningsparken", "Ullevål Stadion");
        DepthFirstSearch.RecursiveDFSearch(graphDFS, "Majorstuen");
        Console.WriteLine(" ");
        
        // Itereative DFS from majorstuen
        Console.WriteLine("Iterativ metode DFS Search fra majorstuen");
        DepthFirstSearch.IterativeDFSearch(graphDFS, "Majorstuen");
        Console.WriteLine(" ");

        // Comparison with BFS, different order of visits
        
        
        Console.WriteLine("Rekursiv metode DFS Search på isolert stasjon");
        // Isolatedstation, only one station is visited
        var graphWithIsolatedStation = new Graph();
        graphWithIsolatedStation.AddConnection("Majorstuen", "Nationaltheateret");
        graphWithIsolatedStation.AddConnection("Nationaltheateret", "Stortinget");
        graphWithIsolatedStation.AddConnection("Stortinget", "Jernbanetorget");
        graphWithIsolatedStation.AddConnection("Jernbanetorget", "Grønland");
        graphWithIsolatedStation.AddConnection("Grønland" , "Tøyen");
        graphWithIsolatedStation.AddConnection("Majorstuen", "Blindern");
        graphWithIsolatedStation.AddConnection("Blindern", "Forskningsparken");
        graphWithIsolatedStation.AddConnection("Forskningsparken", "Ullevål Stadion");
        graphWithIsolatedStation.AddStation("Sognsvann");
        DepthFirstSearch.RecursiveDFSearch(graphWithIsolatedStation, "Sognsvann");
        Console.WriteLine(" ");
        
        Console.WriteLine("Iterativ metode DFS Search på isolert stasjon");
        DepthFirstSearch.IterativeDFSearch(graphWithIsolatedStation, "Sognsvann");
        Console.WriteLine(" ");
        
        Console.WriteLine("Route exists mellomstasjoner");
        // Route exists, there is a route between stations
        bool routeExistsBetweenStations = DepthFirstSearch.RouteExists(graphDFS, "Majorstuen", "Ullevål Stadion");
        Console.WriteLine($"Route exists: {routeExistsBetweenStations}");
        Console.WriteLine(" ");
        
        Console.WriteLine("Route does not exists between isolated stations");
        bool routeExistsBetweenIsolatedStations = DepthFirstSearch.RouteExists(graphWithIsolatedStation, "Majorstuen", "Sognsvann");
        Console.WriteLine($"Route exists: {routeExistsBetweenIsolatedStations}");
        Console.WriteLine(" ");
        // Route not exists, route between isolated and graph exisits

        // unknown station

        Console.WriteLine("Recursive and iterative depth first search");
        Console.WriteLine("Recursive: ");
        DepthFirstSearch.RecursiveDFSearch(graphDFS, "Unknown");
        Console.WriteLine("Iterative: ");
        DepthFirstSearch.IterativeDFSearch(graphDFS, "Unknown");
        
        
========== Task 5: Depth First Search ===========
Rekursiv metode DFS Search fra majorstuen
Besøkte: Majorstuen
Besøkte: Nationaltheateret
Besøkte: Stortinget
Besøkte: Jernbanetorget
Besøkte: Grønland
Besøkte: Tøyen
Besøkte: Blindern
Besøkte: Forskningsparken
Besøkte: Ullevål Stadion
 
Iterativ metode DFS Search fra majorstuen
Besøkte - Majorstuen
Besøkte - Blindern
Besøkte - Forskningsparken
Besøkte - Ullevål Stadion
Besøkte - Nationaltheateret
Besøkte - Stortinget
Besøkte - Jernbanetorget
Besøkte - Grønland
Besøkte - Tøyen
 
Rekursiv metode DFS Search på isolert stasjon
Besøkte: Sognsvann
 
Iterativ metode DFS Search på isolert stasjon
Besøkte - Sognsvann
 
Route exists mellomstasjoner
Route exists: True
 
Route does not exists between isolated stations
Route exists: False
 
Recursive and iterative depth first search
Recursive: 
The station Unknown does not exist
Iterative: 
The station Unknown does not exist
```

Output:
```
Jeg ville brukt noe sånt:
| Test | Hva testes | Forventet resultat | Resultat |
| --- | --- | --- | --- |
| Rekursiv DFS fra Majorstuen | Besøker alle nåbare stasjoner | 9 stasjoner besøkt | Bestått |
| Iterativ DFS fra Majorstuen | Besøker alle nåbare stasjoner med Stack | 9 stasjoner besøkt | Bestått |
| DFS fra isolert Sognsvann | Håndtering av isolert stasjon | Kun Sognsvann besøkes | Bestått |
| Iterativ DFS fra isolert Sognsvann | Håndtering av isolert stasjon | Kun Sognsvann besøkes | Bestått |
| RouteExists Majorstuen → Ullevål Stadion | Sjekker om det finnes en rute | `true` | Bestått |
| RouteExists Majorstuen → Sognsvann | Sjekker rute til isolert stasjon | `false` | Bestått |
| Ukjent startstasjon – rekursiv DFS | Håndtering av stasjon som ikke finnes | Feilmelding, ingen krasj | Bestått |
| Ukjent startstasjon – iterativ DFS | Håndtering av stasjon som ikke finnes | Feilmelding, ingen krasj | Bestått |
| DFS med syklus | `visited` hindrer uendelig løkke | Alle noder besøkes én gang | Bestått |

```

# 11. help with test result table in linear and binary search

input: gjør om denne koden og resultatetene til en tabell jeg kan bruke i readme md:
```
\========== Task 1 ==========
\=========== Linear Search ===========
Linear search for 7
Index: 3
Comparisons = 4
Expected value: 3, result: 3
Test passed

Linear search for 42
Index: −1
Comparisons = 7
Expected value: −1, result: −1
Test passed

\=========== Binary Search ===========
Binary search for 13
Index: 5
Comparisons = 3
Expected value: 5, result: 5
Test passed

Binary search for 4
Index: −1
Comparisons = 5
Expected value: −1, result: −1
Test passed

Binary search on unsorted list not found
Index: −1
Comparisons = 5
Expected value: −1, result: −1
Test passed

Binary search on unsorted list found
Index: 5
Comparisons = 3
Expected value: 5, result: 5
Test passed

Binary search on empty list
Index: −1
Comparisons = 0
Expected value: −1, result: −1
Test passed

Binary search on list with duplicates
Index: 3
Comparisons = 4
Expected value: 3, result: 3
Test passed

Binary search on list with one element found
Index: 0
Comparisons = 1
Expected value: 0, result: 0
Test passed

public void Run()
{
    
    Console.WriteLine("========== Task 1 ==========");
    
    int[] unsortedlist = [8, 3, 11, 7, 2, 9, 5];
    int[] sortedlist = [2, 5, 7, 9, 11, 13, 17];
    int[] emptyList = [];
    int[] duplicatesInList = [2, 5, 6, 7, 7, 9, 9, 10, 25, 54, 64, 109];
    int[] oneElementList = [1];
    
    Console.WriteLine("=========== Linear Search ===========");
    
    var linearSearchFound = SearchAlgorithms.LinearSearch(unsortedlist, 7);
    Console.WriteLine("Linear search for 7");
    Console.WriteLine($"Index: {linearSearchFound.index}");
    Console.WriteLine($"Comparisons = {linearSearchFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(3, linearSearchFound.index)}");
    Console.WriteLine("");
    
    
    var linearSearchNotFound = SearchAlgorithms.LinearSearch(unsortedlist, 42);
    Console.WriteLine("Linear search for 42");
    Console.WriteLine($"Index: {linearSearchNotFound.index}");
    Console.WriteLine($"Comparisons = {linearSearchNotFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(-1, linearSearchNotFound.index)}");
    Console.WriteLine("");
    
    Console.WriteLine("=========== Binary Search ===========");
    var binarySearchFound = SearchAlgorithms.BinarySearch(sortedlist, 13);
    Console.WriteLine("Binary search for 13");
    Console.WriteLine($"Index: {binarySearchFound.index}");
    Console.WriteLine($"Comparisons = {binarySearchFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(5, binarySearchFound.index)}");
    Console.WriteLine("");
    
    var binarySearchNotFound = SearchAlgorithms.BinarySearch(sortedlist, 4);
    Console.WriteLine("Binary search for 4");
    Console.WriteLine($"Index: {binarySearchNotFound.index}");
    Console.WriteLine($"Comparisons = {binarySearchNotFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(-1, binarySearchNotFound.index)}");
    Console.WriteLine("");

    var binarySearchUnsortedNotFound = SearchAlgorithms.BinarySearch(unsortedlist, 5);
    Console.WriteLine("Binary search on unsorted list not found");
    Console.WriteLine($"Index: {binarySearchUnsortedNotFound.index}");
    Console.WriteLine($"Comparisons = {binarySearchUnsortedNotFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(-1, binarySearchUnsortedNotFound.index)}");
    Console.WriteLine("");
    
    var binarySearchUnsortedFound = SearchAlgorithms.BinarySearch(unsortedlist, 9);
    Console.WriteLine("Binary search on unsorted list found");
    Console.WriteLine($"Index: {binarySearchUnsortedFound.index}");
    Console.WriteLine($"Comparisons = {binarySearchUnsortedFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(5, binarySearchUnsortedFound.index)}");
    Console.WriteLine("");
    
    var binarySearchEmptyList = SearchAlgorithms.BinarySearch(emptyList, 1);
    Console.WriteLine("Binary search on empty list");
    Console.WriteLine($"Index: {binarySearchEmptyList.index}");
    Console.WriteLine($"Comparisons = {binarySearchEmptyList.comparisons}");
    Console.WriteLine($"{TestCheck.Check(-1, binarySearchEmptyList.index)}");
    Console.WriteLine("");

    var binarySearchDuplicatesFound = SearchAlgorithms.BinarySearch(duplicatesInList, 7);
    Console.WriteLine("Binary search on list with duplicates");
    Console.WriteLine($"Index: {binarySearchDuplicatesFound.index}");
    Console.WriteLine($"Comparisons = {binarySearchDuplicatesFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(3, binarySearchDuplicatesFound.index)}");
    Console.WriteLine("");
    
    var binarySearchOneElementFound = SearchAlgorithms.BinarySearch(oneElementList, 1);
    Console.WriteLine("Binary search on list with one element found");
    Console.WriteLine($"Index: {binarySearchOneElementFound.index}");
    Console.WriteLine($"Comparisons = {binarySearchOneElementFound.comparisons}");
    Console.WriteLine($"{TestCheck.Check(0, binarySearchOneElementFound.index)}");
    Console.WriteLine("");
```

output: Her er en README-klar tabell basert på testene og resultatene dine
### Testresultater

| Algoritme   | Test                              | Søkeverdi | Forventet indeks | Faktisk indeks | Sammenligninger | Resultat |
| ----------- | --------------------------------- | --------: | ---------------: | -------------: | --------------: | -------- |
| Lineært søk | Verdi finnes                      |         7 |                3 |              3 |               4 | Bestått  |
| Lineært søk | Verdi finnes ikke                 |        42 |               -1 |             -1 |               7 | Bestått  |
| Binærsøk    | Verdi finnes                      |        13 |                5 |              5 |               3 | Bestått  |
| Binærsøk    | Verdi finnes ikke                 |         4 |               -1 |             -1 |               5 | Bestått  |
| Binærsøk    | Usortert array, verdi finnes ikke |         5 |               -1 |             -1 |               5 | Bestått  |
| Binærsøk    | Usortert array, verdi finnes      |         9 |                5 |              5 |               3 | Bestått  |
| Binærsøk    | Tomt array                        |         1 |               -1 |             -1 |               0 | Bestått  |
| Binærsøk    | Array med duplikater              |         7 |                3 |              3 |               4 | Bestått  |
| Binærsøk    | Array med ett element             |         1 |                0 |              0 |               1 | Bestått  |

# 11 Help with making Table of Contents:
input:
```
Kan du hjelpe meg å lage innholdsfortegnelse som matcher punktene i denne readme (limte inn README.md*)
```

output:
````
## Table of contents

- [Filstruktur](#filstruktur)
- [2. Søkealgoritmer – Lineært søk og binærsøk](#2-søkealgoritmer--lineært-søk-og-binærsøk)
    - [2.0 Implementasjon](#20-implementasjon)
        - [2.1 Lineært søk](#21-lineært-søk)
        - [2.2 Binærsøk](#22-binærsøk)
    - [2.3 Hvordan sammenligninger telles](#23-hvordan-sammenligninger-telles)
    - [2.4 Testresultater](#24-testresultater)
    - [2.5 Tidskompleksitet](#25-tidskompleksitet)
    - [2.6 Sammenligning av tidskompleksitet](#26-sammenligning-av-tidskompleksitet)
- [3.0 Oppgave 2 - Egen generisk datastruktur](#30-oppgave-2---egen-generisk-datastruktur)
    - [3.1 Egen stakk](#31-egen-stakk)
    - [3.2 Hvordan datastrukturen fungerer](#32-hvordan-datastrukturen-fungerer)
    - [3.3 Tester og resultater](#33-tester-og-resultater)
    - [3.4 Tidskompleksitet](#34-tidskompleksitet)
    - [3.5 Bruksområder](#35-bruksområder)
    - [3.6 Refleksjon](#36-refleksjon)
- [4.0 Oppgave 3 - QuickSort()](#40-oppgave-3---quicksort)
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
    - [6.1 Recursive](#61-recursive)
    - [6.2 Iterative](#62-iterative)
    - [6.3 RouteExists](#63-routeexists)
    - [6.4 Testing](#64-testing)
    - [6.5 DFS og BFS](#65-dfs-og-bfs)
    - [6.6 Tids- og plasskompleksitet](#66-tids-og-plasskompleksitet)
- [Learning materials](#learning-materials)
- [Sources](#sources)
```