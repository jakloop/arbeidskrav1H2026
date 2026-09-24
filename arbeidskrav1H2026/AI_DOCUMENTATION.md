Contents
- AI statement
AI bruk som er tillat på gokstad er følgende. Man kan bruke AI som støtte til læring,
ideutvikling, strukturering og problemløsing.

I denne oppgaven har jeg brukt AI til følgende.
- Spørsmål om struktur på oppgaven
- Spørsmål for å kunne forstå konsepter rundt datastrukturer og algoritmer.
- Veiledning, ideutvikling og hjelp til å løse problemer.
- Noe språkvask

Jeg har også gjort mitt ytterste for å rpøve å finne andre kilder før jeg velger
å bruke AI assistanse, eksempelvis, videoer på YouTube, pensum og digitale læreverk.
Likevel er det svært nyttig å bruke AI som diskusjonpartner nå du trenger hjelp til
å forstå. I de tilfellene hvor AI har hjulpet meg med å lage kode har jeg kommentert
det i koden, og lagt det inn i dette dokumentet. Det gjelder også hjelp med struktur. 
Jeg har ikke lagt inn lengre diskusjoner og spørsmål for å hjelp med forståelse.



- 1 Structure help
- 2 Help with finding lowest instance in a sorted array
- 3 getting access to neighboring stations
- 4 check if the stations exist in the graph
- 5 Help with structuring the analysis part of all tasks
- 6 Help with changing from xunit testing to printable tests
- 7 checking if lists are equal
- 8 Help with making a test result table


1. Guidance with project structure:


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

-- 2. Help with finding the lowest instance in a sorted list (ChatGPT)
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

# 3 Giving access to neighbors in graphs
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

# 4: Check if one of the stations do not exist in the HashSet/graph

Input: I need to check if the stations exist before running the method. how can I do that?

output:
In your Graph class, add:
public bool ContainsStation(string station)
{
return graph.ContainsKey(station);
}

# 5: Help with structure and headers in README analysis:

Input: I need help with structuring my analysis in the README. Please help me create headers I can fill in this task
*filled in task 1. Repeated this for all the tasks

Output: (this an example of one of the outputs, but this was done on all the tasks
before i started writing the analysis
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

# 6

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


# 7 checking if lists are equal

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

# 8 Help with making test result table 

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
