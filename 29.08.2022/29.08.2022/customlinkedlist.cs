using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08._2022
{
    class SinglyLinkedListNodeDemo
    {
        int data;
        internal SinglyLinkedListNodeDemo next;

        public SinglyLinkedListNodeDemo(int d)
        {
            data = d;
            next = null;
        }
    }

    class DoublyLinkedListNodeDemo
    {
        internal int data;
        internal DoublyLinkedListNodeDemo head;
        internal DoublyLinkedListNodeDemo prev;
        internal DoublyLinkedListNodeDemo next;

        public DoublyLinkedListNodeDemo(int d)
        {
            data = d;
            prev = null;
            next = null;
        }

    }

     class UserSingleLinkedList
    {
        SinglyLinkedListNodeDemo head;


        public void InsertNodeInFront(UserSingleLinkedList list, int dataToInsert)
        {
            SinglyLinkedListNodeDemo node = new SinglyLinkedListNodeDemo(dataToInsert);
            node.next = list.head;
            list.head = node;

        }

        public void InsertAtTheEnd(UserSingleLinkedList list, int dataToInsert)
        {
            SinglyLinkedListNodeDemo node = new SinglyLinkedListNodeDemo(dataToInsert);
            if (list.head == null)
            {
                list.head = node;
                return;
            }
            SinglyLinkedListNodeDemo node1 = GetLastNode(list);
            node1.next = node;

        }

        private SinglyLinkedListNodeDemo GetLastNode(UserSingleLinkedList list)
        {
            SinglyLinkedListNodeDemo tempnode = list.head;
            while (tempnode != null)
            {
                tempnode = tempnode.next;
            }
            return tempnode;
        }

        public void InsertAfter(SinglyLinkedListNodeDemo prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("This cannot be null");
                return;

            }
            SinglyLinkedListNodeDemo newnode = new SinglyLinkedListNodeDemo(data);
            newnode.next = prevNode.next;
            prevNode.next = newnode;
        }
    }

    class UserDoubleLinkedList
    {
        internal DoublyLinkedListNodeDemo head;
        void InsertNodeInFront(UserDoubleLinkedList list, int dataToInsert)
        {
            DoublyLinkedListNodeDemo node = new DoublyLinkedListNodeDemo(dataToInsert);
            node.next = list.head;
            list.head = node;
            node.prev = null;
            if (list.head != null)
            {
                list.head.prev = node;
            }


        }



        void InsertAfter(DoublyLinkedListNodeDemo prevnode, int data)
        {
            if (prevnode == null)
            {
                Console.WriteLine("cannot be null");
                return;

            }


            DoublyLinkedListNodeDemo newnode = new DoublyLinkedListNodeDemo(data);
            newnode.next = prevnode.next;
            prevnode.next = newnode;
            newnode.prev = prevnode;
            if (newnode.next != null)
            {
                newnode.next.prev = newnode;
            }

        }
        void InsertAtTheEnd(DoublyLinkedListNodeDemo list, int dataToInsert)
        {
            DoublyLinkedListNodeDemo node = new DoublyLinkedListNodeDemo(dataToInsert);
            if (list.head == null)
            {
                list.prev = null;
                list.head = node;
                return;
            }
            DoublyLinkedListNodeDemo node1 = GetLastNode(list);
            node1.next = node;
            node.prev = node1;

        }

        private DoublyLinkedListNodeDemo GetLastNode(DoublyLinkedListNodeDemo list)
        {
            DoublyLinkedListNodeDemo tempnode = list.head;
            while (tempnode != null)
            {
                tempnode = tempnode.next;

            }
            return tempnode;
        }
    }
}