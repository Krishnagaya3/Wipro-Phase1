using System.Collections;
using CollectionExamples;

namespace CollectionExample

{
    class Program
    {
        static void AddStudent(List<Student> students)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            students.Add(new Student(id, name, age));
            Console.WriteLine("Student added successfully!");
        }

        static void DisplayStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("\nStudent List:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void RemoveStudent(List<Student> students)
        {
            Console.Write("Enter Student ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        public static void Main(string[] args)
        {
            //ArrayList c = new ArrayList();


            // adding elements using object initializer syntax
            //var arraylist = new System.Collections.ArrayList()
            //{
            //    102,"Niti", "Dwivedi",true , 34.50
            //};

            ////converting primitive to object is boxing and object to primitive is unboxing
            //var fe = (int)arraylist[0]; //unboxing
            //var se = (double)arraylist[4];

            //Console.WriteLine($"{fe} , {se}");

            //arraylist[0] = "MoreValue";
            //arraylist[1] = 1101;

            //// arraylist[5] = 1101;

            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);

            //}

            //    List<Student> students = new List<Student>();

            //    while (true)
            //    {
            //        Console.WriteLine("\n1. Add Student\n2. Display Students\n3. Remove Student by ID\n4. Exit");
            //        Console.Write("Choose an option: ");
            //        string choice = Console.ReadLine();

            //        switch (choice)
            //        {
            //            case "1":
            //                AddStudent(students);
            //                break;
            //            case "2":
            //                DisplayStudents(students);
            //                break;
            //            case "3":
            //                RemoveStudent(students);
            //                break;
            //            case "4":
            //                return;
            //            default:
            //                Console.WriteLine("Invalid choice. Try again.");
            //                break;
            //        }
            //    }

            //Class2 hashExample = new Class2();
            //question3.run();
            Stack_Queue.run();
        }
    }

}

