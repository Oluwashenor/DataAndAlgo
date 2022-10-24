using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndAlgo
{
    public class StackArray
    {
        static int Max = 100;
        int top;
        int[] a = new int[Max];

        public StackArray()
        {
            top = -1;
        }

        bool isEmpty()
        {
            return (top < 0);
        }

        public bool push(int element)
        {
            if(top>= (Max - 1))
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                a[top = top + 1] = element;
                Console.WriteLine("{0} pushed into stack", element);
                return true;
            }
        }

        public int pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                //basically, he doesnt remove the value from the arrya, he just changes head
                int x = a[top = top - 1];
                return x;
            }
        }


        public void printStackElement()
        {
            Console.WriteLine("Elements in the Stack ::: ");
            for (int i = top; i > -1; i--)
            {
                Console.Write("{0} ",a[i]);
            }
        }
    }
}
