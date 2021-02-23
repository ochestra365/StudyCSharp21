using System;

namespace StarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("별모양찍기");
            #region 첫번째 별모양
            for (int i = 0; i < 5; i++)//행
            {
                for (int j = 0; j < i + 1; j++)//열
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            #endregion//주석 처리하여 보이지 않게 함.

            #region 두번째 별모양
            for (int i = 0; i < 5; i++)//행
            {
                for (int j = 0; j < 5-i + 1; j++)//열
                {
                    Console.Write(" ");
                }

                for (int j = 0; j< i+1; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("");
            }
            #endregion
            //두번째 별모양 실패...
        }
    }
}
