using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     class ArrayStack
    {
        protected object[] data;
        protected int pointer;

        public ArrayStack(int capacity)
        {
            data = new object[capacity];
            pointer = 0;

        }

        public bool isEmpty()
        {
            return pointer == 0;

        }

        public void push(object ob)
        {
            if (pointer < data.Length)
                data[pointer++] = ob;
        }

        public object pop()
        {
            if (isEmpty())
                return null;
            object ob = data[--pointer];
            data[pointer] = null;
            return ob;
        }
    }
}
