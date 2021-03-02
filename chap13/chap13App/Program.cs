using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap13App
{
    delegate int MyDelegate(int a, int b);//대리자. 대신 호출한다. 호출할 메서드의 시그니처와 같아야 한다.
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);//메서드인데 괄호가 없다. 왜 없지? 이것도 형변환의 일종인가? 새롭게 초기화 시켜준다.
            Console.WriteLine($"result = {Callback(3,4)}");

            var result = calc.Plus(3, 4);
            Console.WriteLine($"result = {result}");
            
            Callback = new MyDelegate(calc.Minus);//클래스의 마이너스 메서드를 이용할 것이다.
            Console.WriteLine($"result= {Callback(5, 2)}");

            //대리자를 통해 메서드의 기능 선택이 가능하다.
            //인스턴스가 클래스를 대신한다. 혹은 위임한다. 클래스가 아니라 대리자이다. 서로 계수가 다른 것을 인지한다.
            //대리자에서 호출하고자 하는 메서드는 시그니처가 완전히 같아야 한다.
            //값이 아닌 코드 자체를 매개변수로 넘기고 싶을 때, 사용한다.
        }
    }
}
