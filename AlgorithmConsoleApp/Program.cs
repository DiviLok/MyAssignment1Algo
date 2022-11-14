using Dynamic_link_library;
using System.Reflection;
using static Dynamic_link_library.SortAlgorithms;
using static Dynamic_link_library.SearchAlgorithms;

namespace AlgorithmConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            int[] myArray;          
            
            
            Console.WriteLine("Enter the array size");
            arraySize = Convert.ToInt32(Console.ReadLine());
            myArray = SortAlgorithms.Prepare(arraySize);

            Console.WriteLine("\nChoose an option");
            Console.WriteLine("\n 1. Search the Array, 2. Sort the Array");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice) 
            {
                case 1: SearchAlgorithm(myArray);
                    break;
                case 2: SortAlgorithm(myArray);
                    break;
            }                       

        }
        public static void SearchAlgorithm(int[] myArray)
        {
            SearchDelegate1 searchDele1 = DoNothing;
            SearchDelegate2 searchDele2 = DoNothing;
            Console.WriteLine("\n Choose Search type");
            Console.WriteLine("\n 1. LinearSearch, 2. BinearSearch");
            int searchSelection = Convert.ToInt16(Console.ReadLine());
            switch (searchSelection)
            {
                case 1: searchDele1 = LinearSearch;
                    //searchType = "LinearSearch";
                    break;
                case 2: searchDele2 = BinearySearch;
                    //searchType = "BinearySearch";
                    break;
            }
            SearchAlgorithms.DisplayRuntime(myArray, searchDele1, searchDele2);
        
        }
        public static void SortAlgorithm(int[] myArray)
        {
           // string sortType = null;
            Console.WriteLine("\nWhat sort method do you want to use? Choose a number:");
            Console.WriteLine("\n1. Bubble, 2. Merge, 3. Selection, 4. Insert, 5. Lambda, 6. QuickSort");

            int sortSelection = Convert.ToInt32(Console.ReadLine());
            SortedDelegate1 sortDele1 = DoNothing;
            SortedDelegate2 sortDele2 = DoNothing;

            switch (sortSelection)
            {
                case 1:
                    sortDele1 = BubbleSort;
                   // sortType = "BubbleSort";
                    break;
                case 2:
                    sortDele2 = MergeSort;
                   // sortType = "MergeSort";
                    break;
                case 3:
                    sortDele1 = SelectionSort;
                    //sortType = "SelectionSort";
                    break;
                case 4:
                    sortDele1 = InsertionSort;
                    //sortType = "InsertionSort";
                    break;
                case 5:
                    sortDele2 = SortbyLambda;
                    //sortType = "SortbyLambda";
                    break;
                case 6:
                    sortDele2 = QuickSort;
                    //sortType = "QuickSort";
                    break;
                    //default:
                    //    sortDele = BubbleSort;
                    //    break;
            }
            SortAlgorithms.DisplayRuntime(myArray, sortDele1, sortDele2);
            //sortDele.Invoke(myArray);
            //sortDele2.Invoke(myArray, 0, arraySize - 1);
            /*            Console.WriteLine("\n" + sortType+ " Sort Result");
                        foreach (int p in myArray)
                            Console.Write(p + " ");
                        Console.Read();*/
        }
    }
}