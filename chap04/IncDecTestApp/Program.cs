using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result++}");//후치연산, 출력한 이후에 메모리값에 1을 할당함. 어떤 일을 수행한 다음에 마지막으로 1을 증가시키겠다. 전치연산은 그 반대.
        }
    }
}
