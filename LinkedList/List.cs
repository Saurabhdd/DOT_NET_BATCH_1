using System;

namespace DataStructure
{
    internal class List
    {
        private Node headNode;

        public List()
        {
            headNode = new Node();
            headNode.Next = headNode;
            headNode.Prev = headNode;
        }

        public void InsertAtBegin(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.Next);
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.Prev, newNode, headNode);
        }

        public void InsertAtPos(int data, int pos)
        {
            Node newNode = new Node(data);
            int counter = 0;
            Node tempNode;

            tempNode = headNode.Next;
            while(tempNode != headNode && counter <= pos)
            {
                counter += 1;
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode.Prev, newNode, tempNode);
        }

        public int RemoveAtBegin()
        {
            int removedData;

            removedData = headNode.Next.Data;
            GenericDelete(headNode.Next);
            return removedData;
        }

        private static void GenericInsert(Node start, Node mid, Node end)
        {
            start.Next = mid;
            mid.Next = end;
            end.Prev = mid;
            mid.Prev = start;
        }

        private static void GenericDelete(Node deleteNode)
        {
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;
        }

        public void PrintList()
        {
            Node tempNode = headNode.Next;

            while(tempNode != headNode)
            {
                Console.Write("[" + tempNode.Data + "]->");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("[END]");
        }
    }
}