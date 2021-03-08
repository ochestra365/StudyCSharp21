# _StudyCSharp_

PKNU C_Sharp 학습 리포지터리(Chap 18)
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%ED%94%BC%EC%B9%B4%EC%B8%84.png" width="60%" height="40%" ><br>
언젠가 라이츄가 되는 그날을 위해...

## Basic C# 주소록 생성
목차 <br>
1. 주소록의 기능 생각해보기<br>
2. 프로그램 시행해보기<br>
3. 해당코드정리<br>
4. 학습사항 정리<br>

------------------
## 1. 주소록의 기능 생각해보기
__우리가 평소에 알고 있는 주소록은 무엇일까?__<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EB%A1%9D.png" width="60%" height="40%" ><br>
위 사진은 네이버의 주소록이다. 주소록의 기능에 대해서 알아보도록 하자!!<br>
### 주소록의 기능은 다음과 같다.<br>
1. 주소의 입력할 수 있어야 한다.
2. 주소를 검색할수 있어야 한다.
3. 주소를 수정할 수 있어야 한다.
4. 주소를 삭제할 수 있어야 한다.<br>
~~~
아주 심플하게 살펴 본 기능이다. 콘솔창을 통해서 기능을 구현해보자면 데이터 읽고 저장하는 것까지 구현해볼 수 있겠다.<br>
 해당 기능을 구현해보도록 할텐데, 콘솔창을 이용해서 해당 기능을 구현해보도록 하자.<br>
tip. 개발하고자 하는 기능이 명확하므로 기능 객체를 먼저 구현하는 것이 유리하다.
~~~
--------------
## 2. 프로그램 시행해보기
### 콘솔창에서 바라본 출력화면<br>
가장 먼저 프로그램의 동작 화면부터 살펴보고, 공부한 내용을 기입해 보도록 하겠다.<br>

1. 시작화면
-----------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%B6%9C%EB%A0%A5%ED%99%94%EB%A9%B4.png" width="40%" height="30%" ><br>
콘솔창의 초기 출력화면이다.

2.  주소입력
------------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%9E%85%EB%A0%A5.png" width="40%" height="30%" ><br>
1번을 누르고 다음과 같은 주소를 입력해 보았다.<br>

3. 주소검색
----------------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%89.png" width="40%" height="30%" ><br>
2번을 누르고<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%892.png" width="40%" height="30%" ><br>
나의 이름을 적어보고 검색(Enter)을 해보았다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%893.png" width="40%" height="30%" ><br>
검색창에서 나의 정보가 나왔다.<br>

4. 주소수정
---------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%88%98%EC%A0%95.png" width="100%" height="100%" ><br>
이번엔 3번을 눌러서 주소를 수정해보자.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%88%98%EC%A0%952.png" width="40%" height="30%" ><br>
해당 화면과 같이 수정을 해보았다.

5. 주소전체출력
---------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%A0%84%EC%B2%B4%EC%B6%9C%EB%A0%A5.png" width="40%" height="30%" ><br>
어느 날 해커가 들어와서 나의 프로그램에 장난질을 했다!!<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%A0%84%EC%B2%B4%EC%B6%9C%EB%A0%A52.png" width="40%" height="30%" ><br>
슬프게도 나의 프로그램은 보안이 약해서 그대로 뚫려버렸다... 보안 공부를 해야 할 필요가 있다!!

6. 주소삭제
------------
-----------
해커가 장난질 한 주소를 지워보자.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%82%AD%EC%A0%9C.png" width="40%" height="30%" ><br>
주소삭제란에 들어가서 주소를 삭제해보았다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%82%AD%EC%A0%9C2.png" width="40%" height="30%" ><br>
삭제가 완료되었다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%82%AD%EC%A0%9C3.png" width="40%" height="30%" ><br>
검색을 해보니 컵라면이 삭제되었다!!!!<br>

7. 프로그램 종료
-------------
-----------
 해당 프로그램을 종료하는 것까지 마무리해보았다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%A8%20%EC%A2%85%EB%A3%8C.png" width="40%" height="30%" ><br>


## 3. 해당코드정리
----------------
-----------
코드의 내용이 방대하여 주소를 남길테니 해당 하이퍼링크를 클릭해보길 바란다.<br>
![Addressinfo.cs](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/AddressInfo.cs "프로퍼티 생성")<br>
![AddressManager.cs](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/AddressManager.cs "기능생성")<br>
![DataFileManageer.cs ](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/DataFileManageer.cs "데이터 읽기 및 저장 생성")<br>
![MainApp.cs  ](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/MainApp.cs "MainApp 구동")<br>

