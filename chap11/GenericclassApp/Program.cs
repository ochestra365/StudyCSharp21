using System;

namespace GenericclassApp
{
    class Array_Generic<T>
    {
        private T[] array;//T라는 값을 지정해주고 같은 로직에서는 데이터 타입에 상관없이 컴파일하겠다는 의미이다.
        //컴파일이란 고급언어를 기계어로 변환시켜주는 것을 말한다.

        public Array_Generic()
        {
            array = new T[10];
        }

        public T GetElement(int index) { return array[index]; }

        public int Length
        {
            get { return array.Length;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();
           
        }
    }
}
