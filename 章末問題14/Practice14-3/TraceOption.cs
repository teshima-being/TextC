using System.Configuration;

namespace Practice14_3 {
    /// <summary>
    /// トレース設定クラス
    /// </summary>
    public class TraceOption : ConfigurationElement {

        /// <summary>
        /// トレースの可否判定
        /// </summary>
        [ConfigurationProperty("enabled")]
        public bool Enabled {
            get { return (bool)this["enabled"]; }
        }

        /// <summary>
        /// ファイルパス
        /// </summary>
        [ConfigurationProperty("filePath")]
        public string FilePath {
            get { return (string)this["filePath"]; }
        }

        /// <summary>
        /// バッファサイズ
        /// </summary>
        [ConfigurationProperty("bufferSize")]
        public int BufferSize {
            get { return (int)this["bufferSize"]; }
        }
    }
}
