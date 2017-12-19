using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // +-----+------+
            // |  3  | null +
            // +-----+------+
            Node first = new Node { Value = 3 };

            // +-----+------+    +-----+------+
            // |  3  | null +    |  5  | null +
            // +-----+------+    +-----+------+
            Node middle = new Node { Value = 5 };

            // +-----+------+    +-----+------+
            // |  3  |  *---+--->|  5  | null +
            // +-----+------+    +-----+------+
            first.Next = middle;

            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  | null +   |  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            Node last = new Node { Value = 7 };

            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            middle.Next = last;

            // now iterate over each node and print the value
            PrintNodes(first);
            Console.ReadKey();


            #region .NetFrmaework LinkedList is DoublyLinkedList
            System.Collections.Generic.LinkedList<int> list = new System.Collections.Generic.LinkedList<int>();
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(7);

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
            #endregion
        }

        public static void PrintNodes(Node node)
        {
            while (node!=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }               
        }
    }
}
