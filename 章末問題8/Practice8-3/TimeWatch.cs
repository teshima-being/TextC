using System;

namespace Practice8_3 {

    /// <summary>
    /// 処理時間を計測するTimeWatchクラス
    /// </summary>
    internal class TimeWatch {
        
        private DateTime FTimeStamp;

        /// <summary>
        /// メソッド実行時の時刻を取得します。
        /// </summary>
        public void Start() {
            this.FTimeStamp = DateTime.Now;
        }

        /// <summary>
        /// Startメソッド実行時の時刻とStopメソッド実行時の時刻の時間差を取得します。
        /// Startメソッドが実行されていなかった場合はTimeSpan値0を返します。
        /// </summary>
        /// <returns>Start実行時の時刻ととStop実行時の時刻の時間差</returns>
        public TimeSpan Stop() {
            if (this.FTimeStamp == new DateTime()) {
                Console.WriteLine("Startがされていないため計測できません。");
                return TimeSpan.Zero;
            }
            return DateTime.Now - this.FTimeStamp;
        }
    }
}