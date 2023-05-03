namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MaxNumberOfBalloons(string text)
        {
            var target = "balloon";
            var requires = target.ToCharArray().GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var counts = text.ToCharArray().Where(x => requires.ContainsKey(x)).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return requires.Min(x => counts.TryGetValue(x.Key, out var count) ? count / x.Value : 0);
        }
    }
}