namespace LeetCodeMaster
{
    internal class Program
    {
        static readonly char[] Lookup = new[] { 'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {
            Console.WriteLine(MaxVowels("ibpbhixfiouhdljnjfflpapptrxgcomvnb", 33));
        }

        static int MaxVowels(string s, int k)
        {
            var curr = 0;

            for (var i = 0; i < k; i++)
            {
                curr += VowelCount(s[i]);
            }
            
            var res = curr;
            for (var right = k; right < s.Length; right++)
            {
                curr += VowelCount(s[right]) - VowelCount(s[right - k]);
                res = Math.Max(res, curr);
            }

            return res;
        }

        static int VowelCount(char c)
        {
            return Lookup.Contains(c) ? 1 : 0;
        }
    }
}