using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PrintProfile("성명건", "010-545-848");
            Program.PrintProfile(null, "010-1111-2222");
        }

        public static void PrintProfile(string name, string phone)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세용");
                return;//return을 만나는 순간 밑에 아무리 많은 로직이 있든간에 호출한 곳으로 돌아가겠다.
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return;
        }
    }
}
