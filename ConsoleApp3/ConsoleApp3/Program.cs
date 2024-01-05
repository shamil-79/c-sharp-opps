using System;
using System.ComponentModel;

namespace test
{
    public class Test
    {


        public class Reffing
        {
          

            public  int Modifylw (ref int x)
            {
              return  x=x+10;
            }
            


        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class Reffing2
        {
            public static void Main(string[] args)
            {
                int value = 32;
                Reffing obj = new Reffing();
                obj.Modifylw(ref value);
                Console.WriteLine(value);
                List<int> number = new List<int> { 1, 2, 3, 4, 10, 11, 12, 13, 14, 15, 5, 6, 7, 8, 9, };
                var filterednumber = from num in number where num % 2 == 0 orderby num descending select num;
                foreach (var num in filterednumber)
                {
                    Console.WriteLine(num);
                }
                List<Person> people = new List<Person>
                {
                    new Person { Name = "Alice", Age = 25 },
                    new Person { Name = "Bob", Age = 30 },
                    new Person { Name = "Charlie", Age = 22 },
                    new Person { Name = "David", Age = 28 }
                };
                var result = from person in people
                             where person.Age <= 30
                             orderby person.Age
                             select person;
                foreach (var person in result)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }





            }
        }
       
       
        
    }
   
}

