using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Practice12_2_1 {

    /// <summary>
    /// 作家クラス
    /// </summary>
    [XmlRoot("novelist")]
    [DataContract(Name = "novelist")]
    public class Novelist {

        /// <summary>
        /// 氏名
        /// </summary>
        [XmlElement("name")]
        [DataMember(Name = "name")]

        public string Name { get; }

        /// <summary>
        /// 生年
        /// </summary>
        [XmlElement("birth")]
        [DataMember(Name = "birth")]

        public DateTime Birth { get; }

        /// <summary>
        /// 代表作
        /// </summary>
        [XmlArray("masterpieces")]
        [XmlArrayItem("title")]
        [DataMember(Name = "masterpieces")]

        public string[] Masterpieces { get; }

        /// <summary>
        /// 作家クラスのコンストラクタ
        /// </summary>
        /// <param name="vName"名前></param>
        /// <param name="vBirth">生年</param>
        /// <param name="vMasterpieces">代表作</param>
        public Novelist(string vName, DateTime vBirth, string[] vMasterpieces) {
            this.Name = vName;
            this.Birth = vBirth;
            this.Masterpieces = vMasterpieces;
        }

        /// <summary>
        /// 引数なしの既定のコンストラクタ(XMLSerializerのため)
        /// </summary>
        public Novelist() { }

        /// <summary>
        /// 結果の確認を容易にするためにToStringメソッドをオーバーライドしています　
        /// </summary>
        /// <returns>Novelistクラスのプロパティを一括確認できる文字列</returns>
        public override string ToString() {
            return $"[Name = {this.Name}, Birth = {this.Birth:d}, Masterpieces = {string.Join(",", this.Masterpieces)}]";
        }
    }
}
