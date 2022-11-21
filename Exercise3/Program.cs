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
        }
           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
