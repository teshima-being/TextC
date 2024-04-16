
namespace Practice2_1_3 {

    //問題2-1-3
    //作成したSongクラスのインスタンスを複数生成し、配列wSongsに格納してください。
    
    internal class Program {
        static void Main(string[] args) {
            var wSongs = new Song[]{
                new Song("僕のこと","Mrs.GREEN APPLE", 322),
                new Song("again","YUI", 256),
                new Song("真夏の果実","サザンオールスターズ", 279),
                new Song("トイレの神様","植村花菜", 602),
                new Song("乾杯","長渕剛", 331),
            };
        }
    }
}
