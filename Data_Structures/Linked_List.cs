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
        public void Delete_First()
        {
            if (Head == null)
            {
                Console.WriteLine("List already empty, nothing to delete.");
            }
            else
            {
                Node temp = Head;
                Head = Head.Next;
                Console.WriteLine("The node with value {0} was deleted.", temp.Data);
            }
        }
        public void Delete_Last()
        {
            if (Head == null)
            {
                Console.WriteLine("List already empty, nothing to delete.");
            }
            else
            {
                Node temp = Head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                Tail = temp;
                Console.WriteLine("The node with value {0} was deleted.", temp.Next.Data);
                temp.Next = null;
            }
        }
        public void Display()
        {
            Node temp = Head;

            if (temp == null)
            {
                Console.WriteLine("Linked List is empty.");
            }
            else
            {
                Console.WriteLine("Linked List is as follows");
                while (temp != null)
                {
                    Console.Write(temp.Data);
                    if (temp.Next != null)
                    {
                        Console.Write(" -> ");
                    }
                    temp = temp.Next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
