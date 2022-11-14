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
            if (left > right) return -1;
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
            /* 
             Console.WriteLine("Starting..");
             sp.Start();*/
            if ("LinearSearch".Equals(searchDele1))
            {
                
                sp.Start();
                
                searchDele1(array, array[0]);

                sp.Stop();
                TimeSpan ts = sp.Elapsed;

                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("\nRunTime for Searching first number " + elapsedTime);
                
               
                
                sp.Start();
                
                searchDele1(array, array[array.Length / 2]);
                
                sp.Stop();
                TimeSpan ts1 = sp.Elapsed;

                string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts1.Hours, ts1.Minutes, ts1.Seconds,
                    ts1.Milliseconds / 10);
                Console.WriteLine("\nRunTime for Searching Middle number " + elapsedTime1);
               
                
                sp.Start();
                
                searchDele1(array, array[array.Length- 1]);
                
                sp.Stop();
                TimeSpan ts2 = sp.Elapsed;

                string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts2.Hours, ts2.Minutes, ts2.Seconds,
                    ts2.Milliseconds / 10);
                Console.WriteLine("\nRunTime for Searching Last number " + elapsedTime2);
            }
            else
            {
                
                sp.Start();
                
                searchDele2(array, array[0],0,array.Length-1);
                
                sp.Stop();
                TimeSpan ts3 = sp.Elapsed;

                string elapsedTime3 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts3.Hours, ts3.Minutes, ts3.Seconds,
                    ts3.Milliseconds / 10);
                Console.WriteLine("\nRunTime for Searching first number " + elapsedTime3);
               
                
                sp.Start();
                
                searchDele2(array, array[array.Length/2],0,array.Length-1);
                
                sp.Stop();
                TimeSpan ts4 = sp.Elapsed;

                string elapsedTime4 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts4.Hours, ts4.Minutes, ts4.Seconds,
                    ts4.Milliseconds / 10);
                Console.WriteLine("\nRunTime for Searching Middle number " + elapsedTime4);
                
                
                sp.Start();
                
                searchDele2(array, array[array.Length-1],0,array.Length-1);
                
                sp.Stop();
                TimeSpan ts5 = sp.Elapsed;

                string elapsedTime5 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts5.Hours, ts5.Minutes, ts5.Seconds,
                    ts5.Milliseconds / 10);
                Console.WriteLine("\nRunTime for Searching Last number " + elapsedTime5);
                
            }
                
           /* sp.Stop();
            TimeSpan ts = sp.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("\nRunTime " + elapsedTime);*/

        }
    }
}
