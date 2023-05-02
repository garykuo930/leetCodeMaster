namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "thequickbrownfoxjumpsoverthelazydog";
            Console.WriteLine(CheckIfPangram(sentence));
        }
        
        static bool CheckIfPangram(string sentence)
        {
            var set = new HashSet<char>();
            foreach (var c in sentence)
            {
                set.Add(c);
            }

            return set.Count == 26;
        }
    }
}