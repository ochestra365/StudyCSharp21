using System;
using System.Threading;

namespace ThreadStateApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            Console.WriteLine($"{state,-16}:{(int)state}");//스레드의 상태를 드러내고 그 결과값을 암시적으로 int값을 줘서 각 스레드마다 어떤 값을 가지고 있는 지 보려는 것.
            //스레드 값을 알 수 있으면 프로그램 오류 발생시 실행 순서나 연산 속도에 개발자가 차이를 두어 물리적인 충돌을 막을 수 있다.
        }
        static void Main(string[] args)
        {
            PrintState(ThreadState.Running);
            PrintState(ThreadState.StopRequested);
            PrintState(ThreadState.SuspendRequested);
            PrintState(ThreadState.Suspended);
            PrintState(ThreadState.Stopped);
            PrintState(ThreadState.Unstarted);
            PrintState(ThreadState.WaitSleepJoin);
            PrintState(ThreadState.AbortRequested);
            PrintState(ThreadState.Aborted);
        }
    }
}
//네임스페이스만 다르게 쓰면 같은 이름의 클래스를 여러 개 쓸 수 있다.
//값이 2진수로 나오는 이유는 비트나 쉬프트를 이용해서 값을 변동시키기 위해서이다. 즉, 값을 통해 로직처리를 위해서이다.