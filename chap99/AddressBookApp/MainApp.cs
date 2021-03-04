using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    //주소록 정보 클래스
    class AddressInfo
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    class MainApp
    {
        private static void PrintMenu()
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
           
        }
        private static int SelectMenu()
        {
            string input = Console.ReadLine();
            int menuNum = 0;
            int.TryParse(input, out menuNum);
            Console.WriteLine($"선택된 메뉴번호 : {menuNum}");

            if (!(menuNum > 0 && menuNum < 7))
            {
                menuNum = 0;
            }

            return SelectMenu();
            // Console.WriteLine($"선택된 메뉴 : {menuNum}");
            // 다른 메서드들은 기능을 구현하거나 저장하는 list형식이 걸려 있지만 메뉴를 선택하는 것은 다르다.
            // 사용자가 해당 숫자를 클릭하고 엔터치면 그 값을 호출한 곳으로 연산결과를 돌려주지 않으면 작동되지 않는 것이다.
            // 메서드는 연산만 담당하지 값을 저장하는 기능을 하지 않는다.
        }
        private static void InputAddress()
        {
            Console.WriteLine("주소입력");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소입력 : ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
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
        private static void SearchAddress()
        {
            Console.WriteLine("주소검색");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; //찾는 이름이 있는가?--사용자들은 메세지를 보고 확인한다.
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
        static List<AddressInfo> listAddress = new List<AddressInfo>();//주소록을 담을 컬렉션 
        private static void UpdateAddress()
        {
            Console.WriteLine("주소수정");
            Console.WriteLine("-------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind2 = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind2 = true;//찾았음.
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
                idx++;
            }
            if (isFind2 == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();//화면멈춤
        }
        private static void DeleteAddress()
        {
            Console.WriteLine("주소삭제");
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

                    item.Name = uName;
                    item.Phone = uPhone;
                    item.Address = uAddress;

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

        private static void PrintAllAddress()
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
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                PrintMenu();
                int menuNum = SelectMenu();
                

                switch (menuNum)//if문보다 훨씬 간단하다.
                {
                    case 0:// 메뉴선택 실패, 메뉴로 돌아감
                        break;
                    case 1://주소입력 화면 전환
                        Console.Clear();
                        InputAddress();
                        break;
                    case 2://주소검색
                        Console.Clear();
                        SearchAddress();
                        break;
                    case 3://주소수정
                        Console.Clear();
                        UpdateAddress();
                        break;
                    case 4://주소삭제
                        Console.Clear();
                        DeleteAddress();
                        break;
                    case 5://주소전체 출력
                        Console.Clear();
                        PrintAllAddress();
                        break;
                    case 6://종료
                        Environment.Exit(0);
                        break;
                    default: //0은 여기서 처리.
                        //아무 로직 없음.
                        break;
                }
            }
        }
    }
}
//기능을 만들고 빠진 부분들을 삽입하여 논리적 오류를 제거해 주는 것이다.
//그래서 기능을 만들고 메서드로 빼서 오류를 제거해주는 편이 작업을 쉽게 할 수 있다. 초기 프로그래밍 기능 구현은 알고리즘이 떠오르지 않으니까
//힘들거 같고, 중급 이상부터 메서드를 만들고 기능을 편리하게 쓸 수 있을 거 같다.
//모듈화해야 한다. 필요한 기능별로 메서드를 뽑아야 할 필요가 있다.-->상향식 통합. 테스트 드라이브(테스트 하네스)를 이용한다.
//하향식 통합은 하위모듈 역할을 하는 스텁을 이용한다.