using System;

namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y);//대리자 선언
    class Program
    {
        static void Plus(int a, int b){Console.WriteLine($"a+b= {a + b}");}
        static void Minus(int a, int b) { Console.WriteLine($"a-b= {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a*b= {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a/b= {a / b}"); }


        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!");
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5);
            //대리자를 쓰게 되니 메서드를 값 형식으로 사용할 수 있다. 모든 메서드를 다 시행할 수 있다. 메서드를 연산자로 추가할 수 있다.
            //하나의 호출로 여러가지 메서드를 연산자를 통해 호출할 수 있다.
            /* Plus(10, 5);
             Minus(10, 5);
             Multiple(10, 5);
             Divide(10, 5);*/
            //대리자를 쓰게 되면 4가지를 다 쓸 수 있다. 미리 사전에 시그니처 세팅을 해야 한다.

            allCalc -= Multiple;
            // 해당 메서드 조합에서 제거한다. 시그니처를 같게 해주는 것 만으로 논리적 사고를 대폭 줄일 수 있는 효과가 있다.
            //같은 프로그램이라도 성능의 차이를 유도할 수 있다. 왜냐하면 로직 연산보다 값 형식이 훨씬 성능향상(연산시간 절약)에 효과적이기 때문이다.
            //윈폼에서 어떠한 이벤트를 만들때, 이벤트를 처리하기 위해서 이것들이 사용되었다. 사용자가 아무것도 시행하지 않을 때, 사용자와의 호환도 고려한 개념이다. 
            //null값이 메서드상에 존재하게 되는 데, null은 로직 처리에 부하를 야기할 수 있다. 따라서 값형식으로 치환함으로써 로직 처리를 보다 깔끔하게 하는 것이다.
            //null은 값 형식이기 때문에 컴파일러가 존재하지 않은 정보에 의한 프로그램 종료를 컴파일 할 수 있게 한다.
        }
    }
}
