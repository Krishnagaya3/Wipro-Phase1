using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    internal class Stack_Queue
    {

        public static void run()
        {

            /*            Stack s = new Stack();

                        Console.WriteLine("****************");
                        Console.WriteLine(s);

                        s.Push(1);
                        s.Push(2);
                        s.Push("String value");
                        s.Push(67.00);

                        Console.WriteLine("****************");
                        Console.WriteLine(s);
                        Console.WriteLine("****************");
                        Console.WriteLine(s.ToString());
                        Console.WriteLine("****************");
                        foreach (object items in s)
                        { 
                              Console.WriteLine(items);
                          //  Console.WriteLine(items.ToString());


                        }
                        Console.WriteLine("****************");
                        Console.WriteLine(s.Count);
                        Console.WriteLine(s.Pop());
                        Console.WriteLine("****************");
                        Console.WriteLine(s.Count);
                        Console.WriteLine("****************");
                        s.Clear();
                        Console.WriteLine("****************");
                        Console.WriteLine(s.Peek());
                    }*/


            Queue<int> s = new Queue<int>();

            Console.WriteLine("****Printer ************");
            Console.WriteLine("Enter no of pages you want to print ");
            //  int p =  Console.ReadLine();

            s.Enqueue(1);
            s.Enqueue(2);
            Console.WriteLine(s.Peek());

            //  s.Enqueue("String value");
            // s.Enqueue(67.00);


            foreach (object items in s)
            {
                Console.WriteLine(items);
                //  Console.WriteLine(items.ToString());


            }
            Console.WriteLine("****************");
            Console.WriteLine(s.Count);
            Console.WriteLine(s.Dequeue());
            Console.WriteLine("****************");
            Console.WriteLine(s.Count);
            Console.WriteLine("****************");
            s.Clear();
            Console.WriteLine("****************");
        }
    }
}
