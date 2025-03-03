using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Person
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Nazwa { get; set; }

        public DateTime Date { get; set; }


        public Person(string name, string title, string nazwa, DateTime date)
        {
            Name = name;
            Title = title;
            Nazwa = nazwa;
            Date = date;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Szymon", "C#", "Ivan", new DateTime(2000, 12, 24));


        }
    }
}
