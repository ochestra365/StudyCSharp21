using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = {11,21,33,45,56 };//5개 int 배열
            int[] target = new int[source.Length];//5개 int 배열 초기화, 위의 소스값만 바뀌면 아래의 소스값도 알아서 바뀐다. 똑같은 사이즈로 배열을 만든다.ㄴ

            CopyArray(source, target);// int 배열 복사
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }//원본은 놔두고 복사한 것만 가지고 작업을 하느 경우가 많다.

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("string 배열 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.5f, 6.6f };
            float[] target3 = new float[source3.Length];
            CopyArray(source3, target3);
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }
            //계속 끊임 없이 만들어야 하는 것이다. 같은 로직인데, 데이터 타입에 따라서 여러 가지 메서드를 생성한다는 점이 너무 이상했다.
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(string[] source2, string[] target2)
        {
            for (int i = 0; i < source2.Length; i++)
            {
                target2[i] = source2[i];
            }
        }

        private static void CopyArray(float[] source3, float[] target3)
        {
            for (int i = 0; i < source3.Length; i++)
            {
                target3[i] = source3[i];
            }
        }
    }
}
