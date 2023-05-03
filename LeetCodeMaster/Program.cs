namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length < ransomNote.Length) return false;
            
            var source = magazine.ToCharArray().GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var c in ransomNote)
            {
                if (!source.ContainsKey(c) || source[c] == 0)
                {
                    return false;
                }

                source[c]--;
            }

            return true;
        }
    }
}