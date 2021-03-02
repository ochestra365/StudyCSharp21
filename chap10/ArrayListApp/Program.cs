using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 80,74,81,90,34});
         /*   array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);*/

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            Console.WriteLine("81위치에 50 추가.");
            foreach (var item in array)//배열은 foreach
            {
                Console.WriteLine($"{item}");
            }
            loc = array.IndexOf(90);
            array.RemoveAt(4);//90 삭제-->위치에 있는 값을 지우는 것이다.

            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
