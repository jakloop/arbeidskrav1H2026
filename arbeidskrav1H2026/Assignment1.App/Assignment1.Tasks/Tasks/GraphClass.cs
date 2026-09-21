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
    
    // ContainsStation fucntion from AI help
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
        graph[stationA].Add(stationB);
        graph[stationB].Add(stationA);
    }
    
}