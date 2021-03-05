using System;
using System.Threading;

namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }

        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");//지금현재 스레드의 ID를 표기한다.
                    Count--;
                    Thread.Sleep(10);//0.01초에 걸친 스레드 동작
                }
                Console.WriteLine($"Count:{Count}");//0
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외발생 : {ex.Message}");
            }
        }
    }
    //SideTask클래스는 메서드 연산을 통해 스레드의 작동을 시각적으로 확인하기 위해 코딩한 것이다.
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false;// 이 스레드가 종료되기 전까지는 프로세스가 끝나지 않음.
            //true인 경우, 백그라운드 스레드가 돌고 있는 상태에도 메인스레드가 끝나면 백그라운드 스레드도 같이 종료.
            SideTask tast2 = new SideTask(200);
            Thread th2 = new Thread(tast2.CountDown);//기본값 IsBackground false

            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();

            Thread.Sleep(100);//

            Console.WriteLine("인터럽트");
            th2.Interrupt();
            //Console.WriteLine("임의종료!");
            //th.Abort();

            Console.WriteLine("종료대기");//카운트다운 중간에 표시
            th.Join();
            th2.Join();

            Console.WriteLine("스레드/프로세스 종료");
        }
    }
}
//흐름이 조각 나 있어서 그렇다. 일요일에 코드 쭉 보면서 복습할 것.
//프로세스 내에 다중스레드가 존재할 수 있다. 각 스레드들은 프로세스에 할당된 자원들을 사용한다. 
//이 때, 스레드의 값 조정(비트나 쉬프트 연산자)을 통해 시간을 조정할 수 있고, 스레드들의 프로세스 자원점유의 충돌을 개발자가 제어할 수 있다.
//어떤 스레드가 어떤 상황에서 우선순위를 가져야 하는 지는 개발자가 알고리즘과 자료구조 학습을 통해 알 수 있다.
//코딩하는 거야 반복숙달하면 알아서 될 것이고, 중요한 건 로직처리의 과정을 이해하는 것이다.
//스레드는 자원할당 시간의 최소단위를 의미한다. 시간이라는 매개변수를 통해 우선순위를 정량화시켜서 프로세스 안의 각 스레드 자원점유를 계량할 수 있게 하는 것이다.
//현대 컴퓨터는 코어가 여러 개라 한 프로세스 안에 여러 스레드를 가질 수 있다고 한다.
