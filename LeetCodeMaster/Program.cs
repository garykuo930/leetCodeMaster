namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        static int SubarraySum(int[] nums, int k)
        {
            var counts = new Dictionary<int, int>();
            var curr = 0;
            var ans = 0;
            
            counts[0] = 1; //The empty array [] is a subarray with sum 0;
            
            for (var i = 0; i < nums.Length; i++)
            {
                curr += nums[i];
                if (counts.ContainsKey(curr - k)) ans += counts[curr - k];
                counts.TryAdd(curr, 0);
                counts[curr]++;
            }

            return ans;
        }
    }
}