using System;

namespace Banking_Simulator
{
    // cash cash withdraw and deposite are done
    public class Banking
    {
        // cash withdraw
        public int cashWithdraw(int cashToWithdraw, int currentBalance)
        {
            currentBalance -= cashToWithdraw;
            return currentBalance;
        }

        // cash deposite
        public int cashDeposite(int cashToDeposite, int currentBalance)
        {
            currentBalance += cashToDeposite;
            return currentBalance;
        }
    }

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

    class Program
    {
        // main method
        static void Main(string[] args)
        {
            Console.WriteLine("!!Welcome to Banking Simulator Cash Counter!!");
            LinkedList link = new LinkedList(); // object creation of QueueList
            Banking bank = new Banking(); // object creation of Banking

            int count = 0;
            int numberOfAccountants = 5;
            int choice = 0;
            while (count < numberOfAccountants)
            {
                int accountantBalance = 5000;
                int totalAccountantBalance = 0;
                try
                {
                    Console.WriteLine("Enter your Choice :\nPress 1: toDeposite \nPress 2: toWithdraw");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Deposite amount: ");
                            int depositeCash = Convert.ToInt32(Console.ReadLine());
                            totalAccountantBalance = bank.cashDeposite(depositeCash, accountantBalance);
                            link.insertAtLast(totalAccountantBalance);
                            link.showLinkedlist();
                            link.removeAtFirst();
                            depositeCash = 0;
                            break;

                        case 2:
                            Console.WriteLine("Enter withdraw amount: ");
                            int withdrawCash = Convert.ToInt32(Console.ReadLine());
                            if (accountantBalance < withdrawCash)
                            {
                                Console.WriteLine("!!** insufficient balance to withdraw **!!\n");
                            }
                            else
                            {
                                totalAccountantBalance = bank.cashWithdraw(withdrawCash, accountantBalance);
                                link.insertAtLast(totalAccountantBalance);
                                link.showLinkedlist();
                                link.removeAtFirst();
                                withdrawCash = 0;
                            }
                            break;
                    }
                    count += 1;
                }
                catch
                {
                    Console.WriteLine("!!**Enter appropriate value.**!!\n");
                }
            }
        }
    }
}