## 4. 학습사항 정리
----------------
-----------
~~~
2.22 강의안
GNU는 가장 강한 제약조건을 포괄하고 있다. 아파치 라이선스는 소스코드의 의무사항은 없지만 아파치에서 만든 것임을 알아야 한다.
LGPL은 소스코드의 공개 부담이 느껴진다면 이것을 하지 않아도 되는 것이다. MIT가 가장 편하다. 저작권만 명시해주면 된다. 이걸 가져다 써도 상관 없다. 내 소스까지 오픈할 의무는 없다.(상용 오픈소스를 다룰 의무가 없기 때문이다.)
오픈소스라 해서 무조건 가져다 쓰는 것이 아니라 가져 쓰더라도, 라이선스 명시는 반드시 필요한 것이다. 그렇지 않으면 벌금을 세게 물어내야 한다. 재단에서는 본인 프로그램 소스를 파악할 수 있는 것이 있다. 가져다 쓰는 소스보다 알고리즘을 만들어서 본인들이 만들어 쓰는 것이 개발자의 역할이다.
MIT나 BSML은 명시만 제대로 하면 마음대로 써도 된다. 챕터별로 나눠서 지금 학습중이라 솔루션이 꼬일 수 있다.
비주얼스튜디오는 잔 파일들이 많이 올라간다. 깃 이그노어가 없다면 컴파일 에러가 일어난다. 여러 사람들이 작업할 때는 깃 이그노어 작업을 반드시 해두어야 한다. 동기화 한다면 리모트에 있는 것을 바꾸고, 내 로컬을 최신화하는 것이다. 들어온 커밋은 내가 리모트에서 나온것.
아침에 오면 누군가 단톡방에 변경 사항을 올린다. 그때, 동기화하고 시작해야 한다. 단, 꼬이면 자기 책임이다.	
솔루션은 프로젝트의 집합이다. 컴파일 하면 DLL만들어서 전체 중간언어 만들어서 EXE를 시행한다.
로잘린: z 브레인 사의 리샤트를 깔면 컴이 바보가 된다. 회색이 나오는 것은 사용하지 않는 것을 의미한다. 컴퓨터의 모든 것들은 데이터가 있다. 값 형식과 참조 형식이 따로 있는 이유를 알아야 한다.
전쟁에 필요한 모든 것들이 생활에 필요한 기술들로 바뀌어서 우리가 사용하게 되었다. 문화와 전쟁은 상극인데, 우리가 사용하는 것이다. 
변하지 않는 것은 상수이고, 변하지 않는 것은 변수이다. 변수가 값을 담는 것이 다 다른 이유는 효율성과 최적화를 위해서이다.
쓸모 없는 자리를 많이 차지하는 것은 효율적이지 못하다. 본인 사이즈들에 맞는 숫자나 데이터를 가지고 다니는 것이 중요하다.
데이터를 담는 일정 크기로 포괄하는 것이 효율적이다. 변수를 만들어서 새로히 사용하는 것이 중요하다. 변수를 선언과 동시에 할당하는 것이다.
컴퓨터 메모리에 어느 위치에 만들겠다. 이런 것이 중요하다.

@@ 솔루션은 프로젝트의 모임이다.@@@
별표는 자주 쓰인다는 말이다. 공통적으로 이그노어할 사항이 무엇인지 정해야 함.

@@ 값형식과 참조 형식@@ 자바나 파이썬 등 모든 곳에서 사용된다. 알고 있으면 정말 좋은 것이다.
object는 모든 클래스의 가장 최상위 부모이다. true, false값도 있다. 다른 클래스도 넣을 수 있다. 숫자만 넣는 것이 아니라 C#에서 쓰는 모든 데이터값을 다 넣을 수 있다. 
참조형식은 스택위치이다. 값형식은 스택, 참조형식은 스택과 힙을 다 같이 쓴다. 힙은 데이터 저장이고 , 스택은 힙의 메모리 주소이다. 그 이유는 힙 영역은 한 번 만들고 여러 번 쓸 수 있다. (OS부터 이렇게 만들었다.)
참조형식은 값을 넣지 않으면 뭘 넣을 지 모른다. 그 때문에 가리키는 것을 포인터라고 한다. 가리킬 포인터가 없다면 NULL포인터라고 한다.

