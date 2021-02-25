using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{
    class Myclass
    {
        private int iValue;//0~120값만 입력받는 멤버변수. 정보의 오염을 막는 것이다.
        private double dZeta;
        private float fPng;
        private string strval;
        private int inCode;

        public int IValue
        {
            get//멤버변수 속성을 가져온다.
            {
                return this.iValue;//멤버 변수를 호출한다.
            }
            set//멤버변수를 value로 설정한다.
            {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;
                this.iValue = value;
            }
        }

        public Myclass(int value)
        {
            iValue = IValue;
        }

       /* public int GetValue()
        {
            return this.value;
        }

        public void SetValue(int value)
        {
            if (value < 0)
            {
                this.value = 0;
            }
            else if (value > 120)
            {
                this.value = 120;
            }
            else
            {
                this.value = value;
            }
        }*/

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.iValue}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass myClass = new Myclass(1200);
            myClass.PrintValue();

            myClass.IValue = 1200;
            myClass.PrintValue();

            Console.WriteLine($"현재 온도는 {myClass.IValue}입니다.");
        }
    }
}
