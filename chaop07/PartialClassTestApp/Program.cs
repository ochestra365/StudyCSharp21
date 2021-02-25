using System;

namespace PartialClassTestApp
{
    class Program
    {
        partial class myclass
        {
            public void Method3() { Console.WriteLine("Method1"); }
            public void Method4() { Console.WriteLine("Method1"); }
        }
        static void Main(string[] args)
        {
            myclass _class = new myclass();
            _class.Method1();//??????????
            _class.Method2();//??????????
            _class.Method3();
            _class.Method4();

        }
    }
}
