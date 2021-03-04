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
                sw= new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate));
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Hello, World!");
                sw.WriteLine($"uint.MaxValue = {uint.MaxValue}");
                sw.WriteLine("안녕하세요!!");
                sw.WriteLine($"double.MaxValue={double.MaxValue}");

                Console.WriteLine("파일생성");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일쓰기 예외발생:{ex.Message}");
            }
            finally
            {
              
            }

            StreamReader sr = null;
            sr = new StreamReader(new FileStream(filePath, FileMode.Open));
            Console.WriteLine($"File size : {sr.BaseStream.Length}bytes");

            while(sr.EndOfStream==false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
