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
![네이버주소록](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EB%A1%9D.png )<br> 
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
## 2. 주소록의 코드창과 출력화면 생성해보기.
### 콘솔창에서 바라본 출력화면<br>
가장 먼저 프로그램의 동작 화면부터 살펴보고, 공부한 내용을 기입해 보도록 하겠다.<br>

1. 시작화면
-----------

<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%B6%9C%EB%A0%A5%ED%99%94%EB%A9%B4.png" width="40" height="30 ><br>
콘솔창의 초기 출력화면이다.

2.  주소입력
------------
![주소입력](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%9E%85%EB%A0%A5.png)<br>
1번을 누르고 다음과 같은 주소를 입력해 보았다.

3. 주소검색
----------------
![주소검색](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%89.png)<br>
2번을 누르고
