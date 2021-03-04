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
                    }
                }
            }
            catch (Exception ex)
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