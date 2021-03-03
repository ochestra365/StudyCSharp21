using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\sources\StudyCSharp21\SampleDir\SubFolder\a.dat";//텍스트 파일 생성 위치

            StreamWriter sw = null; 
            try
            {
                sw= new StreamWriter(new FileStream(filePath, FileMode.Create));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일쓰기 예외발생:{ex.Message}");
            }
            finally
            {
                sw.Close();
            }
           
        }
    }
}
