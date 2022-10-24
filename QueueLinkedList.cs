using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndAlgo
{
    public class QueueLinkedList
    {
        LinkedListNode? Front;
        LinkedListNode? Rear; 

        public QueueLinkedList()
        {
            Front = null;
            Rear = null;
        }

         public void enqueue(int x)
        {
            LinkedListNode node = new LinkedListNode(x);
           
            if(Rear == null)
            {
                Front = Rear = node;
                return;
            }
            Rear.next = node;
            Rear = node;
        }

        public LinkedListNode Dequeue()
        {
            if (Front == null)
            {
                return null;
            }
            LinkedListNode node = Front;
            Front = Front.next;
            if (Front == null) Rear = null;
            return node;
        }

        public void printQueueLinkedList(QueueLinkedList list)
        {
            LinkedListNode runner = list.Front;
            while (runner != null)
            {
                Console.Write(runner.data + " ");
                runner = runner.next;
            }
        }

    }
}
