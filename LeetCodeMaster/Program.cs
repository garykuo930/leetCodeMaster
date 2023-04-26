namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 4, 4 };
            Console.WriteLine(MinSubArrayLen(4,nums));
        }
        
        static int MinSubArrayLen(int target, int[] nums) {
            var res = 0;
            var sum = 0;
            var left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (left <= right && sum >= target)
                {
                    if (left == 0) res = right + 1;
                    sum -= nums[left];
                    res = Math.Min(res, right - left + 1);
                    left++;
                }
            }

            return res;
        }
    }
}