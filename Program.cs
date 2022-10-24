namespace DataAndAlgo
{

    public class Program{       
        public static void Main()
        {

            //LinkedList linkedList2 = new LinkedList();
            //linkedList2.insert(linkedList2, 1);
            //linkedList2.insert(linkedList2, 32);
            //linkedList2.insert(linkedList2, 51);
            //linkedList2.insert(linkedList2, 27);
            //linkedList2.insert(linkedList2, 9);
            //linkedList2.insert(linkedList2, 14);
            //linkedList2.insert(linkedList2, 52);
            //linkedList2.PrintList();


            //Hashing Algorithm 
            //string[] hashing = { "AB", "Bb", "PR", "Ca", "PQ" };
            //Hashing.HashingAlgorithm(hashing);


            //StackLinkedList stacklinkedList = new StackLinkedList();
            //stacklinkedList.push(1);
            //stacklinkedList.push(32);
            //stacklinkedList.push(51);
            //stacklinkedList.push(27);
            //stacklinkedList.push(9);
            //stacklinkedList.PrintList();
            //stacklinkedList.pop();
            //stacklinkedList.PrintList();


            //StackArray stackArray = new StackArray();
            //stackArray.push(1);
            //stackArray.push(32);
            //stackArray.push(51);
            //stackArray.push(27);
            //stackArray.push(9);
            //stackArray.printStackElement();
            //stackArray.pop();
            //stackArray.printStackElement();


            QueueLinkedList queue = new QueueLinkedList();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);   
            queue.enqueue(4);
            queue.enqueue(5);
            queue.Dequeue();
            queue.printQueueLinkedList(queue);
        }

    }
}