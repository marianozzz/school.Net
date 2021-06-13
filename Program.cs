using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Pepe", "Grillo", "miemail@gmail.com", "123466", "20-06-2021", "20-06-2021");

            Console.WriteLine(person.ToString());
            Console.WriteLine(person.Name+", "+person.Lastname);

            
            Console.Read();
        }
    }
}
