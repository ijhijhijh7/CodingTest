namespace Programmers_004
{
    // <summary>
    // 2024년 8월 7일
    // 문제 : 시저 암호(level 1)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/12926
    // <summary>
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string s = "a B z";
            string answer = "";
            int n = 4;
            int count;
            int ascii_l = 65;
            int ascii_s = 97;
            char[] stringsLarge = new char[26];
            char[] stringSmall = new char[26];
            for (int i = 0; i < 26; i++)
            {
                stringsLarge[i] = Convert.ToChar(ascii_l + i);
                stringSmall[i] = Convert.ToChar(ascii_s + i);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    if (s[i] + n > 'Z')
                    {
                        count = s[i] + n - 'Z'- 1;
                        answer += stringsLarge[count];
                    }
                    else
                    {
                        answer += (char)(s[i] + n);
                    }
                }
                else if (s[i] >= 'a' && s[i] <= 'z')
                {
                    if (s[i] + n > 'z')
                    {
                        count = s[i] + n - 'z' - 1;
                        answer += stringSmall[count];
                    }
                    else
                    {
                        answer += (char)(s[i] + n);
                    }
                }
                else
                {
                    answer += (char)(s[i]);
                }
            }
            Console.WriteLine(answer);
        }
    }

    
}
