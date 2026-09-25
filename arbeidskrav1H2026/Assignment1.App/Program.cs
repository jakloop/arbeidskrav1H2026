
using arbeidskrav1H2026.searchalgorithms;

namespace application;

class Program
{
    static void Main(string[] args)
    {
        new SearchTests().Run();
        new CustomStackTests().Run();
        new QuickSortTests().Run();
        new BFSearchTests().Run();
        new DFSearchTests().Run();

    }
}

