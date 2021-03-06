﻿using System;
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
    //연산속도만 빠를 뿐이지 컴퓨터는 빡대가리다.
}
