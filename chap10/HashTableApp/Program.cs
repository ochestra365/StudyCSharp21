using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제");

            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";//foreach로 바로 안됨.

            Console.WriteLine(ht["일"]);//One

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");//키 값에 상응하는 값을 출력한다는 콘솔 창 의미이다.
            }

            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            ArrayList list2 = new ArrayList(new int[] { 123, 456, 789 });
            ArrayList list3 = new ArrayList() {123,456,789 };
        }
    }
}
