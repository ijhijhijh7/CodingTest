namespace Programmers_008
{
    // <summary>
    // 2024년 8월 9일
    // 문제 : 문자열 내 마음대로 정렬하기(level 1)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/12915
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "abce", "abcd", "cdx" };
            string[] answer = new string[strings.Length];
            int n = 2;
            int compareNString;
            string temp;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length - 1 - i; j++)
                {
                    compareNString = strings[j][n].CompareTo(strings[j + 1][n]);

                    if (compareNString > 0 || (compareNString == 0 && string.Compare(strings[j], strings[j + 1]) > 0))
                    // 문자열 비교시 값이 큰 경우 교체
                    // 같을 시 해당 문자열의 처음부터 사전순으로 값을 비교하여 앞의 문자열이 큰 경우 교체
                    {
                        temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < strings.Length; i++)
            {
                answer[i] = strings[i];
            }
            /*for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }*/
        }
    }
}