값형식은 메모리 값에 직접 넣는 것. 참조 형식은 힙과 스택에 한다. (배열 스트링, 클래스 오브젝트)스택은 주소, 힙은 변수의 값을 저장한다.
참조형식은 변수사용, 값형식은 시스템함수를 사용할 때, 쓰는 것이다. 가비지 컬렉터가 더 이상 쓰이지 않는 데이터인 "쓰레기 데이터"를 수거해 간다.
overflow는 데이터 형식의 최대값을 넘어가는 데이터를 저장할 때 쓰이는 것이다.
underflow는 최저 값보다 작은 데이터를 저장할 때 쓰이는 것이다.
object는 모든 데이터 형식을 다 담을 수 있다. 자바도 마찬가지다. 박싱= 값 형식의 데이터를 object 형식에 담는 다면
언박싱 힙의 값 형식 데이터를 값 형식 객체에 할당하는 경우.
변환 변수를 다른 데이터 형식의 변수에 옮겨 담는 것이다. 크기, 부호, 부동 소수점,정수, 문자열과 숫자. 작은 정수 형식 변수 데이터->큰 정수 형식변수, 큰 정수 형식 변수 데이터->작은 정수 형식 변수(오버플로우 발생 가능성)
컴파일러는 책임 안 지니, 개발자가 책임 져야 한다. 작은 통에 큰 것을 담을 형변환 시에는 항상 그 값을 잘 기입해 주어야 한다.
App은 하나의 어플리케이션의 약자인데, 통일된 용어로 쓰인다. int?를 하면 var는 형변환 시 어떤 상태로 변화할 지 추측하고 해야 해서 예측이 힘들어진다.
한 메서드안에서만 쓰겠다. Var는 가장 약한 상태이다.
전역 변수는 사용하지 않겠다. null은 튜플의 존재 필요성을 위해서 필요한 값이다. 컴파일 에러가 일어난다. 왜냐하면 컴퓨터는 공란으로 놔두면 값이 입력되어야 할 지 말아야 할 지 결정해야 하고 다 딜레마가 발생한다.
공란으로 놔 둘시, 사용자가 깜빡하고 빼넣은 정보를 0으로 두면 사회혼란이 발생한다.
그렇다고 공란으로 놔두지 않겠다고 결정할 시에 일정한 값을 확인할 수 없을 경우, 사용자 측에서 컴파일 에러가 발생해 사회혼란이 발생한다.
그래서 사회혼란을 잡기 위해서 NULL이 필요하다. 튜플의 존재성을 확인 시켜주는 것이다.
~~~
~~~
2.23 강의안
컴퓨팅에서 로그파일(logfile)은 운영 체제나 다른 소프트웨어가 실행 중에 발생하는 이벤트나 각기 다른 사용자의 통신 소프트웨어 간의 메시지를 기록한 파일이다. 로그를 기록하는 행위는 로깅(logging)이라고 한다.
연산자에서 후치연산과 전치연산의 차이점을 기억해야 한다. 후치연산은 콘솔에 출력을 한 뒤에 연산을 시행하는 것이다. 전치연산은 콘솔에 출력하기 전에 연산을 시행하는 것이다. 내용을 알고 있어야 개발자가 사용자에게 설명할 수 있다. 그래야 본인이 실수하지 않게 된다.
일처리에서 막히지 않게 하기 위해서는 다른 문제를 발생하지 않게 하기 위한 기본기가 중요하다. for문에서 중요하게 다뤄지는 내용이다. +연산자는 값을 더하는 것뿐만 아니라 문자열을 더하는 것에서도 필요하다. 연산자는 논리관계를 따질 때 많이 사용된다.
논리연산자에서 &&은 모든 조건이 참이어야 한다. 그리고 ||은 둘 중 하나의 조건만 만족하면 된다. 대체로 &&의 조건이 많이 사용된다. DB에서 outer join과 비슷한 형식이다.
변수를 가지고 있을 때, 뭘 가지고 있는 지 모르겠다고 하면 null이라고 한다. 초기화를 안하면 값 형식들은 0으로 초기화되지만 C언어에서는 그냥 쓰레기 값이 되어 버린다. 객체 지향이기 때문에 비주얼에서는 초기화시켜준다. 기본 타입들, 참조 형식은 초기화 값이 없다.
그래서 NULL로 초기화한다. 참조 값은 값이 들어간 것이 아니라 주소가 가고 주소가 가리킨 곳에 값이 있다. 그래서 어디로 갈 지 모르겠어서 NULL이라고 한다. 참조형식은 값을 넣지 않고 NULL을 쓰면 전부 에러가 뜬다. 
비트연산자를 쓰면 계산기 엄청 빨라지게 된다. 그래서 시프트 연산을 통해서 연산을 빨리 한다. 유지보수의 소스에 이러한 것들이 존재한다면 긴장을 빨아야 한다. 복잡한 계산을 빨리 할 때, 요런 비트연산이 필요하다. 그러나 일반적인 IOT직무에서는 이런 비트연산이 필요없을 것이다.
비트 연산이나 논리연산관계는 별로 쓸 일이 없다. &&나||은 할당 연산자에 사용할 수 없다. 왜냐하면 얘네들은 논리연산자이기 때문이다. 헷갈려서 잘 쓰기 힘들다. ?가 들어가는 순간 NULL도 허용하는 것이다.
사용자들은 값이 나오지 않거나 null이 나오면 긴장을 하게 된다. 따라서 관리자에게 연락을 해야 한다.
연산자 우선순위는 외울 필요가 없다. 괄호로 모든 것을 해결하면 된다. 먼저 연산할 내용을 괄호로 해결한다. 연산자 우선순위 외울 필요 없다. 언어에 대한 키워드 혹은 차이점만 알면 변수 선언과 설정에 대한 것들은 유사하기 때문에 배우기 쉽다.
나머지 언어들은 다 내용들이 존재한다. C#을 하나만 하게 되면 자바나 C++에 배우는 것은 일도 아니다. 코드의 흐름을 제어하는 것은 예약어, 키워드 그리고 시행되는 것에 대한 것은 모든 언어에서 배우게 되는 것이다.

