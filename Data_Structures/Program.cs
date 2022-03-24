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
            Node node_one = new Node(22);
            Node node_two = new Node(23);
            Node node_three = new Node(24);
            linked_list.AddNode(node_one);
            linked_list.AddNode(node_two);
            linked_list.AddNode(node_three);
            linked_list.Display();

            Node node_four = new Node(21);
            linked_list.AppendNode(node_four);
            linked_list.Display();

            Node node_five = new Node(25);
            linked_list.AddNodeatStart(node_five);
            linked_list.Display();
        }
    }
}
