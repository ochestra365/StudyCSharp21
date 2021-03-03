using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }//엔티티를 클래스로 보느냐 혹은 DB로 보느냐의 차이이다.
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };//10개 배열
            //LINQ 안 쓰는 방식
            /*List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            result.Sort();*/

            var result = from item in numbers
                         where item % 2 == 0
                         orderby item ascending
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 }
            };//바로 값을 넣어서 하는 초기화로 바꿔준다.

            List<Product> products = new List<Product>//PK, FK쓰지 않고 같은 데이터를 써준다.
            {
                new Product(){Title="비트", Star="정우성"},
                new Product(){Title="CF 다수", Star="김태희"},
                new Product(){Title="아이리스", Star="김태희"},
                new Product(){Title="모래시계", Star="고현정"},
                new Product(){Title="솔로예찬", Star="이문세"},
            };

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending
                              select new {
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name},{item.Height}cm, {item.InchHeight}inch");
            }

            var resProfiles2 = from item in profiles
                               where item.Height < 175
                               orderby item.Height ascending
                               select new { item.Name }; 

            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }

            //group by
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height<175 into g
                               select new { 
                                    GroupKey = g.Key, Items = g
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"{item.Name},{item.Height}cm");
                }
            }

            //inner Join, MSSQL SERVER의 내용과 같다.
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star//기본키와 외래키의 일치화.
                               select new
                               {
                                   name = p.Name,
                                   Work = d.Title,
                                   Height = p.Height
                               };
            Console.WriteLine("내부조인 결과");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름:{item.name}, 작품 : {item.Work}, 키: {item.Height}");
            }

            //Outer Join, MSSQL SERVER의 내용과 같다.
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps//기본키와 외래키의 일치화.
                               from d2 in ps.DefaultIfEmpty(new Product { Title = "작품없음."})
                               select new
                               {
                                   name = p.Name,
                                   Work = d2.Title,
                                   Height = p.Height
                               };
            Console.WriteLine("외부조인 결과");
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름:{item.name}, 작품 : {item.Work}, 키: {item.Height}");
            }
        }
    }
}
//LINQ가 편할 때가 있고 혹은 위에 방식이 편할 때가 있다. 같은 일을 하는 데, 프로그래밍의 결과가 똑같이 나오면 된다. 
//LINQ는 데이터를 가상 릴레이션에 삽입하고 조건식 검색을 시행하기 위해 사용된다. 여기서는 값이지만 응용에 따라서는 대리인을 활용하여 로직을 호출하는 형식도 가능할 거 같다.
//현대의 프로그래밍은 로직 뿐만이 아니라 데이터의 저장까지 지원하고 있다. 물리적 DB의 구현까지 담당하고 있다. 다른 점은 무결성이 보장되느냐 아니냐의 차이이다.
//join 쿼리를 가지고 필요한 데이터를 가지고 출력할 수도 있고, DB에서 처리해서 결과를 가지고 올 수 있느냐? 테이블 데이터를 모두 다 가지고 와서 가지고 오느냐의 차이다.
//쿼리에서 다 가지고 오는 것보다 필요한 부분만 추출해서 가져오는 것이 비주얼 스튜디오의 메모리 과부하를 줄일 수 있다. 왜냐하면 작업속도의 저하가 발생하기 때문이다.
//DB와 다른 점은 DB는 직접 데이터베이스상에서 자료를 정제하여 추출하는 데 비해, 이 방식은 메모리를 따로 할당하고, 저장공간까지 따로 확보해둬야 하는 문제가 발생한다.
//따라서 DB에서 쿼리문을 날려서 결과값만 추출해서 작업을 시행하는 것이 컴파일러의 과부하를 막을 수 있다. LINQ를 쓰지 않으면 코딩량이 많아진다.