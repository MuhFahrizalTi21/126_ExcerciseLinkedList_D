﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseLinkedList_D
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }

        public bool Search(int rolNo, ref Node previous, ref Node current)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rolNo == current.rollNumber)
                    return (true);
            }
            if (rolNo == LAST.rollNumber)
                return true;
            else 
                return (false);
        }

        public bool listEmpty()
        {
            if (LAST == null)
                return true ;
            else
                return false ;
        }

        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.WriteLine(currentNode.rollNumber + " " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.WriteLine(LAST.rollNumber + " " + LAST.name + "\n");
            }
        }

        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
                Console.WriteLine("\nThe first record in the last is:\n\n" +
                    LAST.next.rollNumber + " " + LAST.next.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularList obj = new CircularList();

            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. View all the records in the list");
                    Console.WriteLine("2. Search for a record in the list");
                    Console.WriteLine("3. Display the first record in the list");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}
