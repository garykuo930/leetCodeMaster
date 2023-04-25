namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            var res = string.Join(" ", s.Split(" ").Select(w => Reverse(w)));
            Console.WriteLine(res);
        }
        
        static string Reverse(string s)
        {
            var res = new char[s.Length];
            var left = 0;
            var right = s.Length - 1;
            while (left <= right)
            {
                (res[left], res[right]) = (s[right], s[left]);
                left++;
                right--;
            }
            return string.Join("", res);
        }
    }
}