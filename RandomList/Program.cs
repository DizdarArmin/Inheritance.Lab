using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();
            random.Add("Something3");
            random.Add("Something2");
            random.Add("Something1");
            random.Add("Something");

            Console.WriteLine("Deleted: " + random.ReturnRandomString());
            Console.WriteLine("");

            foreach (string s in random) {
                Console.WriteLine(s);
            }
           

            Console.ReadLine();
        }
    }
}
