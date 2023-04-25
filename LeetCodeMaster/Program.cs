namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, World!";
            Console.WriteLine(ReversePrefix(s, 'o'));
        }

        static string ReversePrefix(string word, char ch)
        {
            var c = word.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ch)
                {
                    var left = 0;
                    var right = i;
                    while (left <= right)
                    {
                        (c[left], c[right]) = (c[right], c[left]);
                        left++;
                        right--;
                    }

                    return new string(c);
                }
            }

            return word;
        }
    }
}