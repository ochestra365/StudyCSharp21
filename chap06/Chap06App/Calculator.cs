using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06App
{
    class Calculator
    {
        static void Main(string[] args)//재공학-->Plus라는 메서드는 없지만, Plus라는 메서드를 만드는 것이다.
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는{result}");
        }
        
        private static int Plus(int p1, int p2)//메서드의 변수 개수와 호출하는 곳에서 변수 개수가 같아야 한다.
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Input : {p1}, {p2}");//초기값에 p1이 대입되고 1값에 p2가 대입된다. $표시를 쓴다. 자바도 있다.
            int result = p1 + p2;//결과값이 result에 할당됨.
            Console.WriteLine($"Output : {result}");//초기값에 p1이 대입되고 1값에 p2가 대입된다. $표시를 쓴다. 자바도 있다.
            return result;//결과값 호출을 한 곳으로 돌아간다.
        }
    }
}
