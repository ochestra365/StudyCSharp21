using System;

namespace intConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int값은 { inCastVal}");

            inCastVal += 5;
            short shCastVal = (short)inCastVal;//2바이트에 4바이트를 넣으려고 하니 되지 않는다.overflow
            Console.WriteLine($"short값 변환한 int값은 { shCastVal}");//실무에서 형변환 값이 들어가게 되면 오류가 발생한 거 같다.

            float flVal = 3.141582f;
            inCastVal = (int)flVal;
            Console.WriteLine($"float값 변환한 int값은 { inCastVal}");//정수값만 표현됨.
            double dlVal = inCastVal;//3
            Console.WriteLine($"float값 변환한 double값은 { inCastVal}");//객체지향 C#에서는 메서드라고 부른다.

            object obj = 20; //Boxing
            int inUnboxingVal = (int)obj;//object가 최상위라서 바뀔 수 없다. 가장 큰 값을 int에 넣으려고 하니 들어가지 않는다. unboxing으로 이 문제를 해결해준다.

            string strVal = "200";
            int result = int.Parse(strVal) * 3;//문자로 적힌 숫자를 정수로 바꿔주는 것이다. 형변환임.
            Console.WriteLine($"200*3={result}");
        }
    }
}
