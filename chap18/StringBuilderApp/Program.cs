using System;
using System.Text;
namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello Wolrd!");//시스템 자원을 사용한다.
                                                                 // sb[6] = 'N';//권장 안함.
            sb.Append("My name is d\n");
            sb.Append("I'm dd old\n");
            sb.Append("Book price is 30000 won.");
            sb.Insert(6, "New");
            sb.Replace("Book","시계");
            //Append를 이용하면 특수문자가 그냥 들어가게 된다.
            Console.WriteLine(sb);
        }
    }
}
