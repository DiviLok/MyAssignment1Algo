using System;
using System.Diagnostics;

namespace Dynamic_link_library
{
    public class MyAssignment
    {
        public delegate void SortedDelegate(int[] myArray);
        public static void Swap(int[] myArray, int i, int j)
        {
            int temp;
            temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;

        }
        public static int[] Randomize(int[] myArray)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 10 * myArray.Length);

            }
            return myArray;
        }
        public static int[] Prepare(int arraysize)
        {
            int[] myArray = new int[arraysize];
            return Randomize(myArray);
            //return myArray;
        }
        public static void DisplayRuntime(int[] array, SortedDelegate sortedDelegate)
        {

            Stopwatch sp = new Stopwatch();

            sp.Start();
            sortedDelegate(array);
            sp.Stop();
            TimeSpan ts = sp.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }

        private static void BubbleSort(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        Swap(myArray, j, j + 1);
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in myArray)
                Console.Write(p + " ");
            Console.Read();
        }


        private static void SelectionSort(int[] myArray)
        {
              
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int Min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[Min] > myArray[j])
                    {
                        Min = j; 
                    }
                }
                Swap(myArray,i, Min);   

            }
        }
        private static void InsertionSort(int[] myArray)
        {
            int j, temp;
            for (int i = 1; i <= myArray.Length - 1; i++)
            {
                temp = myArray[i];
                j = i - 1;
                while (j >= 0 && myArray[j] > temp)
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = temp;
            }
        }

        private static void MergeSort(int[] myArray)
        {

        }





    }
}