namespace arbeidskrav1H2026.searchalgorithms;

public class DepthFirstSearch
{
    public static void RecursiveDFSearch(Graph graph, string station, HashSet<string> visited)
    {
        // if the station is already visited return 
        if (visited.Contains(station))
        {
            return;
        }

        // mark current station as visited
        visited.Add(station);

        // Print current station
        Console.WriteLine($"Besøkte: {station}");

        //recursive visit of all neighbors
        foreach (string neighbor in graph.GetNeighbors(station))
        {
            // here the new search will begin at each neighbor
            RecursiveDFSearch(graph, neighbor, visited);
        }
    }


    static void iterativeDFSearch(Graph graph)
    {
        Stack<string> stack = new Stack<string>();
        HashSet<string> visited = new HashSet<string>();
    }
}

// tests
// empty graph
// Unknown starting node
// only one node
// every node is only handled one time each travers
// long chain
// om backtracking fungerer i forgreining
// frakoblede komponenter
