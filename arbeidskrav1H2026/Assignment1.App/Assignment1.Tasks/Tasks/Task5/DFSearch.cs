namespace arbeidskrav1H2026.searchalgorithms;

public class DepthFirstSearch
{
    // Recursive depth first search wrapper method
    public static void RecursiveDFSearch(Graph graph, string station)
    {
        // if the station is already visited return 

        if (graph.IsEmpty())
        {
            Console.WriteLine($"The graph is empty");
            return;
        }

        if (!graph.ContainsStation(station))
        {
            Console.WriteLine($"The station {station} does not exist");
            return;
        }
        
        HashSet<string> visited = new HashSet<string>();
        RecursiveDFSearch(graph, station, visited);

    }

    // recursive depth first search method
    private static void RecursiveDFSearch(Graph graph, string station, HashSet<string> visited)
    {
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
    public static void IterativeDFSearch(Graph graph,  string station)
    {
        // create empty stack and hashset
        Stack<string> stack = new Stack<string>();
        HashSet<string> visited = new HashSet<string>();

        if (graph.IsEmpty())
        {
            Console.WriteLine($"The graph is empty");
            return;
        }

        if (!graph.ContainsStation(station))
        {
            Console.WriteLine($"The station {station} does not exist");
            return;
        }
        
        // starts with one station in the stack on the outside of the while loop
        stack.Push(station);
        
        // repeat until the stack is empty
        while (stack.Count > 0)
        {
            //remove the station from the stack 
            string currentStation = stack.Pop();
            
            // if the station is not in the visited list add it below
            if (!visited.Contains(currentStation))
            {
                visited.Add(currentStation);
                Console.WriteLine($"Besøkte - {currentStation}");
                
                // get all the neighbors from the current station
                foreach (string neighbor in graph.GetNeighbors(currentStation))
                {
                    // if the neighbor has not been visited -> add to stack
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }
            }
        }
        
    }

    // Checks if there is a route between stationA and StationB
    public static bool RouteExists(Graph graph, string stationA, string stationB)
    {
        if (graph.IsEmpty())
        {
            return false;
        }

        if (!graph.ContainsStation(stationA) || !graph.ContainsStation(stationB))
        {
            return false;
        }

        Stack<string> stack = new Stack<string>();
        HashSet<string> visited = new HashSet<string>();

        stack.Push(stationA);

        while (stack.Count > 0)
        {
            string currentStation = stack.Pop();

            if (!visited.Contains(currentStation))
            {
                visited.Add(currentStation);
            }

            if (currentStation == stationB)
            {
                return true;
            }

            foreach (string neighbor in graph.GetNeighbors(currentStation))
            {
                if (!visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
        }

        return false;
    }
}
