using System;
using System.Diagnostics;

namespace Dynamic_link_library
{
    public class SortAlgorithms
    {
        public delegate void SortedDelegate1(int[] myArray);

        public delegate void SortedDelegate2(int[] myArray, int x, int y);
        public static void Swap(int[] myArray, int i, int j)
        {
            int temp;
            temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;

        }
        public static void DoNothing(int[] myArray) { }
        public static void DoNothing(int[] myArray, int x, int y) { }
        public static int[] Randomize(int[] myArray)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 10 * myArray.Length);

            }
            return myArray;
        }
        public static int[] Prepare(int arraySize)
        {
            int[] myArray = new int[arraySize];
            myArray = Randomize(myArray);
            return myArray;
        }
        public static void DisplayRuntime(int[] array, SortedDelegate1 sortedDelegate1, SortedDelegate2 sortedDelegate2)
        {

            Stopwatch sp = new Stopwatch();

            sp.Start();

            if ("InsertionSort SelectionSort BubbleSort".Contains(sortedDelegate1.Method.Name)) // Choose delegate method based on user input
            {
                sortedDelegate1(array);
            }
            else
            {
                sortedDelegate2(array, 0, array.Length - 1);
            }

            sp.Stop();
            Utility.ElapseTime(sp, "RunTime ");


        }

        public static void BubbleSort(int[] myArray)
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
        }


        public static void SelectionSort(int[] myArray)
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
                Swap(myArray, i, Min);

            }
        }
        public static void InsertionSort(int[] myArray)
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

        public static void MergeSort(int[] myArray, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(myArray, left, mid);
                MergeSort(myArray, (mid + 1), right);
                Mergemethod(myArray, left, (mid + 1), right);
            }

        }
        public static void Mergemethod(int[] myArray, int left, int mid, int right)
        {
            int[] temp = new int[myArray.Length];    // temp is a temporary array to store result
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right)) //merging when tow halves have unsorted items
            {
                if (myArray[left] <= myArray[mid])
                    temp[tmp_pos++] = myArray[left++];
                else
                    temp[tmp_pos++] = myArray[mid++];
            }
            while (left <= left_end) temp[tmp_pos++] = myArray[left++]; //remaining items are copied into temp
            while (mid <= right) temp[tmp_pos++] = myArray[mid++];
            for (i = 0; i < num_elements; i++)
            {
                myArray[right] = temp[right]; right--;
            }

        }
        public static void SortbyLambda(int[] myArray, int x, int y)
        {
            Array.Sort(myArray, (x, y) => x.CompareTo(y));
        }
        public static int Partition(int[] myArray, int left, int right)
        {

            int pivot = myArray[left];
            while (true)
            {
                while (myArray[left] < pivot)
                    left++;

                while (myArray[right] > pivot)
                    right--;
                if (left < right)
                {
                    Swap(myArray, left, right);
                }
                else
                {
                    return right;
                }

            }

        }
        public static void QuickSort(int[] myArray, int left, int right)

        {

            // For Recusrion  

            if (left < right)

            {

                int pivot = Partition(myArray, left, right);



                if (pivot > 1)

                    QuickSort(myArray, left, pivot - 1);



                if (pivot + 1 < right)

                    QuickSort(myArray, pivot + 1, right);

            }


        }

    }
}