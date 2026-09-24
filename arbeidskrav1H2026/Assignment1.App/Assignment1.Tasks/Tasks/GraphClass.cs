namespace arbeidskrav1H2026.searchalgorithms;

public class Graph
{
    private Dictionary<string, HashSet<string>> graph;

    public Graph()
    {
        graph = new Dictionary<string, HashSet<string>>();
    }

    // Get Neighbors was from AI help
    public HashSet<string> GetNeighbors(string station)
    {
        return graph[station];
    }
    
    // ContainsStation function from AI help
    public bool ContainsStation(string station)
    {
        return graph.ContainsKey(station);
    }

    public bool IsEmpty()
    { 
        if (graph.Count == 0)
        {
            return true; 
        }
        return false;
    }

    public void AddConnection(string stationA, string stationB)
    {
        if (!graph.ContainsKey(stationA))
        {
            graph[stationA] = new HashSet<string>();
        }

        if (!graph.ContainsKey(stationB))
        {
            graph[stationB] = new HashSet<string>();
        }
        // creates a two-way connection
        graph[stationA].Add(stationB);
        graph[stationB].Add(stationA);
    }
    
    public void AddStation(string station)
    {
        if (!graph.ContainsKey(station))
        {
            graph[station] = new HashSet<string>();
        }
    }
    
}