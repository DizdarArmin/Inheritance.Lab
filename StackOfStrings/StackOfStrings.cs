using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class StackOfStrings : List<string>
    {
        private List<string> data = new List<string>();
        public void Push(string element)
        {
            data.Add(element);

        }
        public bool IsEmpty()
        {
            return data.Count == 0;
        }
        public string Pop()
        {
            string element = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return element;
        }
        public string Peek()
        {
            return data[data.Count - 1];
        }


    }
}
