using System;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b);//a와 b를 비교해서 큰 값이든 작은 값이든 골라준다. 신기하네 클래스 안에 있지 않고 밖에 있네??
    //대리자는 값이지만 하나의 클래스로 간주한다는 의미인 듯.
    class Program
    {
        //오름차순 a가 b보다 크면 1 리턴, 같으면 0을 리턴함, a<b이면 -1을 리턴함.
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;//a와 b를 바꿈.
            else if (a == b) return 0;
            else return -1;
        }

        //내림차순 비교, a<b이면 1리턴, 같으면 0, a>b -1 리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;// b와 a를 순서 바꿀 것.
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length; j++)
                {
                    // 비교하여 값 위치 변경. SWAP 메서드와 똑같다.
                    if(comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };

            Console.WriteLine("Sorting...");
            BubbleSort(array, new Compare(AscendCompare));//오름차순으로 정렬한다.
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }

        //동작이 일정치가 않다. 윈폼은 버튼을 누르지 않고 끝날 수도 있다. 사용자에 따라 프로그램이 다르게 동작할 수 있다. 이런 경우를 위해서 delegate를 사용한다.
        //즉 메서드가 아닌 값을 시행하지 않음으로 인해서 논리적 오류를 없애는 것이다. 이것은 사용자라는 객체까지 고려한 코딩방법이다.
        //메서드를 시행하지 않을 경우, 연관된 여러 참조 메서드들이 영향을 받을 수 있으나, 값은 메서드가 아니라서 시행하든 하지 않든 값이 null로 끝나서 안정적이다.
    }
}
