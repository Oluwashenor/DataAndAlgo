using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndAlgo
{
    class StackLinkedListNode
    {
        public int data;
        public StackLinkedListNode next;

        public StackLinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

   public class StackLinkedList
    {
        StackLinkedListNode head;

        public StackLinkedList()
        {
            head = null;
        }
        public void push(int data)
        {
            StackLinkedListNode node = new StackLinkedListNode(data);
            node.next = head;
            head = node;
        }

        public void pop()
        {

            StackLinkedListNode node = head;
            head = head.next;
            Console.WriteLine("Removed Element from stack {0}", node.data);

        }

        public void PrintList()
        {
            StackLinkedListNode runner = head;
            while(runner != null)
            {
                Console.Write(runner.data + " ");
                runner = runner.next;   
            }
        }
    }
 
}
