using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string designation, double salary)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Designation: {Designation}, Salary: {Salary:C}";
        }
    }
    class question3
    {
        public static void run()
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("\n1. Add Employee\n2. Display Employees\n3. Remove Employee by ID\n4. Update Salary\n5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee(employees);
                        break;
                    case "2":
                        DisplayEmployees(employees);
                        break;
                    case "3":
                        RemoveEmployee(employees);
                        break;
                    case "4":
                        UpdateSalary(employees);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void AddEmployee(List<Employee> employees)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            string designation = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            employees.Add(new Employee(id, name, designation, salary));
            Console.WriteLine("Employee added successfully!");
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            Console.WriteLine("\nEmployee List:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        static void RemoveEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee removed successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void UpdateSalary(List<Employee> employees)
        {
            Console.Write("Enter Employee ID to update salary: ");
            int id = int.Parse(Console.ReadLine());

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                Console.Write("Enter new salary: ");
                double newSalary = double.Parse(Console.ReadLine());
                employee.Salary = newSalary;
                Console.WriteLine("Salary updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }

}
