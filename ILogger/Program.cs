using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//요약하자면 인터페이스는 기능들의 집합물이다.
namespace ILogger
{  //인터페이스 작업을 할 때, 구현하고자 하는 기능을 미리 설계해놓고 클래스에서 구현하는 가? 그렇다. 선언을 하고 시작한다.
   //각 클래스의 메서드들 중에서 구현하고자 기능들을 취사선택해서 사용할 때, 쓰는가? 아니라. 인터페이스에서 구현하겠다고 선언을하고 클래스에서 만들어서 구현한다.
   //다중상속이 안된다는 말은 하위클래스 여러 개를 부모클래스로 올릴 수 없기 때문에 발생하는 문제를 일컫는 말이다.
    interface ILogger//인터페이스는 기능성의 집합체 그리고 클래스의 내용을 가져다 쓰는 것을 구현이라고 한다. 사용한다.
        //왜 구현이라고 표현하냐면 메서드를 클래스에서 정의하기 때문이다. 인터페이스가 컴파일 관계성보다 기능을 우선시 하기 때문에 발생한 강력하고 유익한 성능이다.
    {
        void WriteLog(string message);//여기서 기능을 구현하겠다고 선언하고 클래스를 만들어서 구현하는 것이다.
    }
    //인터페이스에서 기능을 구현하겠다고 선언하고, 인터페이스를 상속받는 클래스에서 그 기능을 할당하는 가? 
    class ConsoleLogger : ILogger//ILogger의 인터페이스를 상속하겠다.
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattableLogger : ILogger//이건 상속이다. 부모 인터페이스를 위에서는 구현하고 아래에서는 상속받았다. 인터페이스랑 상속은 다른 거다.
        //상위 인터페이스를 하위인터페이스에서 쓸 수 있다. 선언 내용만 더 추가해 주는 것이다.
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}/{message}");
            
        }
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}/{message}");
        }
    }
    class Program//기능이 집적화된 인터페이스를 사용해서 코드를 덜 적고, 다중상속 문제를 해결해줘서 효율적으로 작업하겠다.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그 메시지");

            IFormattableLogger logger2 = new ConsoleFormatLogger();//해당 인터페이스가 할당된 할당자를 초기화 함. 형변환
            //일반화 된 기능을 사용하겠다고 선언하는 것이다. 인터페이스에서 하위클래스로의 형변환을 통해서 기능을 보다 더 일반적으로 타겟팅해서 사용하겠다는 의미이다.
            logger2.WriteLog("{0}*{1}={2}",3,4,12);//IFormattableLogger.WriteLog(format, args);오늘 날자를 설정해주면서 부가적으로 다른 기능까지 실현하겠다.
            //인터페이스를 사용하면 프로그램 내에서 기능의 Join이 가능해진다.
            //근데 이거 알고리즘 무조건 해야 한다. 
        } 
    }
}
//코드를 읽으면서 참조 방향을 유추하는 것도 알고리즘의 일종이다. 즉, 알고리즘을 잘 알 수록 상위 클래스의 프로그래머가 될 가능성이 높아진다.
//자료구조와 관련이 있을 것이다. 이렇게 인터페이스를 쓰면 sql에서 index를 쓰는 것과 유사한 효과를 낼 것이다.
// 이거 알고리즘임 백타