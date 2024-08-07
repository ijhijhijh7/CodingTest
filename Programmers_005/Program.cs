namespace Programmers_005
{

    // <summary>
    // 2024년 8월 7일
    // 문제 : 약수의 개수와 덧셈(level 1)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/77884
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            int answer = 0;
            int left = 13;
            int right = 17;

            List<int>[] list = new List<int>[right - left + 1];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new List<int>();
                int currentNumber = left + i;
                for (j = 1; j * j < currentNumber; j++)
                {
                    if (currentNumber % j == 0)
                    {
                        list[i].Add(j);
                        list[i].Add((left + i) / j);
                    }
                }
                if (j * j == (left + i))
                {
                    list[i].Add(j);
                }
                list[i].Sort();
            }
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Count % 2 == 0)
                {
                    answer += left + i;
                }
                else
                {
                    answer -= left + i;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
