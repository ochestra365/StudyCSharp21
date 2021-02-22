using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04app
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = 378497398;
            if (values % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }
            if(values%3==0)
            {
                Console.WriteLine("3의 배수입니다.");
            }
            else
            {
                Console.WriteLine("3의 배수가 아닙니다.");
            }
        }
    }
}
