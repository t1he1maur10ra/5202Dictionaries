using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1*/
            //Dictionary<string, double> dict = new Dictionary<string, double>();
            //dict.Add("Banana", 10.56);
            //dict.Add("Orange", 11.22);
            //dict.Add("Apple", 6.05);
            //dict.Add("Coconut", 1.56);
            //dict.Add("Strawberry", 3.25);

            //foreach(KeyValuePair<string, double> x in dict)
            //    Console.WriteLine($"{x.Key} costs ${x.Value}");

            //Console.ReadLine();

            /*Ex 2*/
            //Dictionary<int, string> dict2 = new Dictionary<int, string>();
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Please enter a name: ");
            //    dict2.Add(i, Console.ReadLine());
            //}
            //foreach (KeyValuePair<int, string> x in dict2)
            //    Console.WriteLine($"{x.Key}: {x.Value}");

            //Console.ReadLine();

            /*Ex 3*/
            Dictionary<int, Person> dict3 = new Dictionary<int, Person>();
            for (int i = 1000; i < 1003; i++)
            {
                Person p1 = new Person();
                Console.Write("Please enter the persons first name: ");
                p1.Fname = Console.ReadLine();
                Console.Write($"Please enter {p1.Fname}'s last name: ");
                p1.Lname = Console.ReadLine();
                Console.Write($"Please enter {p1.Fname}'s age: ");
                p1.Age = int.Parse(Console.ReadLine());
                dict3.Add(i, p1);
            }

            Console.WriteLine("...Dictionary Contents...");
            foreach(KeyValuePair<int, Person> x in dict3)
            {
                Console.WriteLine($"Name: {x.Value.Fname} {x.Value.Lname}\n" +
                    $"Age: {x.Value.Age}\n" +
                    $"ID: {x.Key}");
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
    }
}
