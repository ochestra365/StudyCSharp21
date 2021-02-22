using System;

namespace ConsTestApp
{
    class Program
    {
        enum Season//변수명이라기보다는 하나의 시즌으로 존재한다.
        {
            Spring,//값은 0로 존재함.
            Summer,//값은 1로 존재함.
            Fall,//값은 2로 존재함.
            Winter//값은 3으로 존재함.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double pi = 3.141592;
            Console.WriteLine($"원주율의 값은 {pi}");
            //pi=98.22->시작부터 에러가 난다.

            Season mySeason = (Season)3;//Season.Summer;
            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            int a=0;
            Console.WriteLine($"a는 {a}");

            int? b=null;
            Console.WriteLine($"b는 {b}");
        }
    }
}
