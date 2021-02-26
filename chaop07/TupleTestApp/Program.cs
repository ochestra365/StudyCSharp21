using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "성명건", "010-2487-4456","부산시 해운대구", true);
            var tuple2 = (IDX: 2, name: "홍길동", Phone: "010-5455-4156", Address: "경남 창원시 의창구", Marrige: false);

            Console.WriteLine($"{tuple1.Item1}/{tuple1.Item2}/{tuple1.Item3}/{tuple1.Item4}/{tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1}/{tuple2.Item2}/{tuple2.Item3}/{tuple2.Item4}/{tuple2.Item5}");
            Console.WriteLine($"{tuple2.IDX}/{tuple2.name}/{tuple2.Phone}/{tuple2.Address}/{tuple2.Marrige}");

            tuple2.Address = "부산 영도구";
        }
    }
}
