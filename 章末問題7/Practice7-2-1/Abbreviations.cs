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
            string[] wDataLines = File.ReadAllLines(@"\\being.group\Being-組織\システム開発課\Doc\中途入社研修\20240401-シャレッチョ・手島悠介\手島悠介\C#テキスト《イディオム》\AbbreViations.txt");
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
        /// 日本語名から対応する組織の略語を取り出します。
        /// </summary>
        /// <param name="vJapaneseName">組織の日本語名</param>
        /// <returns>組織の略語</returns>
        public string ToAbbreviation(string vJapaneseName) {
            return this.FOrganizationsDic.FirstOrDefault(x => x.Value == vJapaneseName).Key;
        }

        /// <summary>
        /// 文字列を引数に与え、Valueの値にその文字列が含まれる要素(Key、Value)をすべて取り出します。
        /// </summary>
        /// <param name="vSubstring"></param>
        /// <returns>組織の日本語名に指定文字列を含む要素(Key, Value)の全て</returns>
        public IEnumerable<KeyValuePair<string, string>> FindAll(string vSubstring) {
            foreach (var wItem in this.FOrganizationsDic) {
                if (wItem.Value.Contains(vSubstring)) {
                    yield return wItem;
                }
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
