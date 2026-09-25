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

        Console.WriteLine("Recursive and iterative depth first search with unknow station");
        Console.WriteLine("Recursive: ");
        DepthFirstSearch.RecursiveDFSearch(graphDFS, "Unknown");
        Console.WriteLine("Iterative: ");
        DepthFirstSearch.IterativeDFSearch(graphDFS, "Unknown");
        
        

    }
}