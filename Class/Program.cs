using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance (obyekt yaratmaq)
            //Person person1 = new Person("Ehed","Tagiyev");

            //Console.WriteLine(person1.GetFullName());


            //Console.WriteLine(person1.Name);
            //Person person2 = new Person();
            //person2.Name = "Agha";
            //person2.Surname = "Aghazade";


            //Console.WriteLine(person2.GetFullInfo());
            //StringBuilder stringBuilder = new StringBuilder();


            //Car car = new Car("BMW","X5",25000);

            //Person person3 = new Person("Lale","Quliyeva",25);
            //Console.WriteLine(person3.GetFullInfo());

            Teacher teacher = new Teacher();
            Student student = new Student("Ehed","Tagiyev");
            Console.WriteLine(student.GetFullName());

           
        }
    }
}
