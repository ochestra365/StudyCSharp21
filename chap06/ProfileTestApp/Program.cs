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

            /*PrintProfile(phone: "010-2222-2222", name: "홍길동");
            PrintProfile(name: "홍길순", phone: "010-2222-8888");*/
            PrintProfile("최백호","010-8878-47949");
        }

        public static void PrintProfile(string name, string phone="010-7979-7979")//default Parameter should be adujsted ordered by rear array.
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세용");
                return ;//return을 만나는 순간 밑에 아무리 많은 로직이 있든간에 호출한 곳으로 돌아가겠다.
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return;
        }
    }
}
