using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{
    class Program
    {
        class Mathz
        {
            //여러 행위(기능 : 메서드) 들이 많다.
            public int Plus(int a, int b)
            {
                //...
                return 1;
            }
            public void PrintEven(int val)
            {
                if(val%2==0)
                {
                    Console.WriteLine($"값: {val}");
                }
            }
        }
        
        static void Main(string[] args)//가장 메인으로 쓰는 클래스인데, 프로그램이 돌아가는 한 계속 운영되는 프로젝트내의 최고위 클래스이다.

        {
            //...

            Mathz mathz = new Mathz();

            int x;

            //...
            x = 6;
            /*if(x%2==0)
            {
                Console.WriteLine($"x의 값 : {x}");
            }*/
            mathz.PrintEven(x);

            //...

            x = 10;
            /* if (x % 2 == 0)
             { 
                 Console.WriteLine($"x의 값 : {x}");
             }*/
            mathz.PrintEven(x);
        }
    }
}
