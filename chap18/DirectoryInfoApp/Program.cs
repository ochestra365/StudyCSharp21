using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = @"C:\Program Files\Bandizip";//폴더 정보 확인 경로
            Console.WriteLine($"{strDir} 디렉토리 정보");
            /*var directories = (from dir in Directory.GetDirectories(strDir)//하위디렉토리 다 가져 오겠따.
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attribute = info.Attributes
                               }).ToList();*/
            /*foreach (var item in directories)
            {
                Console.WriteLine($"{item.Name}:{item.Attribute}");
            }*/
            var directories = new DirectoryInfo(strDir).GetDirectories();
            foreach (var item in directories)//폴더의 나열이 배열이라는 의미이다. 로직을 이해해야 알고리즘을 시행할 수 있다.
            {
                Console.WriteLine($"{item.Name} : {item.Attributes}");
            }
            Console.WriteLine($"{strDir} 내 파일 정보");
            var files = new DirectoryInfo(strDir).GetFiles();
            foreach (var item in files)//폴더의 나열이 배열이라는 의미이다. 로직을 이해해야 알고리즘을 시행할 수 있다.
            {
                Console.WriteLine($"{item.Name} : {item.Attributes} :{(item.Length/1024):#,###}KB: {item.Extension}");//extension은 확장자라는 의미이다.
            }
        }
    }
}
