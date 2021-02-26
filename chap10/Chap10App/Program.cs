using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{

    class Test
    {}
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 }; //new int[5];//var arry도 된다. int의 대괄호 까지가 배열을 나타내는 데이터타입이다.
           /* array[0] = 80;
            array[1] = 74;
            array[2] = 84;
            array[3] = 90;
            array[4] = 34;*/
           //파란색은 데이터 타입, 
           for(int i = 0; i < array.Length; i++)
           {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
           }

            Console.WriteLine("크기변경");
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length-1; i >= idx; i--)
            {
                array[i] = array[i - 1];
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            array[idx] = 50;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            /*Console.WriteLine($"Type of array: {array.GetType()}");//array의 데이터타입을 묻는 것이다.
            Console.WriteLine($"Base Type of array : {array.GetType().BaseType}");//array 클래스를 가져와서 베이스 타입은 이런거다.
            *//*var idx = 0;//var자체가 여러가지 변수명을 지정할 수 있는 데이터타입을 의미한다.
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }*//*
            Console.WriteLine("정렬 후");//오름차순 정렬

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Array.Reverse(array);//내림차순 정렬
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx= Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100);
            Console.WriteLine($"34의 인덱스 : {idx}");//그 값이 없다. -1이다. 에러란(못찾았다.) 데이터가 없다. 데이터가 없다는 것을 확인했다. 그래서 null이 아니다.

            Array.Clear(array, 3, 2);//0으로 지워진다. 이것을 쓰는 이유는 데이터 디폴트 값은 지워주면서 해당 메서드 부분에서 필요한 데이터만 추출하기 위해서이다.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }*/
        }//equals와 object와 같은 것들이 모든 키워드에 자동으로 커밋되어 있다.
        //한 프로그램을 구동하는 데, 알고리즘은 무한이다. 거기서 개발자가 가장 효율적이다고 생각하는 알고리즘을 택해서 프로그래밍을 해야 한다.
    }
}
