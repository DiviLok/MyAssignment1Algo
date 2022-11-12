using Dynamic_link_library;

namespace MyFancyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyAssignment myAssignment = new MyAssignment();
            int[] a = { };
            myAssignment.SortedDelegate(a);
        }
    }
}