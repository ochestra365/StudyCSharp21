using System;

namespace OverloadTestApp//객체 상속에서 overriding과는 다른 것이다. 같은 이름의 메서드를 한 번 더 쓰는 것이다.
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 4);//재공학을 하려면 빨간 밑줄에서 Alt+Enter를 눌러서 따로 메서드를 만들어 준다.
            Console.WriteLine($"3 + 4={x}");

            float y = Calculator.Plus(3.14f, 5.6f);//int Type은 계산기 메서드가 돌아가므로 float는 다른 타입이라 돌아가지 않아서 새로 만들어 줘야 한다.
            Console.WriteLine($"3.14+5.6={y}");

            Console.WriteLine($"3.14+5.6={Calculator.Plus(3.14 , 5.6)}");//float랑 double차이다. 컴파일러가 구분을 할 수 없기 때문에 변수뒤에 f를 붙여 줘야 한다.
            //이것을 처리할 수 있는 메서드가 없다. 재공학시 문제점이 있다. 
            Console.WriteLine($"3.14+5.6={Calculator.Plus(3.14, "5")}");

            int z = Calculator.Plus(7, 8, 9);

            int total = 0;
            total = Sum(1, 2, 4,5);//가변길이 매개변수가 사용되는 코드.
            Console.WriteLine($"합계는{total}");//디버깅확인.
        }

        private static int Sum(params int[] args)//가변길이 매개변수--배열을 사용해서 개발자의 노고를 덜어내어 주겠다. 실무에서 이런 것들을 쓰면 요구사항 변경에 쉽게 대처가능.
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }
        
        private static int Plus(int v1, int v2, int v3)//참조가 적힌 것은 누군가가 이 메서드를 한 번이라도 호출했고, 그 위치를 알려주는 것이다. 참조가 0이면 지워도 된다.
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static double Plus(double v1, string v2)//스트링과 더블
        {
            double.TryParse(v2, out double p2);//변수 타입을 설정해주면 선언과 동시에 할당
            double result = v1 + p2;
            return result;
        }

        private static double Plus(double v1, double v2)//위에서 변수 타입선언을 해주지 않으니 컴파일러가 뭔지를 알 수 가 없어서 object라는 타입으로 설정했다. 이게 boxing이다.
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)//throw new NotImplementedException(); 일단 예외 던져서 코드 구문상에서 빨간 줄 없애주겠다.
        {
            int result = v1 + v2;
            return result;//return은 점프문이다.
        }
        //매개변수를 받는 것들이 위에 있기 때문에 형변환 형식의 메서드를 쓸 수 없다. 그 이유는 컴파일러가 구분할 수 없기 때문이다.
        //연산자 메서드는 중복으로 제한없이 만들 수 있다.
    }
}
