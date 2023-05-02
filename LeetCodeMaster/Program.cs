using System.Collections;

namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static IList<int> Intersection(int[][] nums)
        {
            var counts = new Dictionary<int, int>();
            foreach (var subNums in nums)
            {
                foreach (var num in subNums)
                {
                    if (counts.ContainsKey(num))
                    {
                        counts[num]++;
                    }
                    else
                    {
                        counts.Add(num, 1);
                    }
                }
            }

            var ans =
                counts.Where(c => c.Value == nums.Length)
                    .Select(c => c.Key)
                    .OrderBy(n => n)
                    .ToList();

            return ans;
        }
    }
}