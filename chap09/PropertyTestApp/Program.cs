﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    //생일정보 클래스
    class BirthdayInfo
    {
        // private로 한 클래스 안에서만 사용 가능한 정보들이 있다. 왜냐하면 함부로 건들면 안되는 정보이기 때문이다.
        //이것을 제한접근자 public으로 메인 메서드에서 참조할 수 있게 하려면 메서드가 필요하다. 형식과 선언을 해주고 안에 코드블럭안에 속성들을 기입해준다.
        // 프로퍼티는 메인메서드에서 클래스를 참조하는 형식이 아닌 하나의 시스템 변수처럼 사용할 수 있게 함으로써, 코딩량을 줄이느 것이다.
        //멤버변수 보안 걸어주기.
        //사용자가 건드려선 안되는 정보를 보호해주기 위해서 private를 써준다.
        private string name;
        private DateTime birthday;
        public string Name//프로퍼티는 메서드를 하나의 인스턴스로 여기는 것이다.
        {
            get { return this.name; }//리턴은 결과값을 반환하는 것이기 때문에 파라미터가 따로 필요없다. 왜냐하면 this를 통해 멤버변수를 쓰겠다는 거니까.
            set { this.name = value; }//그러나 세팅은 다르다. 세팅은 결과값을 반환하지 않는 void가 숨겨져 있다. 그런데 메서드가 아니기 때문에 데이터 타입을 적을 수 없으니
            // value로 놓는 것이다. value는 컴파일러에서 특정 로직을 타고 합리적인 데이터타입을 선언하기 때문이다.
            //-->파라미터로써 name을 받아서 쓰는 메서드와는 달리 이번에는 파라미터가 없다. 그래서 value를 쓴다. (할당할 파라미터가 없다.)
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }//-->파라미터가 없으니 속성을 알 수가 없어서 value를 쓴다.
        }
        //호출할 메서드 만들기
        public string GetName()
        {
            return this.name;//경로 호출 및 반환
        }
        public void SetName(string name)//문자열 속성의 변수 x를 넣어주겠다.
        {
            this.name = name;//경로호출하여 할당. 파라미터로써 name을 받아서 쓴다.
        }

        public DateTime GetBirthDay()
        {
            return this.birthday;//경로 호출 및 반환
        }

        public void SetBirthday(DateTime birthday)//void를 쓰는 게 해당 메서드의 사이클이 완료될 때까지
        {
            this.birthday = birthday;//경로 호출하여 할당. 이름을 같게 쓰는 것은 속성 값을 그대로 가져오기 위함인데, 보안이 걸려 있어서 해주는 것이다.(은닉성, 캡슐화)
        }
        //set 메서드에 void를 끼워주는 이유는 사용자가 필요할 때, 자료를 꺼내 쓰기 위해서 결과값을 반환시키지 않는 의도인 것이다.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반 get/set 메서드 사용");
            BirthdayInfo info = new BirthdayInfo();// 초기화
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));
            //정보를 세팅해주고
            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthDay()}");
            //암호화된 정보를 호출 및 반환하는 것이다.
            Console.WriteLine("프로퍼티 사용");

            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순";
            info2.Birthday = new DateTime(1992, 3, 16);
            Console.WriteLine($"이름 : {info2.Name}");
            Console.WriteLine($"생일 : {info2.Birthday}");
            //프로퍼티를 쓰면 멤버변수에 접근한 것처럼 한다. 프로퍼티가 훨씬 코딩량이 줄고 간결하게 쓸 수 있다.
            //분리된 메서드를 가지고 일처리를 하는 것은 비효율적이기 때문에 프로퍼티로 관리하는 것이 간결하고 정확함.
            //프로퍼티를 쓰면 메서드를 호출하는 것이 아니라 하나의 변수처럼 관리할 수 있음.
            //이해하기 어려운 것은 추상성이 높은 학문이기 때문이다. 추상성을 추리하여 자기의 학문으로 만드는 것은 개발자의 노력에 달려 있다.
            //public으로 멤버변수를 설정하면, 메인메서드에서 선언과 할당이 동시에 된다.
            //private로 멤버변수를 설정하면, 메인메서드에서 선언과 할당이 동시에 되지 않는다. 이때, void로 선언을 하고(왜냐하면 결과값이 반환되지 않아야 하니까)
            //return으로써 반환하는 것은 private라는 멤버변수 속성을 지켜주기 위해서이다.
            //컴파일러 에러가 아니라 사용자 에러를 막아주기 위해서 사용하는 것이다.
        }
    }
}
