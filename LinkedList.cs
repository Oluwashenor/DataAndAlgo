using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndAlgo
{
   public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

   public class LinkedList
    {
        int count;
        LinkedListNode head;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void insert(LinkedList list, int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            if(head == null)
            {
                list.head = newNode;
            }
            else
            {
                LinkedListNode lastNode = list.head;
                while(lastNode.next != null)
                {
                    lastNode=lastNode.next;
                }
                lastNode.next = newNode;
            }
        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while(runner != null)
            {
                Console.Write(runner.data + " ");
                runner = runner.next;   
            }
        }
    }
 
}
