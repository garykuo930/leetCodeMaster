namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "aaabb";
            Console.WriteLine(AreOccurrencesEqual(str));
        }

        static bool AreOccurrencesEqual(string s)
        {
            // var lookup = s.ToCharArray().GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            var map = new Dictionary<char, int>();
            foreach (var c in s)
            {
                map.TryAdd(c, 0);
                map[c]++;
            }
            var set = new HashSet<int>(map.Values);
            return set.Count == 1;
        }
    }
}