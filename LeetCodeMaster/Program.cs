namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { -2, 0, 3, -5, 2, -1 };
            var arr = new NumArray(nums);
            Console.WriteLine(arr.SumRange(2, 5));
        }
    }
    
    public class NumArray
    {
        private readonly int[] _source;
        private readonly int[] _prefixSum;
        public NumArray(int[] nums)
        {
            _source = nums;
            _prefixSum = new int[nums.Length];
            _prefixSum[0] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                _prefixSum[i] = _prefixSum[i - 1] + nums[i];
            }
        }
    
        public int SumRange(int left, int right)
        {
            return _prefixSum[right] - _prefixSum[left] + _source[left];
        }
    }
}