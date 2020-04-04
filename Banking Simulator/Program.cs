using System;

namespace Banking_Simulator
{
      public class Node
    {
        public int data;// declaring a variable
        public Node next;// referance to next node
    }

    public class LinkedList
    {
        Node head; // referance to first node

        // insertAtLast
        public void insertAtLast(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        // removeAtFirst
        public void removeAtFirst()
        {
            Node temp = head.next;

            head = temp;
        }

        // to display list
        public void showLinkedlist()
        {
            Node n = head;
            while (n.next != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
            Console.WriteLine(n.data);
        }
    }    
}
