using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent 
    {
        protected string Name;//Alt+Enter를 눌러서 접근생성자를 쉽게 만들어 줌.@@ 클래스의 속성을 public으로 설정하는 것은 매우 좋지 않다. Core개발자나 해커들에게 엄청난 위협이 된다.@@@
        //sql서버에서 도메인 설정을 하는 것과 같은 것이다. 초기 디폴트 설정 범위를 넘어선 값들을 입력하게 되면 문제가 크게 발생하는 것이다.
        //다른 메서드 형태로 처리할 수 있어야 한다. 즉 속성을 숨겨서 보안을 더할 필요성이 있다는 것이다.

        public Parent(string Name)//부모를 말할 때, ##Super##라고 한다. 즉 상위의 객체라는 의미이다. 혹은 Base(기반)이라고 부른다. 두 키워드는 상위 객체에 하위 객체가 종속됨을 의미한다.
        {
            this.Name = Name;//Name 속성을 초기화해준다.
            Console.WriteLine($"{this.Name}.Parent()");//현재 클래스의 Name의 Parent를 생성했다.
        }

        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");//특성이 이름밖에 없다.
        }
        //기본 생성자를 아예 안 썼기 때문에 많은 것들을 할 수 있다.
    }

    class Child : Parent//자식클래스이다.
    {
        public String Color;//색상

        public Child(string Name) : base(Name)//child 생성자가 만들어지면 부모에서 실행하겠다는 의미이다. Base는 부모의 생성자를 먼저 실행하고 자식의 생성자를 나중에 실행하겠다는 의미이다.
        {
            Console.WriteLine($"{this.Name}.Child");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");//부모 클래스가 접근제한이 걸려있어 할 수가 없다. 함부로 외부에서 속성값을 마구잡이로 변경할 수 없도록 해야 함.
        }
    }//부모에 있는 string : Name을 물려받기 때문에 자식 클래스에서 쓸 수 있다.

    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");//p를 Parent 클래스로 선언하고 새로운 Parent를 할당한다.(Parent값을 초기화한다.)
            p.ParentMethod();//부모클래스 메서드를 실행한다.

            //모든 것들은 최상위 객체를 상속 받도록 되어 있기 때문에 따로 써주진 않았다.
            Child c = new Child("자식");
            c.ParentMethod();//부모의 메서드를 실행
            c.ChildMethod();//자식의 메서드를 실행, 자식 클래스는 부모에 없는 것들을 새로 쓸 수 있다. 기능이 더 많다. 즉, 버전업된 클래스를 관리하는 것이다.
            //실무에서는 상속을 이용해서 버전업을 이뤄낸다. 즉, 기존 프로그램의 정합성을 해치지 않고, 기능이 추가된 솔루션을 사용자에게 제시할 수 있는 것이다.
        }
    }
}
//~child Parent는 소멸자이다.(소멸할 때는 자식 부터 소멸되고 부모가 소멸된다. 그 이유는 부모가 소멸되면, 자식이 참조할 내용이 없어져 다른 클래스에도 지대한 영향을 미치기 때문이다.)