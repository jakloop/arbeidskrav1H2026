Contents
- Structure help
- Help with finding lowest instance in a sorted array


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


-- 2. Help with finding the lowest instance in a sorted list
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

-- 3