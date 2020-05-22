using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            
            Console.WriteLine(stack.IsEmpty());

            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");



            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());

            stack.Push("five");
            stack.Push("six");
            stack.Push("seven");
            stack.Push("eight");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Console.ReadLine();
        }
    }
}
