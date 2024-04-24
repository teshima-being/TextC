namespace Practice2_1_3 {

    /// <summary>
    /// 以下のプロパティを持つSongクラス
    /// Title：string型(歌のタイトル)
    /// ArtistName：string型(アーティスト名)
    /// Length：int型(演奏時間)
    /// </summary>
    internal class Song {

        /// <summary>
        /// 歌のタイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// アーティスト名
        /// </summary>
        public string ArtistName { get; set; }

        /// <summary>
        /// 演奏時間
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Songクラスのコンストラクタ
        /// </summary>
        /// <param name="vTitle">歌のタイトル</param>
        /// <param name="vArtistName">アーティスト名</param>
        /// <param name="vLength">演奏時間</param>
        public Song(string vTitle, string vArtistName, int vLength) {
            this.Title = vTitle;
            this.ArtistName = vArtistName;
            this.Length = vLength;
        }
    }
}
