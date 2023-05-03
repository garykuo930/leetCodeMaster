namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MinimumCardPickup(int[] cards)
        {
            var map = new Dictionary<int, int>();
            var ans = int.MaxValue;
            for (int i = 0; i < cards.Length; i++)
            {
                var card = cards[i];
                if (map.ContainsKey(card))
                {
                    ans = Math.Min(ans, i - map[card] + 1);
                    map[card] = i;
                }
                else
                {
                    map.Add(card, i);
                }
            }

            return ans == int.MaxValue ? -1 : ans;
        }
    }
}