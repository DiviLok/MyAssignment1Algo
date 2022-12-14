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
            String userinput="y";
            
            while (userinput =="y")
            {
                Console.WriteLine("Enter the original array size");
                arraySize = Convert.ToInt32(Console.ReadLine());
                myArray = SortAlgorithms.Prepare(arraySize);

                Console.WriteLine("\nChoose an option");
                Console.WriteLine("\n 1. Search the Array, 2. Sort the Array 3. PerformanceCompare 4. Read Employee Info from File");
                

                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SearchAlgorithm(myArray); //Calls the Search Algorithms function
                        break;
                    case 2:
                        SortAlgorithm(myArray); // calls the Sorting Algorithms function
                        break;
                    case 3:
                        PerformanceCompareDS(arraySize); // calls the performance compare function which compares performance of all the data structure types
                        break;
                   case 4:
                        ReadEmployeeInfofromFile();
                        break;

                }
                Console.WriteLine("#### Program Complete. ####\n\n");

                Console.WriteLine("Type 'y' if you want to rerun the program, any other button to exit");
                userinput= Console.ReadLine();
                
            }
      

        }
        public static void PerformanceCompareDS(int arraySize)
        {
            int arrayChangeSize;
            PerformanceCompare pc = new PerformanceCompare();
            Console.WriteLine("The Comparision of Data Structures performance");
           
            pc.PrepareForDSCompare(arraySize);
            
            Console.WriteLine("Enter the size of changes you want to test for compare");

            arrayChangeSize = Convert.ToInt32(Console.ReadLine());
            PerformanceCompare.DisplayRuntime(arraySize, arrayChangeSize);

            /*Console.WriteLine("\n### Comparing addition performance ###\n");
            pc.AddingElement(arrayChangeSize);

            Console.WriteLine("\n### Comparing deletion performance ###\n");
            pc.RemovingElement(arrayChangeSize);

            Console.WriteLine("\n### Comparing search by element performance ###\n");
            pc.SearchElement(arrayChangeSize);

            // This will avoid index out of bound exception while searching by index
            while (arrayChangeSize > arraySize)
            {
                arrayChangeSize = arrayChangeSize - arraySize;
            }
            Console.WriteLine("\n### Comparing search by index performance ###\n");
            pc.SearchByIndex(arrayChangeSize);*/
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
        public static void ReadEmployeeInfofromFile()
        {
            Console.WriteLine("Read Employees file");
            Employees.ReadEmployeeTextFile(Resource1.EmployeeFile);
            Employees.FilterEmployees();
            Employees.GetEmployeeNameUsingMap();
            Employees.GetSumOfExperienceUsingReduce();
        }
    }
}