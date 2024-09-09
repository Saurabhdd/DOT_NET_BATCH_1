using System;

namespace DataStructure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List list = new List();
            list.InsertAtBegin(10);
            list.InsertAtBegin(20);
            list.InsertAtBegin(30);

            list.PrintList();

            list.InsertAtEnd(40);
            list.PrintList();

            list.InsertAtPos(50, 3);
            
            //list.RemoveAtBegin();
            list.PrintList();
        }
    }
}
