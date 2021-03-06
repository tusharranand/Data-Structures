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

            Node node_six = new Node(26);
            linked_list.Display();
            Console.Write("Enter the previous value: ");
            int Prev_Data = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the next value: ");
            int Next_Data = Convert.ToInt32(Console.ReadLine());
            linked_list.AddSpecific(Prev_Data, Next_Data, node_six);
            linked_list.Display();

            linked_list.Display();
            Console.Write("Enter the previous value of the one you want to delete: ");
            Prev_Data = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the the next value of the one you want to delete: ");
            Next_Data = Convert.ToInt32(Console.ReadLine());
            linked_list.DeleteSpecific(Prev_Data, Next_Data);
            linked_list.Display();

        }
    }
}