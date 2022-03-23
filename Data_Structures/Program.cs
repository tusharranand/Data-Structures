using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures program.");

            Linked_List linked_list = new Linked_List();
            Node node1 = new Node(22);
            Node node2 = new Node(23);
            Node node3 = new Node(24);

            linked_list.AddNode(node1);
            linked_list.AddNode(node2);
            linked_list.AddNode(node3);

            linked_list.Display();
        }
    }
}