분기문 if문 switch문(프로그램의 흐름을 조건에 따라 변화시키는 구문)
만약에 참이라면 a를 실행하고 아니라면 b를 시행한다. 참이면 코드블럭을 사용한다. 참, 거짓에 따라 2개의 코드를 사용하면 사용자 오류가 발생할 수 있다. 그래서 한번만 적고, 나머지 연산은 else를 통해 끊어주는 것이 좋다.
if문은 중첩해서 사용할 수 있다.
사람이 하면 수많은 반복처리작업이 필요한 일을 컴퓨터를 사용해서 빠른 시간안에 처리하도로 하자. 소스코드를 짜다가 한번 이상 쓰이게 되면, 바로 메서드로 빼야 한다.(기능으로 빼서 전부 적용될 수 있도록 해야 한다.) return은 메서드를 호출한 곳으로 점프한다는 의미이다.
결과를 내놔라고 한 곳으로 돌아간다. 점프할 때, 반환형식과 같아야 한다. 배열이면 배열, 객체면 객체, 등등 반드시 같은 객체로 쓰여야 한다. 약속된 값으로 돌려줘야 한다는 것이다. void는 리턴문이 없다. 반환식으로 void를 때려버리면 돌아오는 것이 없게 된다.
메서드는 수학의 함수와 같다. 한 마디로 여러 번 쓰인다. 계속 쓰인다. 그래서 메서드로 따로 뺀다. 한번 이상 사용되면 메서드로 빼서 사용하라는 것이다. 메서드를 뺄 생각을 못하면 개고생을 해야 한다. 3~4줄이 반복되고 3번 이상이 되면 무조건 메서드를 만들어야 한다.
메서드를 안 쓰면 하나를 바꾸면 다른 모든 것들도 바꿔야 하기 때문에 메서드 화해서 호출하는 형태로 써야 작업량을 완전히 줄일 수 있다.
~~~
~~~
2.24 강의필기안
메서드 오버로딩은 객체지향에서 중요한 내용 중 하나이다. 개념 잡기가 매우 어려울 수도 있다. 정수형으로 플러스하면 정수형이 된다. int로 계산한 것에 short을 넣을 수 있다. 큰 타입에 작은 타입을 찍는 것은 문제가 없다.
타입이 여러 가지인 이유는 메모리 사이즈를 절약하기 위해서이다. 타입이랑 개수랑 리턴타입만 제대로 적어주면 컴파일러가 알아서 해준다. 같은 타입으로 매개변수를 계속 만들 수 있다.
선택적 매개변수는 모호함이 발생할 수 있다. 명명된 매개 변수를 사용하는 것이 가장 좋다. C에다가 객체를 넣어보자고 해서 만들어진게 C++이고 이것이 발전한 것이 JAVA와 C#이다. 이것들이 버전업되면서 바뀐 것이 바로 요즘 널리 쓰이는 JAVA와 C#인 것이다.
현실 세계의 모든 것들은 객체이다. 사실은 object를 한글로 번역하면 개체이다. 객체는 하나하나의 단위로 뗄 수 있는 단위를 말하고, 물체나 모형을 나타내는 것은 개체이다.
세상의 모든 것은 객체로 표현할 수 있다. 책을 펼치고 덮는 것은 사람이 하는 것이다. 정확하게 의의를 하려면 사람이라는 객체가 책을 읽기 때문에 행위의 주체는 사람이 된다.
코드 내에 존재하는 모든 것을 객체로 표현하려는 프로그래밍 패러다임.
객체가 가지고 있는 특성이나 속성을을 데이터라고 한다. 그리고 객체가 행동할 수 있는 것을 기능이라고 한다.(메서드) 속성을 변수로 만들고, 하는 행위들을 모두 메서드로 만든다. 이것을 하나로 묶은 것을 객체라고 부른다.
객체를 만들 수 있는 기반 소스코드를 클래스라고 한다. 메모리에 올라가려면 클래스에 선언한 것을 청사진이라고 한다. 객체는 그 자체의 object를 행위를 하는 것을 객체라고 한다. 그것을 글로 표현한 것을 클래스라고 한다. 같은 거지만 어떤 식으로 표현하냐에 따라서 클래스라고 한다.
정리해놓은 글들을 클래스라고 한다. int a = 30;을 분해
int: 클래스, 청사진이다. a는 객체의 int의 실체라고 한다.(instance)
객체로 만들어서 쓰려면 클래스를 선언해야 한다. 그리고 클래스에 들어가는 각종 데이터를 넣고 거기에 대한 메소드를 기능을 넣어줘야 한다. 

