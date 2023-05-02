namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        static int NumberOfSubarrays(int[] nums, int k)
        {
            var counts = new Dictionary<int, int>() { { 0, 1 } };
            int curr = 0, ans = 0;

            foreach (var num in nums)
            {
                curr += num % 2;
                var prefix = curr - k;
                if (counts.TryGetValue(prefix, out var count)) ans += count;
                counts.TryAdd(curr, 0);
                counts[curr]++;
            }

            return ans;
        }
    }
}