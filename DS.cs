using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var newLinkedList = new DataStructuresPractice.linkedList();

            newLinkedList.add("Robert");
            newLinkedList.add("Clark");
            newLinkedList.add("is");
            newLinkedList.add("Awesome");
            newLinkedList.add("!");

            //newLinkedList.reverseLinkedList();
            //newLinkedList.printAllNodes();
            newLinkedList.printWithRecusion(newLinkedList.getHead());
            Console.ReadLine();
        }
    }

    class linkedList
    {
        private Node head;

        public Node getHead()
        {
            return head;
        }

        public void add(object data)
        {
            if (head != null)
            {
                var toAdd = new Node();
                toAdd.data = data;
                toAdd.next = null;

                var last = getLastNode().next = toAdd;
            }
            else
            {
                head = new Node();
                head.data = data;
            }
        }
        public void printAllNodes()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
        public void printWithRecusion(Node nodey)
        {
            if (nodey != null)
            {
                Console.Write(nodey.data + " ");
                printWithRecusion(nodey.next);
            }
        }
        public void reverseLinkedList()
        {
            Node newNode = null;
            var current = head;
            Node old = null;

            while (current != null) 
            {
                newNode = current.next;
                current.next = old;
                old = current;
                current = newNode;

            }
            head = old;
        }

        private Node getLastNode()
        {
            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            return current;
        }
    }

    class Node
    {
        public Node next;
        public Object data;
    }

    
}
