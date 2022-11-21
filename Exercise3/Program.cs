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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
