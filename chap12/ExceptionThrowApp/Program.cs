using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionThrowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomething(13);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            //throw;는 어디론가 보낸다는 점프구문이다.
        }

        private static void DoSomething(int v)
        {
                if ( v <= 10)
                {
                    Console.WriteLine($"v^2={v /0}");
                }
                else
                {
                    throw new Exception("10보다 큰 값은 계산할 수 없습니다.");//원래 있던 예외가 아니다. 나머지 값들은 예외로 만들겠다는 의미이다.
                //예외가 발생하면 나를 호출한 곳에서 문제를 처리하겠다! 라는 의미이다. 사용자가 예외를 만들어서 사용하는 것이다.
                }
            //이중 트라이문 예외가 발생했을 때, 성능을 발생하는 경우이다.
        }
    }
}
