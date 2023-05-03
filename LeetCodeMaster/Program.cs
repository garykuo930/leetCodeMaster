namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        static List<int>[] FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);
            var ans1 = set1.Where(n => !set2.Contains(n)).ToList();
            var ans2 = set2.Where(n => !set1.Contains(n)).ToList();

            return new[] { ans1, ans2 };
        }
    }
}