객체를 실현할 때는 생성을 해야 한다. 그리고 종료할 때는 종료자를 적어주어야 한다. 종료자느 사용하지 않는 것이 좋다. 고급적인 작업을 할 때, 진짜 한 번씩 쓰게 된다. 20년 코딩 중 1번 정도 쓸 기억밖에 없다. 거의 아예 쓰지 않는다.
오버라이딩은 부모객체의 멤버변수를 재공학하는 것을 의미하고, 오버로딩은 이름은 같지만 매개변수를 다르게 설정해주는 것을 의미한다. 회사에 집중을 해서 회사의 동작 과정이나 다른 것들을 면밀히 쌓고, 회계적 지식을 다량으로 깊게 알아야 개발할 수 있다.
정적(static)필드와 메서드--> 정적 필드는 정적으로 메모리에 저장되어 있는 것이다. static은 메서드나 필드가 클래스 자체에 소속되도록 지정하는 한정자. 컴퓨터 용어는 표준이 없다. 용어는 달라도 개념은 같은 경우가 많다. 표준화 기구에서 이름을 정의하던가 한다.
static은 메모리에 자동으로 올라가게 된다. 원주율 같은 경우는 static에 사용된다. 인스턴스를 만들지 않고 클래스의 이름을 통해 필드에 직접 접근한다. new를 하지 않아도 메모리에 바로 올라가게 된다. static을 쓰게 되면 메모리 가장 상단으로 올라가게 된다.
메모리를 상단으로 올린다는 말이 컴퓨터가 해당 메모리를 가장 먼저 처리하겠다는 말인가? 필요한 메모리를 썼다가 지워야 한다. static은 공통되는 작업을 할때, 컴퓨터가 운영되는 한 계속적으로 사용하는 것이다.

static이라는 의미는 ‘정적인, 움직이지 않는다.’는 뜻이다. 메모리에서 고정되기 때문에 붙은 이름이지만, 실제 소스에서 static을 사용한다는 의미는 모든 객체가 ‘공유’한다는 의미이다.

출처: https://devbox.tistory.com/entry/Java-static [장인개발자를 꿈꾸는 :: 기록하는 공간]

접근 한정자로 은닉성(캡슐화)를 구현할 수 있다. 감추고 싶은 것은 감추고, 보여주고 싶은 것만 보여준다. private는 클래스 내부에서만 접근할 수 있다. 파생클래스에서 접근 불가. 파생은 상속이다
~~~

~~~
2.25 강의 필기
객체-세상의 모든 것을 지칭, 객체의 표현: 속성-데이터, 기능-메소드, 클래스 : 객체를 만들기 위한 청사진// 모든 객체는 어떤 속성과 기능을 가지고 있다. 행위를 하는 기능들을 모두 메서드로 만들 수 있다.
int는 클래스// 기본 생성자// 사용자 지정 생성자-->객체 생성시 필드 초기화
static 메소드나 필드가 클래스 자체에 소속되도록 지정하는 한정자(메모리 힙의 가장 최상단에 올라가서 컴파일 처리의 우선순위가 된다.) 
this__객체가 자신을 지칭할 떄, 사용하는 키워드이다. this생성자를 통해 다른 생성자를 오버로딩해서 쓸 수 있다.

