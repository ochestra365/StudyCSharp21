using System;
using System.IO;

namespace GenDirFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = @"D:\sources\StudyCSharp21\SampleDir";//폴더/파일 생성 테스트 폴더
            string strTargetDir = "SubFolder";//생성할 폴더명
            string strTargetFile = "readme.txt";//생성할 파일명

            string targetPath = strDir +"\\"+ strTargetDir;//항상 에러나는 곳. @@@@경로가 없어서 에러가 나버림. 없어서 새로 만들어버림@@@@@@

            if (Directory.Exists(targetPath))
            {
                Console.WriteLine("이미 폴더가 존재합니다.");
            }
            else
            {
                Directory.CreateDirectory(targetPath);
            }

            targetPath += $"\\{strTargetFile}";
            /*if (Directory.Exists(targetPath))
            {
                Console.WriteLine("파일이 존재합니다.");
            }
            else
            {
                File.Create(targetPath).Close();
            }*/
            File.Create(targetPath).Close();
            Console.WriteLine("파일생성성공");
            //같은 이름의 폴더가 있는 지 없는 지도 알아줘야 한다. 예외가 발생하기 때문에 try~catch를 쏴줘야 한다.
        }
    }
}
