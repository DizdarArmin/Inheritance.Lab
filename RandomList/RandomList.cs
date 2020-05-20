using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();
        public string ReturnRandomString() {
            
            int index = random.Next(0,this.Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;
           
        }

    }
}
