using System;

namespace DataStructure
{
    internal class Node
    {
        private int data;
        private Node prev;
        private Node next;

        public Node(){
            data = -1;
            prev = null;
            next = null;
        }

        public Node(int _data){
            data = _data;
            prev = null;
            next = null;
        }

         internal int Data
        {
            get {return data;}
            set {data = value;} //{get; set;}
        }

        internal Node Prev
        {
            get{return prev;}
            set{prev = value;}
        }

        internal Node Next
        {
            get{return next;}
            set{next = value;}
        }
    } 
}
