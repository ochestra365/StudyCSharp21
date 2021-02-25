using System;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        public virtual void Initialize()//virtual: 자식클래스에서 재정의하겠다고 선언
        {
            Console.WriteLine("ArmorSuite 초기화!");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();//부모 클래스의 메서드를 사용여부를 선택하는 버튼 역할을 한다.
            Console.WriteLine("리펄서 레이저 장착");
        }
    }

    class WarMachine : ArmorSuite//참조하는 파생클래스에서 기반클래스를 다시 재정의한다. 
    {
        public override void Initialize()//부모의 생성자를 base라고 한다. 기반 클래스의 메소드를 물려받아서 추가 계산을 해주는 것이다.
        {
            //base.Initialize();--> 기반클래스를 초기화해주는 것이다. 이 코드를 시행하면 부모의 메서드를 시행하고 자식의 메서드를 시행하는 것이다.
            Console.WriteLine("ArmorSuite계량 Warmachine 초기화!");
            Console.WriteLine("Double-Barrel 캐논 장착!");
            Console.WriteLine("Micro-Rocket 런처 장착");
        }
        //다른 자식 클래스에는 영향을 미치지 않는다. 메서드는 다수가 존재할 수 있다. 그래서 해당 메서드는 기반 클래스의 메서드를 참조하거나 참조하지 않는 것이다.
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

            Console.WriteLine("IronMan 생산!");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
        }
    }
}
//public sealed void Selame()-->해당 오버라이딩이 문제가 발생할 것으로 예상되는 것으로 sql로 치며 begin tran에 해당하는 듯 하다.
//상위 클래스의 프로그래머가 해당 프로그램의 메서드를 분석하고 제어할 때, 오작동이 발생할 수 있는 것을 보는 것이다.
// 즉, 이 개념을 완벽하게 이해하기 위해서는 알고리즘에 대한 선행 학습및 심화학습이 필수불가결한 것을 알 수 있다.
// 프로그래머는 기능을 구현하고, 그 관계성을 지어주고, 효율성을 강화하는 것이 주된 능력의 속성이다. 이 능력을 개별적으로 분화하여 자기개발하는 것이 좋다.
// 프로그래밍 공리는 엔티티 포인트는 프로그램상에서 단 하나만 존재하는 것이다.