using System;

namespace DataStructure
{
    public class Node
    {
        public int data;
        public Node prev;
        public  Node next;

        #region Constructors
        public Node()
        {
            data = -1;
            prev = null;
            next = null;
        }
        
        public Node(int _data)
        {
            data = _data;
            prev = null;
            next = null;
        }

        #endregion


    }
}