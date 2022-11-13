using Dynamic_link_library;
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
            arraySize = Console.Read();
            myArray= MyAssignment.Prepare(arraySize);
            SortedDelegate SortDele = new SortedDelegate(BubbleSort);

            /*MyAssignment.BubbleSort(myArray);
            MyAssignment.DisplayRuntime();
             MyAssignment.SelectionSort(myArray);
             MyAssignment.InsertionSort(myArray);
             MyAssignment.MergeSort(myArray,0,arraySize-1);
             Console.WriteLine("Hello, World!");*/
        }
    }
}