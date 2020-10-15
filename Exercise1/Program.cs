using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>(new string[] { "John", "Mary", "Sue", "Greg", "Yolanda", "Jose", "Bill" });
            foreach (string name in lista)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.WriteLine("");
            PersonModel[] persons = { new PersonModel("Tim", "Corey"), new PersonModel("Bill", "McCoy"), new PersonModel("Mary", "Jones"), new PersonModel("Sue", "Smith") };
            List<PersonModel> lista2 = new List<PersonModel>(persons);
            foreach (PersonModel name in lista2)
            {
                Console.WriteLine("Hello " + name.ToString());
            }
            Console.ReadKey();
        }
    }
}
