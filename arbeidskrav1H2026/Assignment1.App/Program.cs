
using arbeidskrav1H2026.searchalgorithms;

namespace application;

class Program
{
    static void Main(string[] args)
    {
        
        // new SearchTests().Run();
        // new CustomStackTests().Run();
        // new QuickSortTests().Run();
        new BFSearchTests().Run();
        
        /*
        Console.WriteLine("========== Task 5 ==========");
        Console.WriteLine(" Depth First Search ");

        HashSet<string> visited = new HashSet<string>();
        DepthFirstSearch.RecursiveDFSearch(graph, "Majorstuen", visited);

        Console.WriteLine("SOME ROOM BETWEEN");
        
        
        DepthFirstSearch.IterativeDFSearch(graph, "Majorstuen");
        
        */
        Console.WriteLine(" ");
        Console.WriteLine("========== Task 6 ==========");
    }
}

