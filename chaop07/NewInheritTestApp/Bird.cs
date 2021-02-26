using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine($"{this.Name}이 납니다.");
        }
    }
}
