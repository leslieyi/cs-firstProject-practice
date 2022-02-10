using System;
using FirstProject.People;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Leslie";
            person.Age = 27;
            person.HasPet = false;

            person.Greeting();

        }
    }
}
