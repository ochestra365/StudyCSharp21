using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)//한 메서드 안에 들어가는 변수를 지역변수라 하고, 전체 클래스에 영향을 주는 변수를 전역변수라고 한다.
        {
            Console.WriteLine("숫자더하기");
            var p2 = 456;
            Console.WriteLine(123 + p2);//579
            Console.WriteLine("123" + p2);//123456
            Console.WriteLine("123" + "456");//123456
            Console.WriteLine($"123{p2}");//123456 C# 6.0 이후 문자열 만드는 방법.

            // 관계연산자
            int a = 30, b = 30;
            Console.WriteLine(a < b);//False
            Console.WriteLine(a > b);//False
            Console.WriteLine(a <= b);//True
            Console.WriteLine(a == b); //True
            Console.WriteLine(a != b); //False

            //논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10 > 9 && a > 0);//True
            Console.WriteLine(a > b || b > 0);//True->많이 사용되지 않는다.
            Console.WriteLine(!(a < b));//True

            // 조건(삼항)연산자 단항if문을 대체할 수 있다.
            int c = 30;
            string result =c ==30? "삼십":"삼십아님";
         /*   if (a == 30)
                result = "삼십";
            else
                result = "삼십아님";*/
            Console.WriteLine(result);
            Console.WriteLine("null 병합 연산자");
            int? d = null;//null은 출력할 때는 콘솔화면에 나오지 않는다. 그러나 숫자값을 쓰기 위해서 만들었다. 
            Console.WriteLine($"{d??0}");//0으로 대체하는 것이다.
        }
    }
}
