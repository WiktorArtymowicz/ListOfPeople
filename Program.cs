using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Wiktor", Age = 28, PersonCountry = Country.PL });
            people.Add(new Person() { Name = "Ahmed", Age = 25, PersonCountry = Country.DE });
            people.Add(new Person() { Name = "Kinjabu", Age = 20, PersonCountry = Country.FR });
            people.Add(new Person() { Name = "Rahmandi", Age = 35, PersonCountry = Country.GB});

            var result = people.OrderBy(p => p.Name);

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            SortedList<string, Person> pairs = new SortedList<string, Person>();
            pairs.Add("Wiktor", new Person() { Name = "Wiktor", Age = 28, PersonCountry = Country.PL });
            pairs.Add("Ahmed", new Person() { Name = "Ahmed", Age = 25, PersonCountry = Country.DE });
            pairs.Add("Kinjabu", new Person() { Name = "Kinjabu", Age = 20, PersonCountry = Country.FR });
            pairs.Add("Rahmandi", new Person() { Name = "Rahmandi", Age = 35, PersonCountry = Country.GB });

            foreach (var item in pairs)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