오버로딩(overloading)은 이름은 같지만 @@@2시그니처@@@@(파라미터 수, 타입) 다른 데는 메소드를 중복으로 선언하는 것을 의미하고, (Refactoring)(재공학인가?)오버라이딩(overriding)은 부모 클래스의 메소드의 동작 방법을 변경(재정의)하여 우선적으로 사용하는 것이다.
오늘은 상속에 대해서 배울 것이다. 상속이란 무엇인가?(유전자)프로그래밍에서의 상속은 부모로부터 물려받은 유전자, 즉 속성을 의미한다.-->대체로 아버지가 키가 크면 아들도 키가 크게 된다.
누가 자식클래스에게 물려줄 것인가를 생각해야 한다. 부모클래스가 어떤 멤버(속성하고 기능 전부를 의미한다.) 우리가 쓰고 있는 메서드들 전부를 의미한다.
파생클래스=자신만의 고유 멤버+기반 클래스 멤버. A클래스로 잘 작용하고 있었는 데, 모든 소스를 다 바꿔야 할 수 있다. 그러나 상속을 하게 되면 조금만 수정하면 다 바꿀 수 있다. 모든 객체들을 만들 떄 수많은 특성들을 가지고 있다.
부모클래스에서 물려줄 때, 자식에서 그 내용을 쓸 것인가 말 것인가가 중요하다. 누구를 부모로 해서 물려받을 것인가? 혹은 지칭이 중요한 것이다. 자식 클래스는 잘 만들어 놓으면 손 댈 일이 없으나 자식 클래스는 손 대게 될 때, 많은 일들이 필요하게 된다.
기반 클래스의 멤버를 호출할 떄는 base를 사용한다. 부모클래스의 상속이 객체지향의 지향점 중 가장 큰 특징이다. 예전에는 구조체라는 것이 존재했다. 구조를 만들어 놓고 그것들을 복사해서 사용했다. 지금은 코딩량이 많이 줄어 든 것은 툴이 버전업 되었기 때문이다.
부모 클래스를 계속 쓰면서 작업하면 연산 속도가 느려지게 된다.(실무에서 통신 프로토콜이 있는 데, 상속해서 일처리해야 할 일이 있다면 그것들을 잘 고려해서 일처리를 해야 한다. 상속받아서 하위 단에서 특성들이 있을 때, 상속이 필요하게 된다.(통신 프로토콜이 이에 해당한다.)
자식이 잠시 부모가 될 수 있다. 실제적으로 바꿔서 유지하는 것이 아니다. 이 기능을 잘 알고 있다면 추상화, 일반화 개념으로 갈 때 도움이 많이 된다. Nurse는 보호하여 키우다라는 의미이다.
기반 클래스와 파생 클래스 사이에 족보를 오르내리는 형식 변환이 가능하다. 파생 클래스의 인스턴스를 기반 클래스의 인스턴스로 사용 가능하다. 기반 클래스와 파생 클래스의 관계성을 역전시켜야 하는 상황이 무엇인가?
파생 클래스와 기반 클래스의 관계를 역전 시킬 때는 속성 overflow를 사용자가 관리해줘야 한다.
형변환을 하는 이유는 잠시 형변환을 통해서 자기 값을 바꿔서 어떤 작업을 수행하기 위해서이다. 부모클래스의 가장 위에것을 추상화 클래스라고 한다. 그리고 하위 단계의 클래스는 일반화 클래스이다.
추상화를 일반화시켜줘서 개발하기 편하게 하도록 위함이다.(소스코딩은 굉장히 추상적인 학문이다.) 참조형식일때는 (값형식은 괄호이다.)괄호가 아니라 as 연산자를 이용해서 형변환을 해주는 것이 좋다.
int double float short decimal 값 형식들은 괄호로 메모리에 직접적으로 영향을 주는 것은 값형식 형변환이 가능하다. 작은 값에 큰 값을 집어넣을 때는 안됨. 그러나 Logic에 관련된 것은 참조형식(배열, 클래스,) is 로 물어본 다음에 as로 바꿔주는 것이 가장 안전하다.
bool은 참, 거짓이라기 보다는 분기를 나누는 키워드이다. 상속에 대한 개념, object에 대한 개념을 알아야 한다. 일반적인 개발자들은 c#안에서 객체들을 하고 작업을 하는 것을 통해서 이해의 깊이에 대한 가속도를 높이는 훈련을 해야 한다. 
많은 언어를 배워두는 것은 로직 개발에 도움이 된다. 왜냐하면 각 언어가 참조하고 다루는 로직은 초기에는 비슷하나 후기로 갈 수록 심화되기 때문이다.

partial 키워든 여러 번에 나눠서 구현하는 클래스이다. 
클래스의 구현이 길어질 경우 여러 파일에 나눠서 구현하는 것이다.
소스 코드 관리의 편의를 제공하는 것이며 partial 키워드를 사용한다. 클래스의 구현이 길어질 경우 여러 파일에 나눠서 구현한다.

오버로딩은 메소드에 관한 것이고, 오버라이딩은 방법에 관한 것이다.
오버라이딩과 다형성== 객체가 여러 형태를 가질 수 있음을 의미한다. 하위 형식 다형성(Subtype Polymophism)이다.
오버라이딩 
조건: 대상 메소드를 virtual 키워드로 선언
private로 선언한 메소드는 오버라이딩 불가
재 정의를 위해 Overirde 키워드 사용.
클래스는 한 프로그램에 한 클래스명만 쓸 수 있다. 즉, 같은 영역에서 같은 클래스
~~~

~~~
2.26 강의 필기안
객체 지향 개념 때문에 골치가 아파짐 두 개를 비교했을 때, 절차적 프로그래밍 보다 더 편리하게 만들어진 것이다. 모든 세상의 것들은 객체이다. 모든 것들은 속성을 가지고 있다. 그리고 기능을 가지고 있다. 모든 것들은 행위를 가지고 있고 기능(메소드)라는 것을 가지고 있다.
나이 성별 키 NEW 하면서 만드는 실체를 인스턴스라고 한다. this는 명칭을 다르게 쓰면 상관이 없다. 멤버변수는 this를 붙인다. 그렇게 해서 구분해서 쓴다. 하다가 점점 알아가면 되는 것이 있다. 상속이라는 의미도 연습을 해야 한다. 부모는 자식에게 상속할 수 있지만 자식은 부모에게 상속할 수 없다. 자식은 부모에게 상속할 수 없다. 개념적으로 부모가 있어야 자식이 있다. 부모가 자식에게 상속을 해준다. 파생클래스는 자신만의 고유 멤버가 있다. 기반 클래스 멤버도 있다. 디버그는 F9를 누르고 Ctrl+D+I를 누르면 시행된다.
interface 키워드를 이용한 선언 형식.
가능한 멤버: 메소드, 이벤트, 인덱서, 프로퍼티
구현부 없음
모드:public으로 선언
인스턴스 생성 불가
인터페이스를 상속 받은 클래스의 인스턴스 생성 가능. .net framework는 윈도우를 기반으로 한다. 배열은 값형식이 아니라 참조형식이다. sort를 알고 있다면 sort가 자동으로 배열을 정렬한다. 배열은 튜플을 먼저보고 열을 보는 것이다.
데이터형식[,] 배열이름= NEW 데이터형식 [2차원길이, 1차원길이]
~~~

~~~
3월 2일 강의안
형변환을 하면 되기 때문에 배열을 컬렉션으로 바꾸고 데이터를 집어 넣고, 형변환을 해주면 된다. 실무에서는 컬렉션으로 거의 모든 업무 처리를 하게 된다. 배열이 얼마나 안 좋은 면이 있는 지 알려준다. .NET프레임워크에서는 컬렉션 클래스가 
ArrayList, Queue, Stack, Hashtable 등이 있다.
ArrayList []연산자를 이용한다.
용량을 미리 지정할 필요 없고, 필요에 따라 용량이 증가하거나 감소하게 된다. Hashtable은 사전같은 거다. 키와 값이 쌍으로 이루어진 데이터를 다룰 떄 사용한다.
일반화란 특수한 개념으로부터 공통된 개념을 찾아 묶는 것을 말한다. 일반화 프로그래밍은 일반화의 대상 => 데이터 형식을 의미한다. 추상화와 비슷하다. 고래, 사자, 원숭이, 고릴라 이런 것들의 공통된 개념은 포유류이다. 처음부터 있었던 개념이 아니다.
param 배열은 모든 것들이 int 데이터 타입을 가지면 괜찮다. 그러나 그거로도 다 처리가 안돼서 좀 더 다른 개념을 생각해야 한다. 오버로딩 없이 모든 형식을 지원하는 프로그래밍 패러다임을 의미한다. int short float byte 데이터 타입과 형식이 엄청나게 많다. 이런 것들을 
다 만드는 것들은 개발자가 너무 힘들게 된다. 그래서 논리로직은 같은 데, 데이터 형식이 다른 경우느 일반화 메소드를 통해서 작업을 처리해야 한다. 
한정자 반환 형식 메소드이름<>(매개변수 목록)
{
//
}


데이터 형식을 일반화한 클래스
클래스 일반화 단계 
1. 데이터 형식은 다르나 기능은 같은 클래스
2. 형식 매개 변수를 이용해 일반화 클래스로 개선
3. 객체 생성시 입력 받은 형식으로 치환.

일반화 컬렉션은 object형식에 기반하기 때문에 태생적 성능 문제 내포하고 있다. 일반화 컬렉션으로 해결하거나 컴파일 시 컬렉션에서 사용할 형식을 결정한다. 잘못된 형식의 객체를 담게 될 위험을 회피한다.
object형식에서 자기가 원하는 형식으로 타입을 바꿔야 한다. Generic을 할 경우, object 형식으로 변환되게 한다.

비일반화 클래스 ArrayList와 동일한 기능과 사용법. 차이점 1. 인스턴스 만들 때 형식매개 변수 필요 2. 형식 매개변수로 입력한 형식 외에는 입력을 허용하지 않음.
Hashtable의 일반화 버전.
사용 방법 상의 차이점 2개의 형식 매개 변수 요구. Tkey는 Key,TValue는 Value를 위한 형식.
예외란
프로그래머가 생각하는 시나리오에서 벗어나느 사건->프로그램의 오류나 다운으로 이어지지 않도록 처리하는 것을 의미한다.(예외처리)-->엄청 많다.
오류랑 에러는 다르다. 컴파일러가 발생한 해당 문제에 대해 인지하고 있는 것은 에러이다. 그러나 오류는 컴파일러도 잡지 못하고 개발자도 잡지 못한 문제로 예외에 대한 처리가 필요하다.
컴파일러가 못 잡는 예외들이 겁나게 많다. 메커니즘 1. try 절에서 원래 실행하고자 했던 코드 처리. 2. 예외(if여러 개)가 던져지면 catch 블록(여러 개) 에서 받아서 처리.3. Catch 예외 형식 = try 블록에서 던진 예외 형식
++사람들은 예외가 3회 이상 발생하면 사용하지 않는다.++
try catch로 예외를 받아서 처리한다. 같은 쿼리 코드를 적어서 여기서 예외가 발생하면 원래 실행하고자 했던 코드를 처리한다.
try~catch 메커니즘
try절에서 원래 실행하고자 했던 코드를 처리한다. 예외가 발생하면 catch 블록에서 받아서 처리한다. catch 예외 형식은 try 블록에서 던진 예외 형식이다.
try~catch에서 중요코드를 실행 못하게 하고자 한다면 자원 해제 같은 뒷마무리를 담당하는 finally 절이 필요하다. dbconn.Open(); connection pool이 있어야 한다. open이후 사람이 떨어지면 빈 자리를 다른 사람이 사용하게 해주어야 한다.
파일의 텍스트에서 열어서 내용을 읽는 일들을 해야 할 경우에 Open을 해야 하는데
try~catch~finally가 하나의 일처리를 담당하는 세트구문이다. try는 예외가 발생하게 되면 그 예외 상황에 따라서 하나밖에 가지 않는다. 그러나 마지막 finally는 무조건 타게 된다.
값인 지 오류인 지 모호할 수 있기 때문에 옛날에 쓰는 방식은 좋은 방법이 아니다. 배열은 음수가 없다.
대리자(delegate)와 이벤트! winform에서 버튼을 넣고 값을 바꾸는 것들이 있는 것이다.

대리자란 뭔가를 대신해주는 사람을 의미한다.
콜백: 대신 어떤 일을 해줄 코드를 두고, 세부 실행 코드는 컴파일 시점이 아닌 실행 시점에 부여
콜백을 구현하는 방법 -> 대리자대리자는 메소드에 대한 참조 대리자에 메소드의 주소를 할당, 대리자 호출, 대리자, 메소드 호출
선언 형식매 한정자 delegate 반환 형식 대리자 이름(매개변수_목록)
대리자는 인스턴스가 아니 형식을 의미한다. "값" 아닌 "코드" 자체를 매개변수로 넘기고 싶을 때, 대리자를 이용한다. 기본적으로 C#은 스마트팩토리가 많다. 유지보수가 편하다. C#의 입지가 옛날보다는 좋아지고 있다.
대리자 체인은 호출하고자하는 연산자가 하나 이상이다.
~~~
~~~
3.3 강의필기안
대리자 어떤 일이 생겼을 떄, 이를 알려주는 객체를 만들 때 사용한다.
이벤트 선언과 사용 절차
1) 대리자 선언과 2) 선언한 대리자 인스턴스를 event한정자로 수식 3) 이벤트 핸들러 작성 4) 클래스 인스턴스 생성 후 객체의 이벤트에 이벤트 핸들러 등록 5) 이벤트 발생 -> 이벤트 핸들러 호출
운영체제가 바로 알 수 있는 것도 아니기 때문에 프로그램이 자동으로 인식할 수 있도록 지정해야 한다. 운영체제의 마우스 클릭이 이에 해당한다고 볼 수 있겠다. 엄청나게 많은 이벤트들을 다 등록을 해줘야 제대로 동작을 하게 된다.

