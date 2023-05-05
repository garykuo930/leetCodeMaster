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
            MyFunction();

            // 停止計時
            stopwatch.Stop();

            // 輸出執行時間
            Console.WriteLine("MyFunction 執行時間：{0}", stopwatch.Elapsed);
        }

        static void MyFunction()
        {
            // 在此撰寫你要評估執行時間的function
            for (int i = 0; i < 100000000; i++)
            {
                // do something
            }
        }
    }
}