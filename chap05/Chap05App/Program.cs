using System;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)//굉장히 많이 쓰는 구문이다.
        {
            while(true)//어떤 템플릿이라고 생각하면 된다. 프로그램이 종료되지 않게 계속 돌아가는 시스템 환경을 구성하는 것이다.
            {
                Console.Write("수를 입력하세요 : ");//콘솔창에서 표기되는 문자열.
                string line = Console.ReadLine();//콘솔에서 입력값으로 변수에 넣습니다.

                if (line == "quit") break;//quit 입력하면 프로그램 종료.

                int number = 0;
                int.TryParse(line, out number);//sql서버에서 out으로 사용함. 매개변수를 출력으로 쓴다. 숫자가 아니면 파스를 빠져 나간다.
                //라인값이 변환이 되지 않은 값이면 여기에 0을 집어 넣어 준다.->데이터 형식이 int여야 한다.
                //Console.WriteLine(number);
                //todo 아래 로직을 수정하세요.
                if(number>0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");
                }
                else
                {
                    Console.WriteLine("0보다 작은수");
                }
                //todo 마지막
            }
            Console.WriteLine("계산종료");
        }
    }
}
