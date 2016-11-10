using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = ReadFile();

            foreach (Employee Emp in EmployeeList)
            {
                Console.WriteLine(Emp.Name1 + "=>" + Emp.Salary1);
                //Console.WriteLine($"Name: {Emp.Name1} , Salary:{Emp.Salary1}");
                //Console.WriteLine("Name:{0}, Salary: {1}", Emp.Name1, Emp.Salary1);
            }

            StreamWriter sw = new StreamWriter("../../DataFile.txt", true);
            sw.Write("\nTommy,100000000000");
            sw.Close();


        }

        private static List<Employee> ReadFile()
        {
            List<Employee> EmployeeList = new List<Employee>();

            string filelocation = "../../DataFile.txt";

            StreamReader reader = new StreamReader(filelocation);

            string Data = reader.ReadToEnd().Trim();

            string[] Records = Data.Split('\n');

            foreach (string record in Records)
            {
                string[] rc = record.Split(',');
                EmployeeList.Add(new Employee(rc[0], float.Parse(rc[1])));




            }
            reader.Close();
            return EmployeeList;
        }
    }
}
