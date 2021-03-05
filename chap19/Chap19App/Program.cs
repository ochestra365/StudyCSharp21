using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void DoSomeThing()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(1000);//1000이 1초이다.(ms 밀리세컨드) 1/100초 동안 멈춤.
            }
        }

        static void SomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(1000);//1000이 1초이다.(ms 밀리세컨드) 1/100초 동안 멈춤.
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoSomeThing));
            Thread thread1 = new Thread(SomethingHappened);
            //선언은 거의 예외가 발생하지 않는다.

            Console.WriteLine("스레드 시작");
            thread.Start();
            thread1.Start();
            try
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main Thread : {i}");
                    Thread.Sleep(10);

                    if (i == 10)
                        thread.Abort();
                }
                thread.Abort();
                Console.WriteLine("스레드 종료 대기");
                Console.WriteLine("프로세스 종료");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();
            }
        }
    }
}
//cpu가 프로세스에 올라온 메모리를 따로 쪼개서 연산하는 것이다. 성능적으로 더 일을 잘 처리한다. 위 과정은 어떤 기능을 수행하기 보다는
//cpu의 동작원리를 물리적으로 확인하기 위해 보는 것이다. ==확인한 실험 결과는 cpu가 프로세스에 스레드를 나눠서 동시에 연산한다는 것이다.
//이는 교착상태를 해소할 뿐더러, 선점형 멀티태스킹을 통해 효율적인 프로세스 시행에 적합한 실행 배치순서를 놓을 근거가 될 수 있다.
//하나의 자원에 어떤 스레드가 사용하고 있는데, 다른 스레드가 접근해서 사용하려고 하면 문제가 발생한다.
//스레드당 할당 시간을 달리 둬서 cpu자원 점유 병목을 해소하는 거 같다.