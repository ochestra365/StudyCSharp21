using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassTestApp
{
    partial class myclass
    {
        public void Method1() { Console.WriteLine("Method1"); }
        public void Method2() { Console.WriteLine("Method1"); }
    }
}
