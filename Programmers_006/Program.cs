namespace Programmers_006
{
    // <summary>
    // 2024년 8월 7일
    // 문제 : 가장 큰수 찾기(level 0)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/120899
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 10, 11, 8 };
            int[] answer = new int[2];
            answer[0] = array[0];
            answer[1] = 0;
            /*int maxNum = array[0];
            int maxIndex = 0;*/


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > answer[0])
                {
                    answer[0] = array[i];//maxNum
                    answer[1] = i;//maxIndex
                }
            }
            Console.WriteLine($"{answer[0]}, {answer[1]}");
            /*for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/    
        }
    }
}
