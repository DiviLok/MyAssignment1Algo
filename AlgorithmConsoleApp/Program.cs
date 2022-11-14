using Dynamic_link_library;
using System.Reflection;
using static Dynamic_link_library.MyAssignment;

namespace AlgorithmConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            int[] myArray;
           // MyAssignment Algo = new MyAssignment();
            Console.WriteLine("Enter the array size");
            arraySize = Convert.ToInt32(Console.ReadLine());
            myArray = MyAssignment.Prepare(arraySize);

            Console.WriteLine("\nWhat sort method do you want to use? Choose a number:");
            Console.WriteLine("\n1. Bubble, 2. Merge, 3. Selection, 4. Insert, 5. Lambda, 6. QuickSort");

            int sortSelection = Convert.ToInt32(Console.ReadLine());
            SortedDelegate SortDele = doNothing;
            SortedDelegate2 SortDele2 = doNothing2;
            string sortType = null;

            switch (sortSelection)
            {
                case 1:
                    SortDele = BubbleSort;
                    sortType = "BubbleSort";
                     break;
                case 2: SortDele2 = MergeSort;
                    sortType = "MergeSort";
                    break;
                case 3: SortDele = SelectionSort;
                    sortType = "SelectionSort";
                    break;
                case 4: SortDele = InsertionSort;
                    sortType = "InsertionSort";
                    break;
                case 5: SortDele2 = SortbyLambda;
                    sortType = "SortbyLambda";
                    break;
                case 6: SortDele2 = QuickSort;
                    sortType = "QuickSort";
                    break;
                //default:
                //    SortDele = BubbleSort;
                //    break;
            }
            DisplayRuntime(myArray, SortDele, SortDele2, sortType);
            //SortDele.Invoke(myArray);
            //SortDele2.Invoke(myArray, 0, arraySize - 1);
/*            Console.WriteLine("\n" + sortType+ " Sort Result");
            foreach (int p in myArray)
                Console.Write(p + " ");
            Console.Read();*/

        }
    }
}