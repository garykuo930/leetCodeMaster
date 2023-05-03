namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int EqualPairs(int[][] grid)
        {
            var rowMap = grid.GroupBy(ParseToString).ToDictionary(x => x.Key, x => x.Count());
            var colMap = new int[grid[0].Length].Select((_, i) => GetColumn(grid, i)).GroupBy(ParseToString).ToDictionary(x => x.Key, x => x.Count());
            var answer = rowMap.Sum(row => colMap.TryGetValue(row.Key, out var value) ? row.Value * value : 0);
            return answer;
        }

        private static int[] GetColumn(int[][] grid, int col)
        {
            var curr = new int[grid.Length];
            for (int row = 0; row < grid.Length; row++)
            {
                curr[row] = grid[row][col];
            }

            return curr;
        }

        private static string ParseToString(int[] nums)
        {
            return string.Join(",", nums);
        }
    }
}