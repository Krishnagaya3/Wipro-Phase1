using System.Collections;

namespace CollectionExample

{
    public class Class2
    {
        public Class2()
        {


            Hashtable hashtable = new Hashtable(); //  initial capacity ,  load factor  , hashcode provider and comparer
            hashtable.Add("RollNo", "101");

            hashtable.Add("Name", "Rohan");

            //or 

            Console.WriteLine(hashtable["Name"]);

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine(hashtable[key]);

            }

            foreach (DictionaryEntry items in hashtable)
            {

                Console.WriteLine($"{items.Key} , {items.Value}");
            }

            var cities = new Hashtable()
        {
            { "UK" , "London , Manchester"},
            { "USA" , "Chicago, New Yord"},
            { "India" , "Mumbai , Delhi"}

        };



             hashtable = new Hashtable(); //  initial capacity ,  load factor  , hashcode provider and comparer
            hashtable.Add(1, "101");

            hashtable.Add(2, "Rohan");
            Console.WriteLine(hashtable.Contains(1));
            Console.WriteLine(hashtable.Contains(3));

            Console.WriteLine(hashtable.ContainsKey(1));
            Console.WriteLine(hashtable.ContainsKey(3));

        }


    }




}