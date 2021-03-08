# _StudyCSharp_

PKNU C_Sharp 학습 리포지터리
----------------
## Basic C# 주소록 생성
목차 <br>
1. 주소록의 기능 생각해보기<br>
2. 주소록의 코드창과 출력화면 생성해보기<br>
3. 학습방향
------------------
## 1. 주소록의 기능 생각해보기
__우리가 평소에 알고 있는 주소록은 무엇일까?__<br>
![네이버주소록](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EB%A1%9D.png)<br> 
위 사진은 네이버의 주소록이다. 주소록의 기능에 대해서 알아보도록 하자!!<br>
### 주소록의 기능은 다음과 같다.<br>
1. 주소의 입력할 수 있어야 한다.
2. 주소를 검색할수 있어야 한다.
3. 주소를 수정할 수 있어야 한다.
4. 주소를 삭제할 수 있어야 한다.<br>
아주 심플하게 살펴 본 기능이다. 콘솔창을 통해서 기능을 심화구현해보자면 데이터 읽고 저장하는 것까지 구현해볼 수 있겠다.<br> 해당 기능을 구현해보도록 할텐데,
콘솔창을 이용해서 해당 기능을 구현해보도록 하자.<br>
tip. 개발하고자 하는 기능이 명확하므로 기능 객체를 먼저 구현하는 것이 유리하다.
--------------
## 2. 주소록의 코드창과 출력화면 생성해보기.
### 코드 정렬
AddressInfo<br>
주소창의 속성 중에서 데이터를 입력하고 저장한다는 프로퍼티를 생성한다.
~~~
namespace AddressBookApp
{
    class AddressInfo//프로퍼티. 각각의 인스턴스에는 다음과 같은 요소들을 가져오고 설정할 수 있다.라는 의미이다. 그리고 이것을 속성화 한 것.
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
//메인 앱에서는 이 속성을 인스턴스에 선언하고 새로이 할당하여 기능을 수행한다.
~~~

AddressManager<br>
주소록의 기능들을 구현한다.
~~~
using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    class AddressManager//메인 프로젝트에서 사용하는 클래스 명과 동일하게 설정해 두어야 한다. 이것도 속성화이다.
    {
        public List<AddressInfo> listAddress;//주소록을 담을 컬렉션, 값들을 담고 있는 속성. 모든 프로젝트에 전역으로 사용할 수 있다.
        //listAddress라는 인스턴스에 AddressInfo라는 속성을 리스트화할 수 있는 기능을 할당한다.

        public void PrintMenu()
        {
            //메뉴 출력
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1.주소입력");
            Console.WriteLine("2.주소검색");
            Console.WriteLine("3.주소수정");
            Console.WriteLine("4.주소삭제");
            Console.WriteLine("5.주소전체 출력");
            Console.WriteLine("6.프로그램 종료");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("메뉴를 선택하세요>>>");

        }//기본 화면창이라 볼 필요가 없다.
        public int SelectMenu()
        {
            /*string input = Console.ReadLine();//input(문자열이라는 속성을 선언한다.)이라는 인스턴스에 콘솔창에서 라인을 적을 수 있는 권한을 할당한다.
            int menuNum = 0;//menuNum이라는 int 속성을 할당하고 이것의 값은 0이라고 할당한다.
            int.TryParse(input, out menuNum);//변환하는 것이다. input은 문자열이다. 이것을 숫자열로 변환하고 출력반환한다.
            Console.WriteLine($"선택된 메뉴번호 : {menuNum}");//사용자가 적을 수 있는 콘솔 화면을 찍고
            if (!(menuNum > 0 && menuNum < 7))
            {
                menuNum = 0;
            }

            return SelectMenu();*/
            // Console.WriteLine($"선택된 메뉴 : {menuNum}");
            // 다른 메서드들은 기능을 구현하거나 저장하는 list형식이 걸려 있지만 메뉴를 선택하는 것은 다르다.
            // 사용자가 해당 숫자를 클릭하고 엔터치면 그 값을 호출한 곳으로 연산결과를 돌려주지 않으면 작동되지 않는 것이다.
            // 메서드는 연산만 담당하지 값을 호출하는 기능을 하지 않는다.

            // 메뉴번호 입력
            Console.Write("메뉴를 선택하세요 >>> ");
            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            if (!(result > 0 && result < 7)) result = 0;

            return result;
        }
        public void InputAddress()
        {
            Console.WriteLine("주소입력");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소입력 : ");//주소는 없을 수도 있다.
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))//이름이나 전화번호가 존재하지 않거나 비어있다면 빈값을 넣어야 한다.
            {
                Console.WriteLine("빈 값은 입력할 수 없습니다.");
                Console.ReadLine();
            }
            else
            {
                listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
            }
            //list에 대해 알고 있어야 가능한 작업이다.
        }
        public void SearchAddress()
        {
            Console.WriteLine("주소검색");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; //찾는 이름이 있는가?--사용자들은 메세지를 보고 확인한다.
            foreach (var item in listAddress)
            {
                if (item.Name == name)//listAddress에 실린 이름과 콘솔창에서 찍은 이름이 같으면 해당 내역을 입력할 수 있다.
                {
                    isFind = true;//찾았음.
                    Console.WriteLine($"[ {idx} ]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("-------------------------------------");
                    break;//foreach 빠져나감.
                }
                idx++;//각각의 경우에마다
            }
            if (isFind == false)//만약 발견하지 못한다면 검색결과가 없다.
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();//화면멈춤
        }

        public void DeleteAddress()
        {
            /*C*//*//**onsole.WriteLine("주소삭제");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;//찾았음.
                    Console.WriteLine();
                    Console.WriteLine($"[ {idx} ]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("삭제하시겠습니까 [y/n]");
                    string answer = Console.ReadLine();// y/n
                    if (answer.ToUpper() == "Y")
                        listAddress.RemoveAt(idx);
                    break;//foreach 빠져나감.
                }
                idx++;*/
            /*}
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();//화면멈춤*/
        Console.WriteLine("주소삭제");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
    int idx = 0;
    bool isFind = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine($"[{idx}]------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.Write("삭제하시겠습니까? [y/n]");
                    string answer = Console.ReadLine(); // y/n
                    if (answer.ToUpper() == "Y")
                    {
                        listAddress.RemoveAt(idx);
                        Console.WriteLine("삭제했습니다.");
                    }

break; // foreach빠져나감
                }
                idx++;
            }

            if (isFind == false)
{
    Console.WriteLine("검색결과가 없습니다.");
}

Console.ReadLine(); // 화면멈춤
        }
        public void UpdateAddress()
        {
            Console.WriteLine("주소수정");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;//찾았음.
                    Console.WriteLine($"[ {idx} ]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("이름 재입력");
                    string uName = Console.ReadLine();
                    Console.WriteLine("전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(uPhone))
                    {
                        Console.WriteLine("빈 값은 입력할 수 없습니다.");
                        Console.ReadLine();
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;
                    }
                    break;//foreach 빠져나감.
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();//화면멈춤
        }

        public void PrintAllAddress()
        {
            Console.WriteLine("주소전체 검색");
            Console.WriteLine("-------------------------------------");
            int idx = 0;

            if (listAddress.Count == 0)
            {
                Console.WriteLine("주소록이 없어여");
            }
            else
            {
                foreach (var item in listAddress)
                {
                    Console.WriteLine($"[ {idx} ]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine();
                    idx++;
                }
            }
            Console.ReadLine();//화면멈춤
        }
    }
}

~~~

MainApp<br>
실제로 구동되는 메인 App이다.
~~~
using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)//Address를 관리하기 위한 기능들. 가장 메모리 상단에서 결과값을 도출하지 않는 메서드이다.
        {
            try
            {
                AddressManager manager = new AddressManager
                {
                    //초기화시켜주지 않으면 NUll값이다.
                    listAddress = new List<AddressInfo>()//
                };//manager는 해당 속성이다. 그리고 이것은 Addressmanager 클래스를 이용할거다. 상태를 안만들어주면 null이다.
                DataFileManageer fileManageer = new DataFileManageer();


                while (true)//반복문으로써 해당 콘솔창이 꺼지지 않고 사용자가 종료할 때, 종료될 수 있도록해주는 것이다. 그리고 이것은 항상 참이다.
                {
                    Console.Clear();
                    //Console.WriteLine(Environment.CurrentDirectory);//CurrentDirectory는 나의 위치를 알고 싶을 때 쓰는 것이다.
                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)//if문보다 훨씬 간단하다. 주소록에는 6가지 경우의 수가 있다.
                    {
                        case 1://주소입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();
                            break;
                        case 2://주소검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;
                        case 3://주소수정
                            Console.Clear();
                            manager.UpdateAddress();
                            break;
                        case 4://주소삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;
                        case 5://주소전체 출력
                            Console.Clear();
                            manager.PrintAllAddress();
                            break;
                        case 6://종료
                               //주소록을 다시 파일에 써야함.
                            fileManageer.WriteData(manager.listAddress);
                            Environment.Exit(0);
                            break;
                        default: //0은 여기서 처리.
                                 //아무 로직 없음.
                            break;
                            //각 케이스별 상황들을 분류하고 그 상황이 종료되면 default초기값으로 회귀한다는 말이다. 그리고 이것은 while에 의해 항상 참이므로
                            //프로그램이 종료되지 않는다.
                    }
                }
            }
            catch (Exception ex)//혹시 사용자가 뭔 짓을 할지몰라 에러가 발생하면 예외발생한 것에 대해 해당대처를 개발자가 하기 위함이다.
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            
        }
    }
}
//기능을 만들고 빠진 부분들을 삽입하여 논리적 오류를 제거해 주는 것이다.
//그래서 기능을 만들고 메서드로 빼서 오류를 제거해주는 편이 작업을 쉽게 할 수 있다. 초기 프로그래밍 기능 구현은 알고리즘이 떠오르지 않으니까
//힘들거 같고, 중급 이상부터 메서드를 만들고 기능을 편리하게 쓸 수 있을 거 같다.
//모듈화해야 한다. 필요한 기능별로 메서드를 뽑아야 할 필요가 있다.-->상향식 통합. 테스트 드라이브(테스트 하네스)를 이용한다.
//하향식 통합은 하위모듈 역할을 하는 스텁을 이용한다.
//참조가 중복으로 걸리면 컴파일러가 어떤 클래스를 참조해야 할 지 몰라서 에러가 발생하게 된다.
~~~
DataFileManager
<br>
데이터의 입출력을 구현한 곳이다.
~~~
using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{
    class DataFileManageer
    {   //텍스트 파일에서 저장된 주소록을 불러온다.(파일로드)
        const string dataFileName = "address.dat";
        //D:\sources\StudyCSharp21\chap99\AddressBookApp\bin\Debug\netcoreapp3.1 : 콘솔창에서 드래그해서 엔터치면 나온다.


        public List<AddressInfo> ReadData()
        {
            List<AddressInfo> listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;//데이터파일
            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));//Open//"파일흐름을 읽겠다."를 변수삼아 스트림리더를 시행하는 것. 
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                //temp 잘라서 manager.listAddress 할당
                string[] splits = temp.Split("|");//모른다면 var해도 상관없다.
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
                //데이터베이스를 안쓰고 구분자로 이용할 때 쓰는 것이다.
            }
            sr.Close();

            return listResult;// 연산만 끝나면 안된다. 아래의 WriteData에서 해당 읽은 것을 쓰려면 연산한 결과값을 반환해줘서 
            //경로를 읽은 결과값을 참조해서 변경내용을 작성해야 하기 때문이다.
        }

        public void WriteData(List<AddressInfo> param)//매니저 속성을 param이라는 변수 삼아서 쓴다.
        {

            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;//데이터파일
            StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
    //컴파일러가 경로를 읽고 쓰는 것까지 개발자가 설정해줘야 한다.
    //매개변수로 조건문들을 거는 것이다. 그리고 각 기능들을 Close해주지 않으면 연산값이 종료된 것을 어떻게 처리해야 하는가?라는 컴파일 에러가 발생한다.
    //그래서 개발자가 이것까지 설정해줘야 하는 것이다. 이는 연산값 처리 로직이 Null인것을 의미하기 때문에 발생하는 현상이다.
    //이로 미루어 보건데, 머신러닝은 해당 로직이나 프로젝트의 연산이 다중 반복처리되면, 사용자 호환없이 그 패턴대로 가능성이 높은 항목을 시행하겠다는 것을 의미할 것이다.
}
~~~
