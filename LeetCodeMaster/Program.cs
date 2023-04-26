namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddDigits(38));
        }

        static int AddDigits(int num)
        {
            var curr = 0;
            curr += num % 10;
            num /= 10;

            if (num > 0)
            {
                curr = AddDigits(num + curr);
            }

            return curr;
        }
    }
}