using System;

namespace ObjectClassEx
{
    class Student
    {

        private int id;

        public Student(int _id)
        {
            id = _id;
        }

        public override bool Equals(Object obj)
        {
            var item = obj as Student;
            if(item == null)
                return false;
            return this.id.Equals(item.id);
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}