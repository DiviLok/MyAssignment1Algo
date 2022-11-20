using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_link_library
{
    public class Employees
    {
        String name;
        String occupation;
        int experience;
        static List<Employees> employeeInfo = new List<Employees>();
        public static void ReadEmployeeTextFile(string path)
        {
            
            Console.WriteLine(path);

            var lines = System.IO.File.ReadAllLines(path);
            //System.IO.File.ReadAllLines(@"C:\Users\lokes\OneDrive\UW-studies\Full-Stack\Assignment1\AlgoAssignment\Dynamic link library\Dynamic link library\Employee.txt");
            foreach (var l in lines)
            {
                var tempArray = l.Split('|');
                employeeInfo.Add(new Employees { name = tempArray[0], occupation = tempArray[1], experience = Convert.ToInt16(tempArray[2]) });
            }
            
        }
        public static void FilterEmployees()
        {
            IEnumerable<Employees> emps = employeeInfo.Where(x => x.name.Contains("an"));
            Console.WriteLine();
            Console.WriteLine("## Filtering Employee name with 'an' in their name");
            foreach (Employees emp in emps)
                Console.WriteLine(emp.name + " " + emp.occupation + " " +emp.experience);
        }
        public static void GetEmployeeNameUsingMap()
        {
            IEnumerable<string> names = employeeInfo.Select(x => x.name);
            Console.WriteLine();
            Console.WriteLine("## Getting employee names using map");
            foreach (var name in names)
                Console.WriteLine(name);
                  
        }
        public static void GetSumOfExperienceUsingReduce()
        {
            int sumOfExperience = employeeInfo.Select(x =>x.experience).Sum();
            Console.WriteLine();
            Console.WriteLine("## Sum of Employee Experience using Reduce ");
            Console.WriteLine(sumOfExperience);

        }

    }
}
