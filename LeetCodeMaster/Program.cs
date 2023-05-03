namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var ans = new List<IList<int>>();
            Array.Sort(nums);
            var start = 0;

            while (start <= nums.Length - 2)
            {
                var target = 0 - nums[start];
                var left = start + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var sum = nums[left] + nums[right];
                    if (sum < target) left++;
                    else if (sum > target) right--;
                    else
                    {
                        var list = new List<int> { nums[start], nums[left], nums[right] };
                        ans.Add(list);
                        while (left < right && nums[left] == list[1]) left++;
                        while (left < right && nums[right] == list[2]) right--;
                    }
                }

                var curr = nums[start];
                while (start <= nums.Length - 2 && nums[start] == curr) start++;
            }

            return ans;
        }
    }
}