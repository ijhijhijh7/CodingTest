using System.Drawing;

namespace Programmers_003
{
    // <summary>
    // 2024년 8월 6일
    // 문제 : 최소직사각형(level 1)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/86491
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] sizes1 = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            for (int i = 0; i < sizes1.Length / 2; i++)
            {
                if (sizes1[i, 0] > sizes1[i, 1])
                {
                    int temp = sizes1[i, 1];
                    sizes1[i, 1] = sizes1[i, 0];
                    sizes1[i, 0] = temp;
                }
            }
            int first_MaxNum = sizes1[0, 0];
            int second_MaxNum = sizes1[0, 1];
            
            for (int i = 1; i < sizes1.Length / 2; i++)
            {
                if (sizes1[i, 0] > first_MaxNum)
                {
                    first_MaxNum = sizes1[i, 0];
                }
                if (sizes1[i, 1] > second_MaxNum)
                {
                    second_MaxNum = sizes1[i, 1];
                }
            }
            int rectangular_Size = first_MaxNum * second_MaxNum;
            Console.WriteLine(rectangular_Size);
        }
    }
}
