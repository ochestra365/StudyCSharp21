namespace AddressBookApp
{
    //주소록 정보 클래스
    class AddressInfo//프로퍼티. 각각의 인스턴스에는 다음과 같은 요소들을 가져오고 설정할 수 있다.라는 의미이다. 그리고 이것을 속성화 한 것.
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
//메인 앱에서는 이 속성을 인스턴스에 선언하고 새로이 할당하여 기능을 수행한다.ㅇㅇ