using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Program
    {
        class Mammal//포유류
        {
            public string Name { get; set; }

            public void Breathe()
            {
                Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
            }

            public virtual void Move()//자식이 부모의 메서드를 사용할 수 있게 가상으로 조정해주는 것이다.
            {
                Console.WriteLine($"{this.Name}이(가) 이동한다.");
            }
        }
        class Dog : Mammal
        {
            /* public void Move()
             {
                 Console.WriteLine($"{this.Name}이(가) 네발로 달린다.");
             }*/
            public override void Move()//오버라이드는 부모의 메서드를 돌린다. 자식클래스에 맞게 돌린다. override=위에 있는 것을 타겠다. 부모 메서드를 이용하겠다. 근데 못 이용하니까 가상으로 그 메서드를 이용할 건데 이때 선언해주는 키워드가 virtual이다.
                //override를 통해서 얻는 효과는 부모의 해당 메서드를 여러 자식 클래스가 각자의 기능에 맞게 사용하는 것이다.
            {
                base.Move();// 부모에 있는 Move 실행
                Console.WriteLine($"{ this.Name}이(가) 네발로 달린다.");//+alpha 실행
            }//부모의 무브도 같이 한다. 즉 개가 움직이는 것을 모든 포유류가 움직이는 것을 보는 것이다.
        }

        class Whale : Mammal//고래
        {
            public void Move()//부모의 메서드를 재정의
            {
                Console.WriteLine($"{this.Name}이(가) 헤엄친다");
            }
        }
        static void Main(string[] args)
        {
            Dog poppi = new Dog();
            poppi.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();
        }
    }
}
