using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dynamic_link_library.SortAlgorithms;

namespace Dynamic_link_library
{
    public class SearchAlgorithms
    {
        public delegate int SearchDelegate1(int[] myArray, int num);
        public delegate int SearchDelegate2(int[] myArray, int num, int left, int right);
        public static int DoNothing(int[] myArray, int num) { return 1; }
        public static int DoNothing(int[] myArray, int num, int left, int right) { return 1; }
        public static int LinearSearch(int[] myArray, int num)
        {
            int arraySize = myArray.Length;
            for (int i = 0; i < arraySize; i++)
            {
                if (myArray[i] == num)
                    return i;
            }
            return -1;
        }
        public static int BinearySearch(int[] myArray, int num, int left, int right)
        {

            if (left > right)
                return -1;
            else
            {
                int mid = (left + right) / 2;
                if (myArray[mid] == num)
                    return mid;
                else if (myArray[mid] > num)
                    return BinearySearch(myArray, num, left, mid - 1);//recursive calling of BinearySearch
                else
                    return BinearySearch(myArray, num, mid + 1, right);

            }
        }
        public static void DisplayRuntime(int[] array, SearchDelegate1 searchDele1, SearchDelegate2 searchDele2)
        {
            Stopwatch sp = new Stopwatch();

            if ("LinearSearch LambdaSearch".Contains(searchDele1.Method.Name))
            {

                sp.Start();

                Console.WriteLine(searchDele1(array, array[0]));

                sp.Stop();
                Utility.ElapseTime(sp, "RunTime ");



                sp.Start();
                Console.WriteLine(searchDele1(array, array[(array.Length) / 2]));

                sp.Stop();
                Utility.ElapseTime(sp, "RunTime ");


                sp.Start();

                Console.WriteLine(searchDele1(array, array[array.Length - 1]));

                sp.Stop();
                Utility.ElapseTime(sp, "RunTime ");

            }
            else
            {
                Array.Sort(array);
                sp.Start();

                Console.WriteLine(searchDele2(array, array[0], 0, array.Length - 1));

                sp.Stop();
                Utility.ElapseTime(sp, "RunTime ");


                sp.Start();

                Console.WriteLine(searchDele2(array, array[(array.Length) / 2], 0, array.Length - 1));

                sp.Stop();
                Utility.ElapseTime(sp, "RunTime ");



                sp.Start();


                Console.WriteLine(searchDele2(array, array[array.Length - 1], 0, array.Length - 1));

                sp.Stop();
                Utility.ElapseTime(sp, "RunTime ");


            }


        }
        public static int LambdaSearch(int[] myArray, int num)
        {
            int number = Array.FindIndex(myArray, num1 => num1 == num);
            return number;

        }
    }
}
