namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            Console.WriteLine(string.Join("", nums));
        }
        
        static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1) return;
        
            var slow = 0;
            var fast = 0;

            while (fast < nums.Length)
            {
                if (nums[fast] != 0)
                {
                    (nums[slow], nums[fast]) = (nums[fast], nums[slow]);
                    slow++;
                }

                fast++;
            }
        }
    }
}