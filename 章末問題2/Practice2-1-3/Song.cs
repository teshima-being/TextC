
namespace Practice2_1_3 {

    /// <summary>
    /// 以下のプロパティを持つSongクラス
    /// Title：string型(歌のタイトル)
    /// ArtistName：string型(アーティスト名)
    /// Length：int型(演奏時間)
    /// </summary>
    internal class Song {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        //コンストラクタ
        public Song(string vTitle, string vArtistName, int vLength) {
            this.Title = vTitle;
            this.ArtistName = vArtistName;
            this.Length = vLength;
        }
    }
}
