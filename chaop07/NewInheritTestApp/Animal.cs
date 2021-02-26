using System;
using System.Collections.Generic;
using System.Text;
// 해당 cpu 자원을 사용한다고 선언.

namespace NewInheritTestApp
{
    class Animal // 동물 클래스
    {
        public string Name { get; set; }//property
        public int Age { get; set; }

        public void Breath()
        {
            Console.WriteLine($"{this.Name}이 숨을 쉽니다.");  
        }
    }
}
