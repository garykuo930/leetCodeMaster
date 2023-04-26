namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gain = new int[]{-4,-3,-2,-1,4,3,2};
            Console.WriteLine(LargestAltitude(gain));
        }

        static int LargestAltitude(int[] gain)
        {
            //We can use prefix sum to find the largest point.
            var prefix = new int[gain.Length];
            prefix[0] = gain[0];
            for (var i = 1; i < gain.Length; i++)
            {
                prefix[i] = prefix[i - 1] + gain[i];
            }

            return Math.Max(prefix.Max(), 0);
        }
    }
}