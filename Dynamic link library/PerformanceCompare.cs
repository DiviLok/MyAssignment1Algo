using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        //Adding number of elements 'n' based on user inputs
        public void AddingElement(int number)
        {
            Console.WriteLine("Length of Array Before Addition: " + myArray.Length);
            sp.Restart();
            Array.Resize(ref myArray, myArray.Length + number);//Resizing the array to add new elements to the original array
            for (int i = 0; i < number; i++)
            {
                myArray.Append(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "Array Addition");
            Console.WriteLine("Length of Array After Addition: " + myArray.Length);

            Console.WriteLine("Length of Stack Before Addition: " + myStack.Count);
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                myStack.Push(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "Stack Addition");
            Console.WriteLine("Length of Stack After Addition: " + myStack.Count);

            Console.WriteLine("Length of Queue Before Addition: " + myQueue.Count);
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                myQueue.Enqueue(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "Queue Addition");
            Console.WriteLine("Length of Queue Before Addition: " + myQueue.Count);

            Console.WriteLine("Length of Hashset Before Addition: " + myHashSet.Count);
            sp.Restart();

            // Ensure hashset reaches desired size by using unique elements
            for (int i = 0; i < number; i++)
            {
                int rHash = random2.Next(0, 10 * number);
                while (myHashSet.Contains(rHash))
                {
                    rHash = random2.Next(0, 10 * number);
                }
                myHashSet.Add(rHash);
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "HashSet Addition");
            Console.WriteLine("Length of Hashset After Addition: " + myHashSet.Count);

            Console.WriteLine("Length of List Before Addition: " + myList.Count);
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                myList.Add(random2.Next(0, 10 * number));
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "List Addition");
            Console.WriteLine("Length of List Before Addition: " + myList.Count);

            Console.WriteLine("Length of Dictionary Before Addition: " + myDictionary.Count);
            int r;
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                // Ensure Dictionary keys are unique by making sure the key does not already exist
                int rDict = random2.Next(0, 10 * number);
                while (myDictionary.ContainsKey(rDict))
                {
                    rDict = random2.Next(0, 10 * number);
                }
                myDictionary.Add(rDict, rDict);
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "Dictionary Addition");
            Console.WriteLine("Length of Dictionary After Addition: " + myDictionary.Count);

            Console.WriteLine("Length of SortedDictionary Before Addition: " + myDictionary.Count);

            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                int rSDict = random2.Next(0, 10 * number);
                // Ensure Dictionary keys are unique by making sure the key does not already exist
                while (mySortedDictionary.ContainsKey(rSDict))
                {
                    rSDict = random2.Next(0, 10 * number);
                }
                mySortedDictionary.Add(rSDict, rSDict);
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "SortedDictionary Addition");
            Console.WriteLine("Length of SortedDictionary After Addition: " + mySortedDictionary.Count);

        }

        //Deleting number of elements 'n' based on user inputs
        public void RemovingElement(int number)
        {
            Console.WriteLine("Length of Array Before Deleting: " + myArray.Length);
            sp.Restart();
            //Source: https://stackoverflow.com/questions/496896/how-to-delete-an-element-from-an-array-in-c-sharp
            myArray = myArray.Where((source, index) => index >= number).ToArray();//delete the first n elements of the array using where clause
            
            sp.Stop();
            Utility.ElapsedTime(sp, "Array Deletion");
            Console.WriteLine("Length of Array After Deleting: " + myArray.Length);

            Console.WriteLine("Length of Stack Before Deleting: " + myStack.Count);
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                myStack.Pop();
            }

            sp.Stop();
            Utility.ElapsedTime(sp, "Stack Deletion");
            Console.WriteLine("Length of Stack After Deleting: " + myStack.Count);

            Console.WriteLine("Length of Queue Before Deleting: " + myQueue.Count);
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                myQueue.Dequeue();
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "Queue Deletion");
            Console.WriteLine("Length of Queue After Deleting: " + myQueue.Count);

            Console.WriteLine("Length of Hashset Before Deleting: " + myHashSet.Count);
            sp.Restart();

            int h = 0;
            foreach (int j in myHashSet)
            {
                myHashSet.Remove(j);
                h++;
                if (h >= number)
                {
                    break;
                }
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "HashSet Deletion");
            Console.WriteLine("Length of Hashset After Deleting: " + myHashSet.Count);

            Console.WriteLine("Length of List Before Deleting: " + myList.Count);
            sp.Restart();
            for (int i = 0; i < number; i++)
            {
                myList.RemoveAt(i);
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "List Deletion");
            Console.WriteLine("Length of List After Deleting: " + myList.Count);

            Console.WriteLine("Length of SortedDictionary Before Deleting: " + mySortedDictionary.Count);
            sp.Restart();
            int x = 0;

            //capture keys as list in tempArray to use for deletion
            int[] tempArray = new int[number];
            foreach(int y in mySortedDictionary.Keys)
            {
                tempArray[x++] = y;
                if (x >= number) { break; }
            }
            foreach (int el in tempArray)
            {
                mySortedDictionary.Remove(el);
            }
            sp.Stop();
            Utility.ElapsedTime(sp, "SortedDictionary Deletion");
            Console.WriteLine("Length of SortedDictionary After Deleting: " + mySortedDictionary.Count);

            Console.WriteLine("Length of Dictionary Before deleting: " + myDictionary.Count);
            sp.Restart();
            int a = 0;

            //capture keys as list in tempArray to use for deletion
            int[] tempArray1 = new int[number];
            foreach(int b in myDictionary.Keys)
            {
                tempArray1[a++] = b;
                if(a>= number) { break; }
            }
            foreach (int el in tempArray1)
            { myDictionary.Remove(el); }
            sp.Stop();
            Utility.ElapsedTime(sp, "Dictionary Deletion");
            Console.WriteLine("Length of Dictionary After deleting: " + myDictionary.Count);

        }

        //Search 'n' number of elements based on user input
        public void SearchElement(int number)
        {
            sp.Restart();
            myArray.Contains(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "Array Search");

            sp.Restart();
            myStack.Contains(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "Stack Search");
            
            sp.Restart();
            myQueue.Contains(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "Queue Search");
            
            sp.Restart();
            myHashSet.Contains(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "HashSet Search");
            
            sp.Restart();
            myList.Contains(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "List Search");
            
            sp.Restart();
            myDictionary.ContainsValue(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "Dictionary Search");
            
            sp.Restart();
            mySortedDictionary.ContainsValue(number);
            sp.Stop();
            Utility.ElapsedTime(sp, "SortedDictionary Search");
        }
        public void SearchByIndex(int index)
        {
            // Search a random index within the original array
            Random r = new Random();
            int newIndex = r.Next(index-1);
            sp.Restart();

            myArray.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "Array SearchByIndex");
            
            sp.Restart();
            myStack.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "Stack SearchByIndex");

            sp.Restart();
            myQueue.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "Queue SearchByIndex");
            
            sp.Restart();
            myHashSet.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "HashSet SearchByIndex");
            
            sp.Restart();
            myList.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "List SearchByIndex");
            
            sp.Restart();
            mySortedDictionary.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "SortedDictionary SearchByIndex");
            
            sp.Restart();
            myDictionary.ElementAt(newIndex);
            sp.Stop();
            Utility.ElapsedTime(sp, "Dictionary SearchByIndex");
        }
        public void PrepareForDSCompare(int size) // random generation of integers for different types of data structures
        {
            myArray = new int[size];
            Random random1 = new Random();
            for (int i = 0; i < size; i++)
            {
                int r = random1.Next(0, 10 * size);

                myArray[i] = r;
                myStack.Push(r);
                myQueue.Enqueue(r);
                myList.Add(r);

                // Check hashset to ensure the random number does not exist
                // Loop until we get a unique random number
                // Use this unique random number for dict and sorted dict
                while (myHashSet.Contains(r))
                {
                    r = random1.Next(0, 10 * size);
                }
                myHashSet.Add(r);
                myDictionary.Add(r, r);
                mySortedDictionary.Add(r, r);


            }
        }
    }
}
