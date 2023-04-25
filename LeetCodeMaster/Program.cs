namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { -7, -3, 2, 3, 11 };
            Console.WriteLine(string.Join(",", nums));
            var sortedSquares = SortedSquares(nums);
            Console.WriteLine(string.Join(",", sortedSquares));
        }

        static int[] SortedSquares(int[] nums)
        {
            var c = nums.Length;
            var ans = new int[c];
            var left = 0;
            var right = c - 1;

            for (var i = c - 1; i >= 0; i--)
            {
                int square;
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    square = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    square = nums[right] * nums[right];
                    right--;
                }
                ans[i] = square;
            }
            
            return ans;
        }
    }
}