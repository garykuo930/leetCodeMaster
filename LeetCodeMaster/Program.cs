namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -1, -1, 1, 1, 0, 0 };
            Console.WriteLine(PivotIndex(nums));
        }

        static int PivotIndex(int[] nums)
        {
            var prefix = new int[nums.Length + 1];
            prefix[0] = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                prefix[i + 1] = prefix[i] + nums[i];
            }

            var total = prefix[^1];
            for (var i = 0; i < nums.Length; i++)
            {
                if (total - nums[i] == prefix[i] * 2) return i;
            }

            return -1;
        }
    }
}