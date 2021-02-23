using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)//어떤 템플릿이라고 생각하면 된다. 프로그램이 종료되지 않게 계속 돌아가는 시스템 환경을 구성하는 것이다.
            {
                Console.Write("요일을 입력하세요 : ");//콘솔창에서 표기되는 문자열.
                string line = Console.ReadLine();//콘솔에서 입력값으로 변수에 넣습니다.

                if (line == "quit") break;//quit 입력하면 프로그램 종료.

                string day = line;

                switch (day)
                {
                    case "월요일":
                        Console.WriteLine("월요일입니다.");//break도 점프문에 해당한다.
                        break;
                    case "화요일":
                        Console.WriteLine("화요일입니다.");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일입니다.");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일입니다.");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일입니다.");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일입니다.");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일입니다.");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다.");
                        break;

                }

            }
        }
    }
}
