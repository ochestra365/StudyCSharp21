using System;

namespace Chap18APp
{
    class StringApp
    {
        string temp2 = "Global Variable String";//var 불가
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            // 기본선언
            string message1 = null;
            Console.WriteLine($"null문자열: {message1}");//초기화하지 않은 값은 에러가 발생한다. meesage1에 할당되는 메모리를 비워줘서 쓸 수 있게 해줘야 한다.

            string message2 = String.Empty;
            Console.WriteLine($"빈값문자열 : {message2}");
            string oldPath = "C:\\Program Files\\Bandizip";//폴더, 파일 경로--역슬래쉬는 특수문자이기 때문에 두번 써주어야 한다.
            string newPath = @"C:\Program Files\Bandizip";//앞의 골뱅이를 쓰면서 특수문자가 아닌 경로를 드러내는 문자로 나타내기로 결정한 것이다.

            String greeting = "Hello World!";// string
            Console.WriteLine(greeting);
            var temp1 = "Local Variable String";//지역변수에만 쓸 수 있다.(한 클래스 안에서만 사용할 수 있다.)
            char[] letters = { 'H', 'e' };
            string he = new string(letters);
            Console.WriteLine($"{he}");//배열로 문자열을 형성하는 것.

            string s1 = "Hello";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");//오류는 없으나 경고가 5개가 뜬다. 경고에 대해서 무시해도 된다. 할당되고 사용되지 않으면 경고가 발생한다.

            string s3 = s1;
            string s4 = s3;
            s3 += "World!";
            Console.WriteLine($"{s4}");

            string row = "Row1\r\nRow2\r\nRow3";//standard
            Console.Write(row);
            Console.WriteLine("-----");
            string row2 = "Row11\nRow22\nRow33";//가장 짧음
            Console.Write(row2);

            Console.WriteLine();
            Console.Write("Row111" + Environment.NewLine+"Row222"+Environment.NewLine+"Row333");

            string oldline = "Test" +//+는 문자열을 연결하는 것.
                "Test2" +
                "Test3";
            string multiline = @"New Test
            These are multiline
            end.";
            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multiline);

            Console.WriteLine($"\U0001F47D");//유니코드를 잘 쓰면 이모지를 다 쓸 수 있다.

            var book = (lastName: "박", firtName: "상현", title: "이것이 C#이다.", company: "한빛미디어",
                releaseDate: "2018 - 07 - 01", price: 30000, page: 812);

            Console.WriteLine($"{book.lastName}{book.firtName} 저자의 {book.title}({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 DD일")} 출간, 페이지수{book.page},금액:{book.price}");
            Console.WriteLine($"페이지 수{book.page}, 금액: {book.price:#,###}원");


            Console.WriteLine("문자열 조작(함수사용)");
            string s5 = "Visual C# Express";//총 19자리
            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim());//스페이스(여백) 삭제
            var s6 = s5.Trim();//총 17자리 "Visual C# Express"

            Console.WriteLine(s6.Substring(7));
            Console.WriteLine(s6.Substring(7, 2));//7번째 글자부터 2번째 까지 출력하겠다.

            Console.WriteLine(s6.Replace("C#","Basic"));//C#글자를 검색해서 Basic으로 바꾸겠다.
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "Basic"));//C#글자를 검색해서 Basic으로 바꾸겠다. c#에서 작업할때 가장 많이 쓰이는 것이 문자열 조작이다.

            Console.WriteLine(s6.IndexOf("C"));//7
            Console.WriteLine(s6.Length);//17
            Console.WriteLine(s6.ToUpper());
            Console.WriteLine(s6.ToLower());

            // null 문자열 빈 문자열
            Console.WriteLine("null/빈문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr);//hello출력
            Console.WriteLine(nullstr == emptystr);//False가 나온다. 비어있는 것과 존재하지 않는 다는 것은 다르다.

            try
            {
                Console.WriteLine(nullstr.Equals(emptystr));
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외발생: {ex.Message}");
            }

            Console.WriteLine(emptystr.Length);//0
            Console.WriteLine(nullstr.Length);//오류발생==null로 초기화되었다. 초기화는 했지만 쓸 수 있는 것이 아무것도 없다.
        }
    }
}
