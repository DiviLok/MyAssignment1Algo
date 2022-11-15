﻿using Dynamic_link_library;
using System.Reflection;
using static Dynamic_link_library.SortAlgorithms;
using static Dynamic_link_library.SearchAlgorithms;

namespace AlgorithmConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] myArray;
            PerformanceCompare pc = new PerformanceCompare();

            Console.WriteLine("Enter the array size");
            size = Convert.ToInt32(Console.ReadLine());
            myArray = SortAlgorithms.Prepare(size);

            Console.WriteLine("\nChoose an option");
            Console.WriteLine("\n 1. Search the Array, 2. Sort the Array 3. PerformanceCompare");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SearchAlgorithm(myArray);
                    break;
                case 2:
                    SortAlgorithm(myArray);
                    break;
               case 3:
                    
                    Console.WriteLine("The Comparision of Data Structures performance");
                    pc.Randomaize1(size);
                    pc.AddingElement(size);
                    pc.RemovingElement(size);
                    pc.SearchElement(size);
                    pc.SearchByIndex(size);
                    break;

            }
            


        }
        public static void SearchAlgorithm(int[] myArray)
        {
            SearchDelegate1 searchDele1 = DoNothing;
            SearchDelegate2 searchDele2 = DoNothing;
            Console.WriteLine("\n Choose Search type");
            Console.WriteLine("\n 1. LinearSearch, 2. BinearSearch 3. LambdaSearch");
            int searchSelection = Convert.ToInt16(Console.ReadLine());
            switch (searchSelection)
            {
                case 1:
                    searchDele1 = LinearSearch;
                    
                    break;
                case 2:
                    searchDele2 = BinearySearch;
                    
                    break;
                case 3:
                    searchDele1 = LambdaSearch;
                    break;

            }
            SearchAlgorithms.DisplayRuntime(myArray, searchDele1, searchDele2);

        }
        public static void SortAlgorithm(int[] myArray)
        {
            
            Console.WriteLine("\nWhat sort method do you want to use? Choose a number:");
            Console.WriteLine("\n1. Bubble, 2. Merge, 3. Selection, 4. Insert, 5. Lambda, 6. QuickSort");

            int sortSelection = Convert.ToInt32(Console.ReadLine());
            SortedDelegate1 sortDele1 = DoNothing;
            SortedDelegate2 sortDele2 = DoNothing;

            switch (sortSelection)
            {
                case 1:
                    sortDele1 = BubbleSort;
                    break;
                case 2:
                    sortDele2 = MergeSort;
                    break;
                case 3:
                    sortDele1 = SelectionSort;
                    break;
                case 4:
                    sortDele1 = InsertionSort;
                    break;
                case 5:
                    sortDele2 = SortbyLambda;
                    break;
                case 6:
                    sortDele2 = QuickSort;
                    break;
            }
            SortAlgorithms.DisplayRuntime(myArray, sortDele1, sortDele2);

        }
    }
}