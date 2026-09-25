namespace arbeidskrav1H2026.searchalgorithms;

public class BFSearchTests
{
    public void Run()
    { 
    // BSF from majorstuen
    // Shortest distance from majorstuen -> grønland korteste avstand = 4
    // ullevål -> tøyen rute mellom grenene
    // BFS fra isolert stasjon - bare en node besøkes
    // Isolert -> tøyen  ingen rute = -1
    // ukjent start hånderes uten krasj
    // ukjent mål hånderes uten krasj
    // tom graf håndteres uten krasj
    
    Console.WriteLine("========== Task 4: Breadth First Search  ==========");
    // BSF from majorstuen
    Console.WriteLine("Documentation: Order of visits");
    var graph = new Graph();
    graph.AddConnection("Majorstuen", "Nationaltheateret");
    graph.AddConnection("Nationaltheateret", "Stortinget");
    graph.AddConnection("Stortinget", "Jernbanetorget");
    graph.AddConnection("Jernbanetorget", "Grønland");
    graph.AddConnection("Grønland" , "Tøyen");
    graph.AddConnection("Majorstuen", "Blindern");
    graph.AddConnection("Blindern", "Forskningsparken");
    graph.AddConnection("Forskningsparken", "Ullevål Stadion");
    int normalTraversal = BFSearch.BFS(graph, "Majorstuen");
    Console.WriteLine(normalTraversal);
    Console.WriteLine(" ");
    
    // Shortest distance from majorstuen -> grønland korteste avstand = 4
    Console.WriteLine(" Shortest amount of stops from Majorstuen to Grønland");
    int shortestDistanceM2G = BFSearch.ShortestDistance(graph, "Majorstuen", "Grønland");
    Console.WriteLine($"{TestCheck.Check(4, shortestDistanceM2G)}");
    Console.WriteLine(" ");
    
    
    // ullevål -> tøyen rute mellom grenene
    Console.WriteLine("Shortest amount of stops from Tøyen to Ullevål Stadion");
    int routeBetweenBranches = BFSearch.ShortestDistance(graph, "Tøyen", "Ullevål Stadion");
    Console.WriteLine($"{TestCheck.Check(8, routeBetweenBranches)}");
    Console.WriteLine(" ");

    // BFS fra isolert stasjon - bare en node besøkes
    Console.WriteLine("BFS from isolated station, only one node visited");
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
    
    int lonelyNode = BFSearch.BFS(graphWithIsolatedStation, "Sognsvann");
    
    Console.WriteLine($"{TestCheck.Check(1, lonelyNode)}");
    Console.WriteLine(" ");
    
    // Isolert -> tøyen  ingen rute = -1
    Console.WriteLine("BFS from isolated station, only one node visited");
    int lonelyNode2 = BFSearch.ShortestDistance(graphWithIsolatedStation, "Sognsvann", "Tøyen");
    Console.WriteLine($"{TestCheck.Check(-1, lonelyNode2)}");
    Console.WriteLine(" ");
    
    // ukjent start hånderes uten krasj
    Console.WriteLine("Unknown departure station");
    int unknownStart = BFSearch.ShortestDistance(graph, "Sesam Stasjon", "Grønland");
    Console.WriteLine($"{TestCheck.Check(-1, unknownStart)}");
    Console.WriteLine(" ");
    
    // ukjent mål hånderes uten krasj
    Console.WriteLine("Unknown destination");
    int unknownEnd = BFSearch.ShortestDistance(graph, "Majorstuen", "Sesam Stasjon");
    Console.WriteLine($"{TestCheck.Check(-1, unknownEnd)}");
    Console.WriteLine(" ");
    
    // tom graf håndteres uten krasj
    Console.WriteLine("Empty graph traversal, handeled without crash");
    var emptyGraph = new Graph();
    int emptyGraphTraversal = BFSearch.BFS(emptyGraph, "Majorstuen");
    Console.WriteLine($"{TestCheck.Check(-1, emptyGraphTraversal)}");
    Console.WriteLine(" ");

    }
}