namespace Programmers_001
{
    // <summary>
    // 2024년 8월 5일
    // 문제 : 가장 가까운 같은 글자(level 1)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/142086?language=csharp
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "banana";
            int[] answer = new int[s.Length];

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = -1;
            }

            for (int i = 1; i < s.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (s[i] == s[j])
                    {
                        answer[i] = (i - j);
                        break;
                    }
                }
            }
            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i] + " ");
            }

        }
    }
}
