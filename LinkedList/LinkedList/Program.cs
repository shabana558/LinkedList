using System;
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

            //UseCase 1
            CustomLinkedList obj = new CustomLinkedList();
            //Insertion Operation
            obj.Append(56);
            obj.Append(30);
            obj.Append(70);
            //Display Operation
            Console.WriteLine("*****Appending*****");
            obj.Display();

        }
    }
}
