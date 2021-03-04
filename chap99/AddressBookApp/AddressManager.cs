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
            string input = Console.ReadLine();//input(문자열이라는 속성을 선언한다.)이라는 인스턴스에 콘솔창에서 라인을 적을 수 있는 권한을 할당한다.
            int menuNum = 0;//menuNum이라는 int 속성을 할당하고 이것의 값은 0이라고 할당한다.
            int.TryParse(input, out menuNum);//변환하는 것이다. input은 문자열이다. 이것을 숫자열로 변환하고 출력반환한다.
            Console.WriteLine($"선택된 메뉴번호 : {menuNum}");//사용자가 적을 수 있는 콘솔 화면을 찍고
            if (!(menuNum > 0 && menuNum < 7))
            {
                menuNum = 0;
            }

            return SelectMenu();
            // Console.WriteLine($"선택된 메뉴 : {menuNum}");
            // 다른 메서드들은 기능을 구현하거나 저장하는 list형식이 걸려 있지만 메뉴를 선택하는 것은 다르다.
            // 사용자가 해당 숫자를 클릭하고 엔터치면 그 값을 호출한 곳으로 연산결과를 돌려주지 않으면 작동되지 않는 것이다.
            // 메서드는 연산만 담당하지 값을 호출하는 기능을 하지 않는다.
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
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();//화면멈춤

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
