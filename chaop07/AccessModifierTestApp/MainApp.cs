using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler//보일러의 가동원리를 모듈화한 것이다.
    {
        internal int temp=5;//물온도, 나중에 미니프로젝트에서 실측한 정보가 멤버변수로 설정되는 것을 유추할 수 있다.//public, internal, protected

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의온도가 불안정해. 59로 ㄱㄱ");
                this.temp = 59;
                return;
            }
            else
            {
                this.temp = temp;//private는 클래스 안이라서 참조가 된다. 그래서 this가능(참조가능)
            }
            this.temp = temp;
        }

        public int GetTemp()// 물온도를 사용자가 건들지 못하게 메서드화함. 은닉성/캡슐화/보안강화/해킹방지.
        {
            return this.temp;
        }

        public void TurnOnTheBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }

        public void TurnoffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
        //정보는 무조건 숨겨야 한다. 캡슐화(은닉성)을 의미한다.
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            var currTemp = kitturami.GetTemp();
            kitturami.GetTemp();//private이후 보안을 강화한 온도 검색
            Console.WriteLine($"현재 온도는 {currTemp}℃");
            kitturami.SetTemp(40);
            kitturami.TurnOnTheBoiler();
            kitturami.SetTemp(59);

            if(kitturami.GetTemp() >=59)
            {
                kitturami.TurnoffBoiler();
            }
            /*kitturami.TurnOnTheBoiler();
            kitturami.TurnoffBoiler();
            Console.WriteLine($"현재 온도는 {kitturami.temp}");
            kitturami.temp = 70;
            kitturami.TurnoffBoiler();*/
        }
    }
}
//모든 속성을 public으로 하니까 원하는 대로 정보를 변환할 수 있다. 해킹의 위험성이 있다. 정보 은닉(캡슐화)이다.
//사용자가 임의의 값을 넣어서 실제 현상에서 일어날 수 있는 참사를 막을 수 있다.
//메인 클래스 메인메서드는 다른 클래스를 매개변수(파라미터)로써 사용한다고 볼 수 있는가? 그렇다고 볼 수 있을 것이다.(물어보니까 아니다-- 그거는 컴파일러에서 설정된 것이다. 실행과 부모 조상 릴레이션은 다른 것이다.)
//클래스의 생성은 부모자식의 @@@@@상속관계가 아니라 사용관계(실행)@@@@@이다.-->이게 내가 헷갈렸던 부분이다.
//internal은 같은 어쎔블리에 적용이 가능하다.
//아무 값이나 걸 수 없게, 도메인을 한정짓기 위해, settemp public을 해준다. 하나의 안전장치를 줄 수 있는 것이다. 부모에게 물려받은 상속 조건들은 자식에서 사용할 수 있다는 것이
//protected이다. 프로그램 시작점이 컴파일러에서 설정되어 있는 것은 함부로 설정해서 시작할 수 없다.(엔트리 포인트는 모든 프로그램에서 한번밖에 없다.)