Contents
- AI statement
AI bruk som er tillat på gokstad er følgende. Man kan bruke AI som støtte til læring,
ideutvikling, strukturering og problemløsing.

I denne oppgaven har jeg brukt AI til følgende.
- Spørsmål om struktur på oppgaven
- Spørsmål for å kunne forstå konsepter rundt datastrukturer og algoritmer.
- Veiledning, ideutvikling og hjelp til å løse problemer.

Jeg har også gjort mitt ytterste for å rpøve å finne andre kilder før jeg velger
å bruke AI assistanse, eksempelvis, videoer på YouTube, pensum og digitale læreverk.
Likevel er det svært nyttig å bruke AI som diskusjonpartner nå du trenger hjelp til
å forstå. I de tilfellene hvor AI har hjulpet meg med å lage kode har jeg kommentert
det i koden, og lagt det inn i dette dokumentet. Det gjelder også hjelp med struktur. 
Jeg har ikke lagt inn lengre diskusjoner og spørsmål for å hjelp med forståelse.



- Structure help
- Help with finding lowest instance in a sorted array
- getting access to neighboring stations
- check if the stations exist in the graph


1. Guidance with project structure:


(Gemini, 5. September)
Input: How would you go about the structure in this assignment?

Output:
Repository & Project structure

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


-- 2. Help with finding the lowest instance in a sorted list (ChatGPT)
Here i tried to find the lowest instance in a sorted list.
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

-- 3 Giving access to neighbors in graphs
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

4: Check if one of the stations do not exist in the HashSet/graph

Input: I need to check if the stations exist before running the method. how can I do that?

output:
In your Graph class, add:
public bool ContainsStation(string station)
{
return graph.ContainsKey(station);
}