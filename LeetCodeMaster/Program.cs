using System.Diagnostics;

namespace LeetCodeMaster
{
    class Program
    {
        static void Main()
        {
            // 建立Stopwatch物件
            Stopwatch stopwatch = new Stopwatch();

            // 開始計時
            stopwatch.Start();

            // 要評估執行時間的function
            IsIsomorphic("add", "egg");

            // 停止計時
            stopwatch.Stop();

            // 輸出執行時間
            Console.WriteLine("IsIsomorphic 執行時間：{0}", stopwatch.Elapsed);
        }

        static bool IsIsomorphic(string s, string t)
        {
            var map1 = new Dictionary<char, char>();
            var map2 = new Dictionary<char, char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (!map1.ContainsKey(s[i]) && !map2.ContainsKey(t[i]))
                {
                    map1.Add(s[i], t[i]);
                    map2.Add(t[i], s[i]);
                }
                else if (!(map1.ContainsKey(s[i]) && map1[s[i]] == t[i] && map2.ContainsKey(t[i]) &&
                           map2[t[i]] == s[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}