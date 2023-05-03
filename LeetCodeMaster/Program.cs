namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        static int LargestUniqueNumber(int[] nums) {
            var seen = new HashSet<int>();
            var candidates = new List<int>();        
        
            foreach(var num in nums){            
                if(seen.Contains(num)){
                    candidates.Remove(num);
                }else{
                    candidates.Add(num);
                }
                seen.Add(num);            
            }
        
            return candidates.Any() ? candidates.Max() : -1;        
        }
    }
}