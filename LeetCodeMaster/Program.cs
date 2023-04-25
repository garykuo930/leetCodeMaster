namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new []{ 10, 4, -8, 7 };
            Console.WriteLine(WaysToSplitArray(nums));
        }
        
        static int WaysToSplitArray(int[] nums) {
            //create prefix sum
            var prefix = new long[nums.Length];
            prefix[0] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            //find the answer
            var ans = 0;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                var left = prefix[i];
                var right = prefix[^1] - left;
                if (left >= right) ans++;
            }

            return ans;
        }
    }
}