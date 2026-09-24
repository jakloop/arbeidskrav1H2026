
using arbeidskrav1H2026.searchalgorithms;

namespace application;

class Program
{
    static void Main(string[] args)
    {
        
        // new SearchTests().Run();
        // new CustomStackTests().Run();
        // new QuickSortTests().Run();
        
        
        Console.WriteLine("========== Task 4 ==========");
        Console.WriteLine(" BFS");

        var graph = new Graph();
        graph.AddConnection("Majorstuen", "Nationaltheateret");
        graph.AddConnection("Nationaltheateret", "Stortinget");
        graph.AddConnection("Stortinget", "Jernbanetorget");
        graph.AddConnection("Jernbanetorget", "Grønland");
        graph.AddConnection("Grønland" , "Tøyen");
        graph.AddConnection("Majorstuen", "Blindern");
        graph.AddConnection("Blindern", "Forskningsparken");
        graph.AddConnection("Forskningsparken", "Ullevål Stadion");

        int result = BFSearch.BFS(graph, "Majorstuen", "Ullevål Stadion");

        Console.WriteLine(result);
        
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

