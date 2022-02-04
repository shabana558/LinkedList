﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****WELCOME TO LINKED LIST OPERATIONS");
            Console.WriteLine("**********1.Inserted into list(From Last)************");
            Console.WriteLine("**********2.Inserted into list(Front)************");
            Console.WriteLine("**********3.Inserting in middle***********");
            Console.WriteLine("**********4.Delete the First Element***********");
            Console.WriteLine("**********5.Delete the Last Element***********");
            Console.WriteLine("**********6.Searching the Element***********");
            Console.WriteLine("***********7.insert and search the element*****");
            Console.WriteLine("***********8.insert and delete the element*****");
            Console.WriteLine("***********9.sorting the element*****");

            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            //Creating object for Custom Linked list class
            CustomLinkedList obj = new CustomLinkedList();
            switch (num)
            {
                case 1:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    break;
                case 2:
                    obj.InsertFront(56);
                    obj.InsertFront(30);
                    obj.InsertFront(70);
                    obj.Display();
                    break;
                case 3:
                    obj.InsertLast(56);
                    obj.InsertLast(70);
                    obj.InsertBetween(2, 30);
                    obj.Display();
                    break;
                case 4:
                    obj.InsertFront(56);
                    obj.InsertFront(30);
                    obj.InsertFront(70);
                    obj.DeleteFirst();
                    obj.Display();
                    break;
                case 5:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.DeleteLast();
                    obj.Display();
                    break;
                case 6:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Search(30);
                    break;
                case 7:

                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Insert(30, 40);
                    obj.Display();
                    break;
                case 8:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(40);
                    obj.InsertLast(70);
                  //  obj.DeleteInBetween(40);
                    obj.Display();
                    break;
                case 9:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(40);
                    obj.InsertLast(70);
                    obj.Sort();
                    obj.Display();
                    break;




            }
            Console.ReadLine();
        }
    }
}
