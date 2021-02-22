using System;

namespace VarTestApp
{
    class Program
    {
        static float i = 100.5f;

        static void Main(string[] args)
        {
            var i = 100;
            Console.WriteLine($"정수값은 {i}입니다.");//var는 지역변수안에서만 사용할 수 있다. 전역변수로 사용할 수 없다.
        }
    }
}
