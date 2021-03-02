using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyApp
{
    class Program
    {
    

        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");
                string temp = Console.ReadLine();//string으로 입력받는다.
                int divisor = int.Parse(temp);

                Console.Write("피제수를 입력하세요");
                temp = Console.ReadLine();
                int dividend = int.Parse(temp);

                Console.WriteLine($"{divisor}/{dividend}={Divide(divisor, dividend)}");//24/6=4
            }
            catch (NotImplementedException ex)//변수영역 초과
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            catch(FormatException ex)//입력값 초과
            {
                Console.WriteLine($"입력값 예외!!: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("예외발생 유무와 상관없이 늘 실행! try문 리소스 해제");
            }
        }
        //간단하지만 중요한 부분이다. 이것도 알고리즘이다. 개발자가 코딩하면서 본인도 모르게 생긴 논리적 오류를 구조적으로 미리 예견해서 예외처리를 해줘야
        //프로그래밍이 완벽해지기 때문이다.
        private static object Divide(int divisor, int dividend)
        {
            Console.WriteLine("나누기 시작");
            if (dividend == 0) throw new DivideByZeroException("피제수가 0이 입력되었습니다.");
            return divisor / dividend;
        }
    }
    //exception으로 예외처리해놓고 나중에 상세하게 예외구분을 나누면 되는 것이다.
}