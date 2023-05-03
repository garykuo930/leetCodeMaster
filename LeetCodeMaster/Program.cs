namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var map = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                var key = new string(chars);
                if (map.ContainsKey(key))
                {
                    map[key].Add(str);
                }
                else
                {
                    map.Add(key, new List<string> {str});
                }
            }

            return map.Values.ToList();
        }
    }
}