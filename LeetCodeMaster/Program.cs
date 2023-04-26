namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EqualSubstring("abcd", "cdef", 3));
        }
        
        static int EqualSubstring(string s, string t, int maxCost)
        {
            var start = 0;
            var end = 0;
            var cost = 0;
        
            while (end < s.Length)
            {
                cost += Math.Abs(s[end] - t[end]);
                if (cost > maxCost)
                {
                    cost -= Math.Abs(s[start] - t[start]);
                    start++;
                }
                end++;
            }

            return end - start;
        }
    }
}