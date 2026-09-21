namespace arbeidskrav1H2026.searchalgorithms;

public class DepthFirstSearch
{
    // Recursive depth first search
    //
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
    // Iterative depth first search
    //
    public static int IterativeDFSearch(Graph graph,  string station)
    {
        // create empty stack and hashset
        Stack<string> stack = new Stack<string>();
        HashSet<string> visited = new HashSet<string>();

        if (graph.IsEmpty())
        {
            Console.WriteLine($"The graph is empty");
            return -1;
        }

        if (!graph.ContainsStation(station))
        {
            Console.WriteLine($"The station {station} does not exist");
            return -1;
        }
        
        // starts with one station in the stack on the outside of the while loop
        stack.Push(station);
        
        // repeat until the stack is empty
        while (stack.Count > 0)
        {
            //remove the station from the stack 
            string currentStation = stack.Pop();
            Console.WriteLine($"Besøkte - {currentStation}");
            
            // if the station is not in the visited list add it below
            if (!visited.Contains(currentStation))
            {
                visited.Add(currentStation);
                
                // get all the neighbors from the current station
                // from stack overflow forum
                var neighbors = graph.GetNeighbors(currentStation).Where(x => !visited.Contains(x));
                
                // for all the neighbors
                foreach(var neighbor in neighbors)
                {
                    // push the next station in the collection
                    stack.Push(neighbor);
                }
            }
        }
        return -1;
        
    }
    
    // implementer RouteExists?
    
    
    
    
}

// tests
// empty graph
// Unknown starting node
// only one node
// every node is only handled one time each travers
// long chain
// om backtracking fungerer i forgreining
// frakoblede komponenter
