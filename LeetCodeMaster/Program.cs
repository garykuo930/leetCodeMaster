using System.Text;

namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "Test1ng-Leet=code-Q!";
            Console.WriteLine(ReverseOnlyLetters(s));
        }

        static string ReverseOnlyLetters(string s)
        {
            var res = s.ToCharArray();
            var left = 0;
            var right = s.Length - 1;
            while (left <= right)
            {
                if (!char.IsLetter(s[left])) left++;
                else if (!char.IsLetter(s[right])) right--;
                else
                {
                    (res[left], res[right]) = (s[right], s[left]);
                    left++;
                    right--;
                }
            }

            return new string(res);
        }
    }
}