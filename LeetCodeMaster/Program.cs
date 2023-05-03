namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static IList<IList<int>> FindWinners(int[][] matches)
        {
            var losesCount = new Dictionary<int, int>();
            foreach (var match in matches)
            {
                var winner = match[0];
                var loser = match[1];
                losesCount.TryAdd(winner, 0);
                losesCount.TryAdd(loser, 0);
                losesCount[loser]++;
            }

            var winners = new List<int>();
            var loseOneGame = new List<int>();

            foreach (var count in losesCount)
            {
                if (count.Value == 0) winners.Add(count.Key);
                else if (count.Value == 1) loseOneGame.Add(count.Key);
            }
            
            winners.Sort();
            loseOneGame.Sort();
            
            return new List<IList<int>> { winners, loseOneGame };
        }
    }
}