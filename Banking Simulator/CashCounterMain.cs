using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Simulator
{
    class CashCounterMain
    {
        // main method
        static void Main(string[] args)
        {
            Console.WriteLine("!!Welcome to Banking Simulator Cash Counter!!");
            LinkedList link = new LinkedList(); // object creation of linkedlist
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
