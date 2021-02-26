using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DBConnTestApp
{
    class DBhelper//인터페이스 구현 db 접속, sql 서버의 시스템 클래스를 참조한다. 그리고 위에서 해당 시스템 자원들을 사용하겠다고 선언한다.
        //호환성은 좋고 이식성은 약하다. 왜냐하면 다른 프로그램의 시스템까지 자원으로 사용하겠다고 선언하면 참조할 수 있기 때문이다. 그러나
        //해당 인터페이스의 참조를 선언해주지 않으면 그 내용을 알지 못하기 때문에 이식성은 약하다.
        //따라서 코드내용을 보안할 수 있다는 차원에서 캡슐화(은닉성) 속성이 강해진다.
    {
        public IDbConnection GetDbConnection()//시스템 데이터 자원을 사용해줘야 해당 IDb에 접근할 수 있다.
        {
            IDbConnection dbcon = null;//초기에 IDB연결은 존재하지 않는다.
            string connString = ConfigurationManager.AppSettings["Connection"];//연결자 선언 및 할당. 
            var DBType = ConfigurationManager.AppSettings["DbType"];//[]는 데이터베이스 코드블락에 해당한다.
            switch(DBType)
            {
                case " SQLServer":
                    dbcon = new SqlConnection(connString);//sql 연결을 초기화한다.
                    break;
                case "Oracle":
                    dbcon = new OracleConnection(connString);//오라클 연결을 초기화한다.
                    break;//break는 해당 구문을 빠져 나가겠다는 의미
                default://null값이다. 참조할 게 없으면 끝낸다.
                    break;
            }
            return dbcon;// 해당 케이스를 호출한다.
        }
    }
    //인터페이스는 다중상속의 문제점을 해결하기 위해 사용하는 것이다.
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
