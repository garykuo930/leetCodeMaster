namespace LeetCodeMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString(new[] { 'h', 'e', 'l', 'l', 'o' });
        }
        
        static void ReverseString(char[] s) {
            var left = 0;
            var right = s.Length - 1;
        
            while(left < right){
                (s[right], s[left]) = (s[left], s[right]);
                left++;
                right--;
            }
        }
    }
}