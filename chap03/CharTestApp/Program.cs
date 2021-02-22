using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자-->키워드를 변수명으로 사용할 수 없다. 파란색은 전부 키워드이다. 예약어등으로 볼 수 있다.
            char ch1 = 'T', ch2 = '\t', ch3 = '\n', ch4 = '0';
            //escape문자 \t는 텝이다.\n은 출력 시 밑으로 떨어지게 하는 것이다. 콘솔에서 글자 표현할 때 필요한 것이다.
            Console.WriteLine($"{ch1},{ch2},{ch3},{ch4}");
            char ch5 = '\\';
            Console.WriteLine($"{ch5}");
            //원화표시하는 것은 ch5이다.

            //문자열
            string str1 = "\tHello, \nWorld!";
           //Console.WriteLine(str1);
            Console.WriteLine($"{str1}");

            bool isCorrect = false;//true
            if(isCorrect)
            {
                Console.WriteLine("참입니다.");
            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }
            //화면에 찍힐 때, 글자로 바뀌어서 찍힌다는 것이다.
            Console.WriteLine(isCorrect);
        }
    }
}
