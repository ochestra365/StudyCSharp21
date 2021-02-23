using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] sources = { 1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("For문");
            for (int i = 0; i < sources.Length; i++)//i는 인덱스 값이라고 부른다.
            {
                Console.WriteLine($"sources[{i}]={sources[i]}");
            }

            //foreach
            Console.WriteLine("Foreach문");
            var idx = 0;
            foreach (var item in sources)//item은 지역변수에만 쓸 수 있다.  var item은 int다. 배열의 값을 참조하는 것이다. 배열이나 컬렉션 밖에 안된다. 제일 많이 쓴다.
            {
                Console.WriteLine($"sources[{idx++}]={item}");
            }

            foreach (var item in sources)//item은 지역변수에만 쓸 수 있다.  var item은 int다. 배열의 값을 참조하는 것이다. 배열이나 컬렉션 밖에 안된다. 제일 많이 쓴다.
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine($"3의 배수{item}");
                }
                else
                    continue;
            }
        }
    }
}
