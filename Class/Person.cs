using System;

namespace Class
{
    class Person
    {
        //field
        public string Name;
        public string Surname;
        public int Age;
        
        //Metoddur,Classin adi ile eyni olan metoddur,ilk obyekt instance alinanda chagirilir,return type-i
        //olmayan metoddur,metod overloading ola bilir.
        //public Person()
        //{
        //   Console.WriteLine("Create first");
        //}
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name,string surname,int age):this(name,surname)
        {
           
            Age = age;
        }
        public string GetFullName()
        {
           
            return $"{Name} {Surname}";
        }

        public string GetFullInfo()
        {
            return $"{GetFullName()} {Age}";
        }
    }
}
