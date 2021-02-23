using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)//Main Method
        {
            int a = 22, b=3;
            int val = 0;
            int rem = 0;
            Divide(a, b, out val, out rem);//입력 매개변수와 출력 매개변수의 차이를 알려줘야 한다.

            Console.WriteLine($"{a},{b}:a/b={val},a%b={rem}");//제대로 프로그램이 돌아가는 지 콘솔창에 출력해서 확인하는 작업으로 마무리 작업에 속한다.

            bool isSucceed = int.TryParse("1000.74", out int result);
            Console.WriteLine($"변환 result값은 {result}, 변환 결과 {isSucceed}");
            
        }

        static void Divide(int a, int b, out int quotient, out int remainder)//입력 매개변수와 출력 매개변수(out)
        {
            quotient = a / b;
            remainder = a % b;
        }
        //리턴값을 여러 개 돌려줄 수 있다. out을 ref로 바꿔줘도 된다. 똑같이 결과값은 나온다.
    }
}
