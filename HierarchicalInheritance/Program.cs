using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();


            dog.Eat();
            dog.Bark();

            cat.Eat();
            cat.Meow();

            Console.ReadLine();
        }
    }
}
