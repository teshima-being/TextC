using System;

namespace Practice8_3 {
    internal class Program {

        //ある処理時間を計測するTimeWatchクラスを定義してください。TimeWatchの使い方を以下に示します。
        // var tw = new TimeWatch();
        // tw.Start();
        //　（処理）
        // TimeSpan duration = tw.Stop();
        // Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);

        static void Main(string[] args) {

            var wStopWatch = new TimeWatch();
            wStopWatch.Start();

            string wName = string.Empty;
            for (int wNum = 0; wNum < 10000; wNum++) {
                wName = wName + "もちもち";
            }

            TimeSpan wDuration = wStopWatch.Stop();
            Console.WriteLine($"処理時間は{wDuration.TotalMilliseconds}ミリ秒でした");
        }
    }
}
