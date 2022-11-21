using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public node next;
    }
    class CircularList
    {
        node LAST;

        public CircularList()
        {
            LAST = null;
        }

        public bool Search(int rollNo, ref node previous, ref node current)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return true;
            }
            if (rollNo == LAST.rollNumber)
                return true;
            else
                return (false); 
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }

        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "   " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "    " + LAST.name + "\n");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
