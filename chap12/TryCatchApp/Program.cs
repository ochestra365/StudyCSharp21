using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int x = 108, y = 0;
            int result = 0;
            //예외는 값을 초기화한 부분에서 발생하지 않는다. 메서드를 돌리는 for구절에서 예외가 발생한다.
            try
            {
                for (int i = 0; i < 5; i++)//index out of range.
                {
                    Console.WriteLine($"{i}번째 값: {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)//모든 C#의 Exeption의 모든 조상은 Exception이다. 그리고 Exception은 object의 자손이다.
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //throw;//break랑 continue배울 때, 요거를 집어 넣어 준다.
            }
            //catch는 오류가 발생했을 때, 어떤 현상을 넣어줄 것이냐를 집어 넣어 주는 구문이다.
            //차이점은 예외에 의한 프로그램 종료가 아니라, 정상적인 프로그램을 유도하는 것이다. 프로그램의 활성이 멈추지 않게 해주는 것이다.

            Console.WriteLine("나머지 일처리 계속");

            
            try
            {
                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (DivideByZeroException ex)//try 구문에서 이 예외처리를 ex로 하겠다!
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch(Exception ex)//예외처리를 뭐할 지 모르겠다고 하면 Exception 처리로 해결하면 된다.
            {
                Console.WriteLine($"예외처리: {ex.Message}");
            }

            Console.WriteLine("나머지 일처리 계속할거임 ㅋ");

            
            //예외처리하지 않으면 프로그램이 비정상적으로 종료되게 되어 사용자의 불편함을 야기한다는 문제점이 있다.

            try
            {
                string strVal = null;
                string splitVal = strVal.Substring(6, 5);
                int idx = strVal.IndexOf("W");//6
                Console.WriteLine($"자른 문자 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있네영. 값을 넣으세여 {ex.Message}");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있네영. 값을 넣으세여 {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"기타 예외발생. {ex.Message}");
            }
            Console.WriteLine("일처리 또 있으어");
            //개발자로써 가장 잘해야 하는 것은 디버깅하고 예외처리를 가장 잘해야 한다. 이것이 가장 중요한 덕목이다. 나머지는 프로그래밍을 하기 위한 기술이다.
            //요건 매너에 해당하는 것이다. 프로그래밍을 얼마나 문제없이 만드는 가가 중요한 것이다.
            //예외를 처리하게 되면 속도가 떨어지게 된다. 그러나 예외를 처리하는 것이 훨씬 중요하다. 5000배 차이가 나게 된다. 다중 try문은 성능의 저하를 가지고 오게 된다.
            //그래서 나는 처리하지 않고 상위의 예외처리에 던져서 해결하려고 한다.
        }
    }
}
