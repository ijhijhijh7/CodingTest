namespace Programmers_001
{
    // <summary>
    // 2024년 8월 12일
    // 문제 :
    // URL :
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
