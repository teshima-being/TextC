using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice7_2_1 {

    /// <summary>
    /// 組織名の略語と対応する日本語を管理するクラス
    /// </summary>
    public class Abbreviations {

        private Dictionary<string, string> FOrganizationsDic = new Dictionary<string, string>();

        /// <summary>
        /// Countプロパティ
        /// </summary>
        public int Count {
            get { return this.FOrganizationsDic.Count; }
        }

        /// <summary>
        /// Abbreviationsクラスのコンストラクタ
        /// </summary>
        public Abbreviations() {
            string[] wDataLines = File.ReadAllLines(@"..\..\AbbreViations.txt");
            this.FOrganizationsDic = wDataLines.Select(x => x.Split('=')).ToDictionary(x => x[0], x => x[1]);
        }

        /// <summary>
        /// Abbreviationsクラスに要素を追加します。
        /// </summary>
        /// <param name="vAbbreviation">組織の略語</param>
        /// <param name="vJapaneseName">組織の日本語名</param>
        public void Add(string vAbbreviation, string vJapaneseName) {
            this.FOrganizationsDic[vAbbreviation] = vJapaneseName;
        }

        /// <summary>
        /// 略語をキーに取るインデクサ
        /// </summary>
        /// <param name="vAbbreviation"></param>
        /// <returns></returns>
        public string this[string vAbbreviation] {
            get {
                return this.FOrganizationsDic.ContainsKey(vAbbreviation) ? FOrganizationsDic[vAbbreviation] : null;
            }
        }

        /// <summary>
        /// 引数に受け取った略語をキーに持つ要素を削除します。
        /// 正常に削除された場合はtrue、要素が見つからなかった場合はfalseを返します。
        /// </summary>
        /// <param name="vAbbreviation">組織の略語</param>
        /// <returns>bool値</returns>
        public bool Remove(string vAbbreviation) {
            if (!this.FOrganizationsDic.ContainsKey(vAbbreviation)) return false;

            this.FOrganizationsDic.Remove(vAbbreviation);
            return true;
        }

        /// <summary>
        /// 文字数を引数に取り、略語の文字数が指定された文字数と一致する要素(KeyValuePair<string, string>型)
        /// をすべて返します。
        /// </summary>
        /// <param name="vWordCount">文字数</param>
        /// <returns>条件を満たすKeyValuePair</returns>
        public IEnumerable<KeyValuePair<string, string>> SearchOrgsWithWordCount(int vWordCount) {
            return this.FOrganizationsDic.Where(x => x.Key.Length == vWordCount);
        }
    }
}
