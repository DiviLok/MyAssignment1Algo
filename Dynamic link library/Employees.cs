using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_link_library
{
    public class Employees
    {
        public static void ReadTextFile()
        {
            
           string[] lines = System.IO.File.ReadAllLines(@"C:\Users\lokes\OneDrive\UW-studies\Full-Stack\Assignment1\Employees.txt");

            System.Console.WriteLine("Contents of Employees.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

           /* Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();*/
        }
        public static void FilterEmployees()
        {
            string[] words = System.IO.File.ReadAllLines(@"C:\Users\lokes\OneDrive\UW-studies\Full-Stack\Assignment1\Employees.txt");

            IEnumerable<string> query = from word in words
                                        where word.Contains("an") 
                                        select word;

            foreach (string str in query)
                Console.WriteLine(str);
        }
        public static void MapTheFile()
        {
            string[] file = System.IO.File.ReadAllLines(@"C:\Users\lokes\OneDrive\UW-studies\Full-Stack\Assignment1\Employees.txt");
        }
    }
}
