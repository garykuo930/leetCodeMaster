namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MaximumSum(int[] nums)
        {
            var map = new Dictionary<int, int>();
            var sum = 0;
            foreach (var num in nums)
            {
                var key = GetDigitSum(num);
                if (map.ContainsKey(key))
                {
                    sum = Math.Max(sum, map[key] + num);
                    map[key] = Math.Max(map[key], num);
                }
                else
                {
                    map.Add(key, num);
                }
            }

            return sum;
        }

        public int GetDigitSum(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}