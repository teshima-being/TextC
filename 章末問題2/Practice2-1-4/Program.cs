using System;

namespace Practice2_1_4 {

    //問題2-1-4
    //配列に格納されたすべてのSongオブジェクトの内容をコンソールに表示してください。
    //演奏時間の表示は、「4：16」のような書式にしてください。
    //ただし、演奏時間は必ず60分未満と仮定して構いません。

    internal class Program {
        static void Main(string[] args) {

            //Songオブジェクトの配列
            var wSongs = new Song[]{
                new Song("僕のこと","Mrs.GREEN APPLE", 322),
                new Song("again","YUI", 256),
                new Song("真夏の果実","サザンオールスターズ", 279),
                new Song("トイレの神様","植村花菜", 592),
                new Song("乾杯","長渕剛", 331),
            };

            PrintData(wSongs);
        }

        /// <summary>
        /// Songオブジェクトの内容をコンソールに出力する。
        /// なお、演奏時間の表示形式は「m:ss」とする。
        /// </summary>
        /// <param name="vSongs">Songオブジェクトの配列</param>
        static void PrintData(Song[] vSongs) {
            foreach (Song wSong in vSongs) {
                var wSecond = wSong.Length;
                var wTime = new TimeSpan(0, 0, wSecond);
                var wLength = wTime.ToString(@"m':'ss");
                Console.WriteLine($"曲名:{wSong.Title}、歌手:{wSong.ArtistName}、演奏時間 {wLength}");
            }
        }
    }
}
