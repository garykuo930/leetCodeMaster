namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        public int NumJewelsInStones(string jewels, string stones) {
            var set = new HashSet<char>(jewels.ToCharArray());
            var sum = 0;
            foreach(var s in stones){
                if(set.Contains(s)) sum++;
            }
            return sum;
        }
    }
}