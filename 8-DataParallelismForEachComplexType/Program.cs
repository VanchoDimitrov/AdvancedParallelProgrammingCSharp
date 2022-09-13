using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _8_DataParallelismForEachComplexType
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Parallel.ForEach(employee.InsertEmployees(), i =>
            {
                Console.WriteLine(i.Id + " " + i.Name);
            });
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> employees { get; set; } = new();

        public List<Employee> InsertEmployees()
        {
            employees = new List<Employee>()
            {
                new Employee{ Id=1,Name="Name1"},
                new Employee{ Id=2,Name="Name2"},
                new Employee{ Id=3,Name="Name3"},
                new Employee{ Id=4,Name="Name4"},
                new Employee{ Id=5,Name="Name5"},
            };

            return employees;
        }
    }
}
