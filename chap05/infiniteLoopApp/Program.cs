using System;

namespace infiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte idx = 0;
            //for (; ; ) //무한루프
            while (true)//무한루프는 컴퓨터 성능을 저하시키기 때문에 최대한 지양해야 한다. 그리고 콘솔에서 작업할 때, 효율성이 높다.
            {
                Console.WriteLine($"idx=={idx++}");
            }
        }
    }
}
