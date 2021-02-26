using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal//포유류
    {
        public string Name { get; set; }
         public void Nurse()
         {
            Console.WriteLine($"{this.Name}을(를) 키우다.");
         }
    }

    class Dog : Mammal//강아지
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!!");
        }
    }

    class Cat : Mammal//고양이
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 야옹!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog 떼구 = new Dog();
            떼구.Name = "떼구";
            떼구.Nurse();
            떼구.Bark();

            Cat 래기 = new Cat();
            래기.Name = "래기";
            래기.Nurse();
            래기.Meow();

            if(래기 is Mammal)//래기는 포유류인가?
            {
                //값형식은 long= int값
                Mammal mammal1 = 래기 as Mammal;//참조형식은 as를 써서 형변환-->래기는 고양이 였지만 포유류로 바꿔서 이제 못짖는다. 왜냐하면 얘가 고양이인지 모르기 때문이다.
                mammal1.Nurse();
                //mamml1.Bark();//error
            }

            if(mammal is Dog)//만약 부모클래스가 하위클래스의 일반화 기능을 담당한다면 그 기능을 사용한다는 것이다.
            {
                // 떼구 = mammal;//떼구는 포유류보다 작은 강아지 개념에 속한다. 얘는 강아지 이다. 즉, 강아지 전체를 포유류라고 볼 수 없는 것이다. 
                떼구 = mammal as Dog;//컴파일러에게 해당 경우가 발생했을 경우를 알려준다.-->형변환
                떼구.Nurse();
                떼구.Bark();
            }
            //메인메서드에서 해당 기능을 활성화 시켜주는 것은 static void main이 프로그램의 엔티티포인트와 엔드포인트를 담당하는 것을 미루어 볼때
            //클래스 기능을 지속적으로 프로그램에서 활성화 시켜준다는 것을 가르쳐 주는 것이다.
            //객체는 눈에 보이지 않아도 추상적인 것을 의미하는 것이다.
            //코드 구조 정렬법: 클래스 밑에 각 기능을 넣는다.
            //떼구를 Null로 할 경우, 짖거나 키울 수 없다. 현실세계로 쉽게 예를 들자면 얘가 집나가서 뒤졌는 지 살았는 지 모르는데 밥을 준비해주거나 짖어라고 할 수 없기 때문이다.
            //떼구가 이해를 도와줬으니까 나중에 고향집가면 고기 챙겨줄 것.
            //프로그래밍언어로 하자면 해당 객체의 값이 존재하지 않기 때문에 타 클래스를 참조하여 컴파일할 수 없다고 볼 수 있겠다.
            //F9로 디버그 포인트를 잡아주고, ctrl+d+i로 디버그 확인창을 활성화한다.
            //f11을 눌러서 코드가 컴파일러에서 진행되는 것을 살펴본다.(초급 개발자가 가장 실력을 빨리 키울 수 있는 방법이다.)
        }
    }
}
