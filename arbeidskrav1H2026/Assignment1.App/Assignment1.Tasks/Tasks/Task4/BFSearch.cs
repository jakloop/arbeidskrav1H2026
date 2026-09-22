namespace arbeidskrav1H2026.searchalgorithms;

// Got inspiration from
// https://www.geeksforgeeks.org/dsa/breadth-first-search-or-bfs-for-a-graph/
// Breadth-First Search
public class BFSearch
{

    public static int BFS(Graph graph, string stationA, string stationB)
    {
        // if graph is empty
        if (graph.IsEmpty())
        {
            Console.WriteLine($"The graph is empty");
            return -1;
        }
        
        // if one of the stations were not found.
        if (!graph.ContainsStation(stationA) || !graph.ContainsStation(stationB))
        {
            Console.WriteLine("One of the stations was not found.");
            return -1;
        }
        Queue<string> q = new Queue<string>();
        HashSet<string> visited = new HashSet<string>();
        
        // AI help implementing this element into the code
        Dictionary<string, int> distance = new Dictionary<string, int>();
        
        q.Enqueue(stationA);
        visited.Add(stationA);
        distance[stationA] = 0;
        
        // while there is a queue, that's not empty
        while (q.Count > 0)
        {
            string current = q.Dequeue();
            Console.WriteLine($"Nåværende stopp: {current}, antall stopp: {distance[current]}");

            if (current == stationB)
            {
                Console.WriteLine($"Endestasjon funnet, antall stopp: {distance[stationB]}");
                return distance[current];
            }

            // AI assitance on this line
            foreach (string linkingStation in graph.GetNeighbors(current))
            {
                if (!visited.Contains(linkingStation))
                {
                    Console.WriteLine($"La til {linkingStation} i besøkt");
                    visited.Add(linkingStation);
                    Console.WriteLine($"La til {linkingStation} i køen");
                    q.Enqueue(linkingStation);
                    distance[linkingStation] =  distance[current] + 1;
                }
            }
        }
        // no route exists
        Console.WriteLine($"No route found from {stationA} to {stationB}");
        return -1;
    }
}