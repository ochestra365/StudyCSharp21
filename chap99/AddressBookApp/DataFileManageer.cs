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
            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));//Open
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
}
