using System;



namespace CallingNamespace
{
    class CallingClass
    {
        public static void Main(string[] args)
        {
            CalledNamespace.calledClass cc = new CalledNamespace.calledClass();
            cc.fun1();
        }
    }
}