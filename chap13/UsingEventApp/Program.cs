using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message);//메시지를 받아서 처리하는 대리자.
    //(시그니처도 같아야 한다.) 이는 메인메서드에 해당하는 로직이 같아야 함을 의미한다.
    class CustomNotifier//이벤트 선언, 사용하는 객체
    {
        public event EventHandler SomethingHappened;//객체에는 하나의 속성이 있다.

        public void Dosomething(int number)//각 이벤트다.//각 기능을 의미하네.. 기능을 시행하는 로직.
        {
            int temp = number % 10;// 15 & 10 = 5 % 3= 2

            if (temp!=0 && temp%3==0)//3,6,9로 떨어지는 값
            {
                SomethingHappened($"{number} : 짝!");//일을 하는 로직이 없다.
            }

        }
    }
    class Program
    {
        /// <summary>
        /// 이벤트가 발생했을 때 실행되는 메서드(이벤트 핸들러)
        /// </summary>
        /// <param name="message"></param>
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);//대신 호출하는 대리자를 사용함.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");//Break Point는 여기서 잡고 로직돌아가는 것을 디버깅 잡는다.
            CustomNotifier notifier = new CustomNotifier();//하나의 커스텀 객체이다.//초기화
            notifier.SomethingHappened += new EventHandler(MyHandler);//만든 my handler, 콜백 호출자.

            for (int i = 0; i < 100; i++)//i파라미터를 이용하여 해당 메서드를 원하는 만큼 시행하겠다. 사용자가 만든 이벤트 메서드를 연결해주는 것이다.
            {
                notifier.Dosomething(i);
            }
        }
    }
}
//대리인은 사용자가 아닌 대리인이 대신 메서드를 실행해주는 것을 의미한다. 왜 절차가 하나 더 늘어나서 좋은 효과가 있나?
//발생하는 사건을 대리인이 참조하는 클래스에 넣어주고, 발생하는 사건이 일어나는 조건을 사용자가 메인메서드에서 시행해준다.
//발생시킬 코드를 대리인이 참조하는 클래스에 넣어주고, 발생하는 사건이 일어나는 조건 코딩을 사용자가 메인메서드에서 작성해준다.
//즉, 사용자가 기능을 발생시킬 로직을 설정하고, 필요한 메서드를 따로 불러서 코딩 기능을 실현하는 것을 의미한다.
//기능을 시행하는 로직을 대리자가 콜백해주고, 해당 조건이 일어나는 정의역을 메인메서드에서 사용자가 설정해준다.
//물론 상속식으로, 혹은 인터페이스로 구현할 수 도 있지만 여기서는 사용자가 아무것도 하지 않은 NULL상태의 호환을 위해서 이벤트를 사용한다.
//윈폼을 위한 것이다. 즉, 어떤 메서드를 직접 호출하는 것이 아니라 이벤트가 발생하면 사용자가 호출하지 않더라도 이벤트가 활성화되게 하기 위함이다.
//그래야 사용자 편의성이 향상되기 때문이다.
//로직이 돌아가는 것을 보니, 대리인은 이벤트에 대한 기능만을 담당하는 것을 알 수 있다. 즉, 메인 메서드에서 해당 상황에 적합한 이벤트를 따로 값처럼 선언해주는 것이다.
//즉, 이벤트 로직을 값으로 만들어서 사용자의 행위에 해당하는 로직에 넣어서 컴파일 처리를 하고 있음을 알 수 있었다.
//1. 이벤트 로직을 값으로 만듦 2. 그 값을 사용자의 행위에 해당하는 로직에 대입함. 3. 결과값을 산출 따라서 메인 로직에 이벤트 로직을 넣기 위한 솔루션이 대리인이라고 볼 수 있다.