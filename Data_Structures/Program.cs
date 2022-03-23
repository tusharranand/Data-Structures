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

            Node node4 = new Node(21);
            linked_list.AppendNode(node4);
            linked_list.Display();

            Node node5 = new Node(25);
            linked_list.AddNodeatStart(node5);
            linked_list.Display();

            linked_list.Delete_First();
            linked_list.Display();

            linked_list.Delete_Last();
            linked_list.Display();

            Console.Write("Enter the number you want to find: ");
            int Data = Convert.ToInt32(Console.ReadLine());
            bool Result = linked_list.Search(Data);
            if (Result)
                Console.WriteLine("Data exists in the linked list.\n");
            else
                Console.WriteLine("Data does not exist in the linked list.\n");

            Node node6 = new Node(26);
            linked_list.Display();
            Console.Write("Pick a value to add the new node after: ");
            Data = Convert.ToInt32(Console.ReadLine());
            linked_list.AddSpecific(Data, node6);
            linked_list.Display();

            linked_list.Display();
            Console.Write("Pick a value you want to delete: ");
            Data = Convert.ToInt32(Console.ReadLine());
            linked_list.DeleteSpecific(Data);
            linked_list.Display();

        }
    }
}