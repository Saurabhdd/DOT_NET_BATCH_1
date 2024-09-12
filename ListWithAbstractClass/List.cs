using System;

namespace DataStructure
{
    internal abstract class List
    {
        protected Node headNode;

        #region Constructor

        protected List()
        {
            headNode = new Node();
            headNode.prev = headNode;
            headNode.next = headNode;
        }
        #endregion

        #region abstractMethods
        protected abstract void InsertAtBegin(int data);
        protected abstract void InsertAtEnd(int data);
        protected abstract void InsertAfter(int data, int ref);
        protected abstract void InsertBefore(int data, int ref);
        protected abstract int RemoveEnd();
        protected abstract int RemoveBegin();
        protected abstract void Remove(int data);

        #endregion

        #region PublicMethods
        public void PrintList()
        {

        }

        public int Length()
        {

        }

        public bool Find()
        {

        }

        #endregion

    }
}