using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Linked_List
    {
        public Node Head;
        public Node Tail;

        public Linked_List()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        public void AddNodeatStart(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public void Display()
        {
            Node temp = Head;

            if (temp == null)
            {
                Console.WriteLine("\nLinked List is empty.");
            }
            else
            {
                Console.WriteLine("\nLinked List is as follows");
                while (temp != null)
                {
                    Console.Write(temp.Data);
                    if (temp.Next != null)
                    {
                        Console.Write(" -> ");
                    }
                    temp = temp.Next;
                }
            }
        }
    }
}
