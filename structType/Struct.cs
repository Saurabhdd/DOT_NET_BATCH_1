using System;


namespace StructEx
{
    struct Student
    {
        public string Name;
        public int id;
        public string address;

        public Student(string _name)
        {
            Name = _name;
            id = 10;
            address = "dfd";
        }

        public override string ToString()
        {
            return "this is struct";
        }

    }
}