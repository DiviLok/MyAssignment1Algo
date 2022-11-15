using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_link_library
{
    public class PerformanceCompare
    {
        int[] myArray;
        Stack<int> myStack = new Stack<int>();
        Queue<int> myQueue = new Queue<int>();
        Dictionary<int, int> myDictionary = new Dictionary<int, int>();
        List<int> myList = new List<int>();
        SortedDictionary<int, int> mySortedDictionary = new SortedDictionary<int, int>();
        HashSet<int> myHashSet = new HashSet<int>();
        Random random2 = new Random();
        Stopwatch sp = new Stopwatch();

        public delegate void PerformanceComp(int i);
        public void AddingElement(int number)
        {

            sp.Start();

            for (int i = 0; i < number; i++)
            {
                myArray.Append(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Array Addition");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myStack.Push(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Stack Addition");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myQueue.Enqueue(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Queue Addition");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myHashSet.Add(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "HashSet Addition");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myList.Add(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "List Addition");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myDictionary.Add(myDictionary.Count, random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Addition");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                mySortedDictionary.Add(mySortedDictionary.Count, random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapseTime(sp, "SortedDictionary Addition");

        }
        public void RemovingElement(int number)
        {
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myArray.ElementAt(number);
            }

            sp.Stop();
            Utility.ElapseTime(sp, "Array Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myStack.Pop();
            }

            sp.Stop();
            Utility.ElapseTime(sp, "Stack Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myQueue.Dequeue();
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Queue Deletion");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myHashSet.Remove(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "HashSet Deletion");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myList.Remove(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "List Deletion");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                mySortedDictionary.Remove(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "SortedDictionary Deletion");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myDictionary.Remove(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");

        }
        public void SearchElement(int number)
        {
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myArray.Contains(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");

            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myStack.Contains(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myQueue.Contains(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myHashSet.Contains(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myList.Contains(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                myDictionary.ContainsValue(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < number; i++)
            {
                mySortedDictionary.ContainsValue(number);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
        }
        public void SearchByIndex(int index)
        {
            sp.Start();
            for (int i = 0; i < index; i++)
            {
                myArray.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < index; i++)
            {
                myStack.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < index; i++)
            {
                myQueue.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < index; i++)
            {

                myHashSet.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < index; i++)
            {
                myList.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < index; i++)
            {
                mySortedDictionary.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
            sp.Start();
            for (int i = 0; i < index; i++)
            {
                myDictionary.ElementAt(index);
            }
            sp.Stop();
            Utility.ElapseTime(sp, "Dictionary Deletion");
        }
        public void Randomaize1(int size) // random generation of integers for different types of data structures
        {
            SortAlgorithms.Prepare(size);
            Random random1 = new Random();
            for (int i = 0; i < size; i++)
            {
                int r = random1.Next(0, 10 * size);
                
                myArray[i] = r;
                myStack.Push(r);
                myQueue.Enqueue(r);
                myList.Add(r);
                myDictionary.Add(i, r);
                mySortedDictionary.Add(i, r);
                myHashSet.Add(i);

            }
        }
    }
}
