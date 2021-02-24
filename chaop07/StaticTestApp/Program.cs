using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number;//인력
        public float fnum;//마찰력

        public static float ProcSomethig()// 걷는다.
        {
            Console.WriteLine($"{number},뭔가를 한다.");
            return 1.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            TestClass.number = 10;
            aCls.fnum = 3.25f;
            
            TestClass bCls = new TestClass();
            bCls.fnum = 4.87f;
            //인스턴스에 관여된 것.
            TestClass.ProcSomethig();
        }
    }
}
