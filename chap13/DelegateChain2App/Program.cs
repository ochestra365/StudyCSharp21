using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereIsAFire(string location);// 대리자 선언, 클래스안에 대리자가 들어가도 상과없다?

        static void Call119(string location)
        {
            Console.WriteLine($"불났다! 꺼줘! 여기는 {location}");
        }
        static void ShotOut(string location)
        {
            Console.WriteLine($"불이야! {location}에서 도망쳐!");
        }
        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 탈출합시다!");
        }
        //대리자를 쓰면 한꺼번에 여러가지 메서드를 꺼내서 쓸 수 있다.
        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(ShotOut);
            fire += new ThereIsAFire(Call119);//기본 문법
            fire += Escape;//약식문법

            fire("문현동 전광빌라");//이벤트 순서도 사용자가 지정한 순서대로 실행한다.
        }
    }
}
