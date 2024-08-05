namespace Programmers_002
{
    // <summary>
    // 2024년 8월 5일
    // 문제 : 달리기 경주(level 1)
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/178871
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = { "mumu", "soe", "poe", "kai", "mine" };
            string[] callings = { "kai", "kai", "mine", "mine" };

            List<string> playersList = new List<string>(players);
            Dictionary<string, int> playerInfo = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                playerInfo[players[i]] = i;
            }

            foreach (string calling in callings)
            {
                int CallNum = playerInfo[calling];
                string temp = playersList[CallNum];
                playersList[CallNum] = playersList[CallNum - 1];
                playersList[CallNum - 1] = temp;

                playerInfo[playersList[CallNum]] = CallNum;
                playerInfo[playersList[CallNum - 1]] = CallNum - 1;
            }

            foreach (string player in playersList)
            {
                Console.WriteLine(player);
            }
        }
    }
}
