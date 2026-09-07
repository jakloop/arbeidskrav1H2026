


-- 1. Guidance with project structure:


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


-- 2.