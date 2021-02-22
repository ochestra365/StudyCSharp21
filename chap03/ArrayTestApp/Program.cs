using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)//C#에서 대괄호는 기본적으로 배열이다.
        {
            Console.WriteLine("배열테스트!");

            int[] arr = new int[10];//배열 설정.
            for (var i =0; i<arr.Length; i++)//초기값, 조건, 식
            {
                arr[i] = i + 1;
            }
            //함수 선언
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}]값은 {arr[i]}");
            }
            //함수 호출
            /*   arr[0] = 1;
               arr[1] = 2;
               arr[3] = 3; 자동화시켜주는 것이다.*/
        }
    }
}
