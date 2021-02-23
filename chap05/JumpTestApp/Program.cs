using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) break;//continue;//한줄일때는 인라인으로 적으면 된다.

                Console.WriteLine(i);
            }
        }
    }
}
