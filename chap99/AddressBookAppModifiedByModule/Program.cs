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
    static void PrintMenu()
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
    }
    static int SelectMenu()
    {
        //메뉴번호 입력
        Console.WriteLine("메뉴를 선택하세요>>>");
        string input = Console.ReadLine();
        int menuNum = 0;
        int.TryParse(input, out int result);
        Console.WriteLine($"선택된 메뉴번호 : {menuNum}");

        if (!(result > 0 && result < 7)) result = 0;
        return result;//호출한 곳에 계산한 것을 메서드를 리턴한 곳에 호출해줘야 사용할 수 있다.
    }

    static void InputAddress()
    {
        Console.Clear();
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
            listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });//listAddress가 지역변수라서 이거 안됨. 주석1
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
                Console.WriteLine($"[ {idx2} ]-------------------------------------");
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
                           //메서드로 따로 빼버리면 메인 메서드 내에서 변수 중복을 피할 수 있다.
    }
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

    private static void PrintAllAddress()
    {
        PrintAllAddress();
        Console.WriteLine("주소전체 검색");
        Console.WriteLine("-------------------------------------");
        int idx4 = 0;

        if (listAddress.Count == 0)
        {
            Console.WriteLine("주소록이 없어여");
        }
        else
        {
            foreach (var item in listAddress)
            {
                Console.WriteLine($"[ {idx4} ]-------------------------------------");
                Console.WriteLine($"이름 : {item.Name}");
                Console.WriteLine($"전화 : {item.Phone}");
                Console.WriteLine($"주소 : {item.Address}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();
                idx4++;
            }
        }
        Console.ReadLine();//화면멈춤
    }

    private static void DeleteAddress()
    {
        Console.WriteLine("주소삭제");
        Console.WriteLine("-------------------------------------");
        Console.Write("이름 입력 : ");
        string name3 = Console.ReadLine();
        int idx3 = 0;
        bool isFind3 = false;
        foreach (var item in listAddress)
        {
            if (item.Name == name3)
            {
                isFind3 = true;//찾았음.
                Console.WriteLine($"[ {idx3} ]-------------------------------------");
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
            idx3++;
        }
        if (isFind3 == false)
        {
            Console.WriteLine("검색결과가 없습니다.");
        }
        Console.ReadLine();//화면멈춤
    }
    static List<AddressInfo> listAddress = new List<AddressInfo>();//주석1의 해결방안


    static void Main(string[] args)
        {
            List<AddressInfo> listAddress = new List<AddressInfo>();//주소록을 담을 컬렉션
            while (true)
            {
                Console.Clear();
                MainAppclass.PrintMenu();
                int menuNum = SelectMenu();
                // Console.WriteLine($"선택된 메뉴 : {menuNum}");

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
//null값이 들어가는 문제가 생기기 때문에 그 문제를 고치는 작업도 필요하다. 찾지 못한 오류는 프로그램을 직접 실행해보면서 찾아야 한다.
//메인메서드에 구현하고자 하는 기능을 전부 구현하고, 상향식 모듈화 작업을 시행한다. Alt+Enter를 눌러서 메서드를 생성한다.
//개발자느 ㄴ입력하면서 데이터타입을 잘못 입력하는 경우가 매우 많다.
//이번 과제를 통해 같은 기능을 하는 코딩은 많지만 알고리즘에 따라 작업량이 현저하게 줄어들게 할 수 있는 방법을 알 수 있었다.
//또한 지역변수개념과 생성자에 대한 중요성, 그리고 데이터를 입력하고 출력하는 것의 중요성을 알게 되었다.