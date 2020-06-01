using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfPeople
{
    public class Person
    {
        private string _name = string.Empty;
        private int _age = 0;
        private Country? _personCountry = null;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public Country? PersonCountry { get => _personCountry; set => _personCountry = value; }

        public Person()
        {

        }

        public Person(string name, int age, Country? personCountry)
        {
            _name = name;
            _age = age;
            _personCountry = personCountry;
        }

        public override string ToString()
        {
            return $"Imie: {_name}, Wiek: {_age}, Kraj {_personCountry.ToString()}";
        }
    }
}
