using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before Swap{x},{y}");

            Program.Swap(ref x, ref y);//정렬의 기반 x의 메모리 주소를 복사하란 의미이다.(ref)-->call by reference-->주소를 참조한다.
            Console.WriteLine($"After Swap{x},{y}");
        }

        private static void Swap(ref int p1, ref int p2)//주소값을 넘겨주는 것이다. 즉, 주소의 경로를 설정해주는 것이다. 정렬할 때 쓰는 것이다.
        {
            int temp = p1;//temp=47
            p1 = p2;//p1=5,p2=5
            p2 = temp;//p2=47 메모리 할당과 메모리 주소는 다른 것이다. 그리고 p1과 p2는 선언과 동시에 할당된 정수값이다. 그래서 멤버변수로써 따로 속성값을 써주지 않아도 된다.
        }
    }
}
