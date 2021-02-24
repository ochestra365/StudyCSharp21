using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        private int temp=5;//물온도

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의온도가 높아. 59로 ㄱㄱ");
                this.temp = 59;
                return;
            }
            else
            {
                this.temp = temp;//private는 클래스 안이라서 참조가 된다. 그래서 this가능(참조가능)
            }
            this.temp = temp;
        }

        public int GetTemp()
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