using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08InterfaceTestApp
{
    /*class Riable
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈것.");
        }
    }*/

    interface ICar //차라는 인터페이스는 달리는 것과 타는 것이 필요하다.
    {
        void Run();
        void Ride();
    }

   interface IPlane
    {
        void Fly();
        void Ride();//구현되어 있는 것을 써라는 것이기 때문에 뭘 써도 상관없다.
    }
    //다중상속에서는 Ride때문에 문제가 생김. 왜냐하면 관계성과 방향을 설정해줘야 하기 때문이다.
    class DroneCar : IPlane, ICar//다중상속의 문제를 해결했다. 코드의 기능성을 강화시킨 항목이다.//오버라이드를 할 필요도 없다.
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다");
        }

        public void Ride()
        {
            Console.WriteLine("드론카 달리다");
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
        }
    }
    //Interface의 효과는 업캐스팅, 다운캐스팅과 같은 관계를 생각해주지 않고 기능에 집중할 수 있는 장점이 있다.
    //대신 단점은 코드의 결집성이 커져서 모듈화가 힘든 것이다. 이식성은 강해진다? 약해진다? 약해질 것이다. 왜냐하면 한 솔루션 내에서 참조하는 
    //각 클래스의 멤버변수들이 다 다를 것인데, 인터페이스는 이것들을 참조하기 떄문이다. 위의 예시에서 이를 확인할 수 있다.
    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamcar = new DroneCar();
            dreamcar.Ride();
        }
    }
}
//알고리즘의 공부 필요성이 커지고 있다.