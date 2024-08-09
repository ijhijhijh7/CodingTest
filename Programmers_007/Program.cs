namespace Programmers_007
{
    // <summary>
    // 2024년 8월 9일
    // 문제 : 중앙값 구하기(level 0)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/120811
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 10, 11, 7};
            int answer = 0;
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(array[array.Length / 2]);
            /*for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/
        }
    }
}
