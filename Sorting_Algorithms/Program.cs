using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> testList = SortingTools.GenerateRandomNums(40);
            //IEnumerable<int> testList = new List<int>() { 1, 2, 5, 4, -1, -2, 3 };
            SortingTools.PrintList(testList);

            Console.WriteLine();
            Console.WriteLine("Merge Sort:");
            SortingTools.PrintList(Algorithms.Merge(testList));

            Console.WriteLine();
            Console.WriteLine("Bubble Sort:");
            SortingTools.PrintList(Algorithms.Bubble(testList));

            Console.WriteLine();
            Console.WriteLine("Insertion Sort:");
            SortingTools.PrintList(Algorithms.Insertion(testList));

            Console.WriteLine();
            Console.WriteLine("Quick Sort:");
            SortingTools.PrintList(Algorithms.Quick(testList));

            Console.WriteLine();
            Console.WriteLine("Cocktail-Shaker Sort:");
            SortingTools.PrintList(Algorithms.CocktailShaker(testList));

            //Console.WriteLine();
            //Console.WriteLine("Radix LSD Sort:");
            //SortingTools.PrintList(Algorithms.RadixLSD(testList));
            
            Console.WriteLine();
            Console.WriteLine("Selection Sort:");
            SortingTools.PrintList(Algorithms.Selection(testList));

            Console.ReadKey();
        }
    }
}