람다식
분명하고 간결한 방법으로 함수를 묘사하기 위해 고안한 것이다. 함수의 정의와 변수, 그리고 함수의 적용으로 구성.
제자 존 매카시가 LISP를 만들면서 프로그램에 도입.(오토캐드에 쓰임.) 람다식은 쓰기 싫으면 안써도 됨. 그러나 람다식을 쓰면 코딩량이 줄어든다. 그러나 이해도가 낮아진다. 람다식에 대한 이해도가 높지 않으면 정말 어려울 수 있다.
람다식으로 만든 익명메소드->무명함수(Anonymous Function)이라고 부른다. 매개변수 목록=>식(=>==입력연산자)
람다식을 보통 만드는 이유는 한 번 쓰고 끝낼 때, 로직처리를 위해서 사용한다.

LinQ는 데이터베이스를 쓸 때 어떤 작업을 하느냐 하면 DML을 작동시키는 기본 원리를 시행한다. 처음 주어진 업무는 Insert Delete Select Update이다. DB도 알고 C#도 잘 알면 좋겠지만 C#개발자들이 요걸 잘 모를 수 있다.
쿼리문과 유사하게 만들어서 사용할 수 있게 만든 것이다. LINQ이다. 이걸 쓰게 되면 데이터를 처리하기 위한 쿼리문 개체에서 쓸 수 있는 것을 의미한다. from, where, orderby, select등이 있다. 즉, DB의 검색을 담당하는 구절이다.
group by로 데이터를 분류해야 한다. foreach는 배열에 특화된 조건문이고 for는 로직에 특화된 조건문이다.
from 절은 LINQ에 거의 들어갈 수 있다. 회사의 데드라인에 맞춰서 납품하는 것이 목적이기 때문에 회사의 특성을 잘 맞춰서 개발하는 것이 중요하다.
join은 각 데이터 원본 특정 필드 값을 비교해 일치하는 데이터끼리 연결하는 것이다. 내부조인은 교집합이고 외부조인은 기준이 되는 데이터 원본을 모두 포함하는 것을 의미한다.
String 이라는 키워드를 소문자 s로 래핑해서 만든 것이 소문자 string이다.
실무에서도 파일을 만들 경우가 있다. 네트워크 소켓을 만들고 DB를 연결하고 끊는 것도 쌍으로 이해해야 한다. 
~~~
~~~
3월 5일 강의 필기안
프로세스=> 실행 파일이 실행되어 메모리에 적재된 인스턴스, 하나 이상의 스레드로 구성.
스레드=> 운영체제가 CPU시간을 할당하는 기본 단위.==시분할(콘솔은 싱글 스레드다.) 윈폼은 화면을 그려야 한다. 그림을 그리는 거도 UI스레드가 있어야 한다.
멀티 스레드의 장점은 사용자 대화형 프로그램이라는 것이다. 경제성도 좋고, 스레드 방식이 자원 공유가 쉽다.==적은 하드웨어로 높은 성능을 가지는 프로그램을 쓸 수 있다.

멀티 스레드의 단점. 구현하기도 까다롭고 테스트가 쉽지 않다. 과다한 사용은 성능 저하를 야기하고 작업간 전환을 힘들게 한다. 후킹==스레드를 긁어오는 것을 의미한다. 스레드 자체를 여러 개를 쓰다보니까 디버그를 하기 힘들어진다.
자식스레드에서 문제가 생기면 전체 프로세스에 영향을 끼침. Systme.Threading.Thread 생성자의 매개변수로 실행할 메소드 전달.
ref 확장메서드, this 인덱스 exmerable Monitor/Async&Await
~~~
