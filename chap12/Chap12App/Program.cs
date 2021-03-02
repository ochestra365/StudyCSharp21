using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}번째 값: {arr[i]}");
            }
            //컴퓨터가 비정상적인 상태로 프로그램이 멈춰버린 상태를 오류라고 한다.
            //위의 구문은 문제 없는 구문이나 for문의 배열에 대한 구문에 대한 값이 존재하지 않기 때문에(NULL) 발생하는 것이다.
            //발생할 예외를 처리하지 않으면 CLR이 처리하게 된다.
        }
    }
}
