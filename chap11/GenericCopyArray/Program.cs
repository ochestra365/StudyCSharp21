using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };//5개 int 배열
            int[] target = new int[source.Length];//5개 int 배열 초기화, 위의 소스값만 바뀌면 아래의 소스값도 알아서 바뀐다. 똑같은 사이즈로 배열을 만든다.ㄴ

            CopyArray(source, target);// int 배열 복사
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("string 배열 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
        }

        private static void CopyArray<T>(T[] source, T[] target)//T는 Generic으로 표현된다.
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        // 데이터타입과 무관하게 같은 로직은 해당 메서드로 전부 처리된다.
    }
}
