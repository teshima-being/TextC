using System;
using System.Runtime.Serialization;

namespace Practice12_1_4 {

    /// <summary>
    /// 雇用者のID、名前、雇用日を持つ雇用者クラス
    /// </summary>
    [DataContract(Name = "employee")]
    public class Employee {

        /// <summary>
        /// ID
        /// </summary>
        [IgnoreDataMember]
        public int Id { get; }

        /// <summary>
        /// 名前
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// 雇用日
        /// </summary>
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; }

        /// <summary>
        /// Employeeクラスのコンストラクタ
        /// </summary>
        /// <param name="vId">ID</param>
        /// <param name="vName">名前</param>
        /// <param name="vHireDate">雇用日</param>
        public Employee(int vId, string vName, DateTime vHireDate) {
            this.Id = vId;
            this.Name = vName;
            this.HireDate = vHireDate;
        }

        /// <summary>
        /// 結果の確認を容易にするためにToStringメソッドをオーバーライドしています　
        /// </summary>
        /// <returns>Employeeクラスのプロパティを一括確認できる文字列</returns>
        public override string ToString() {
            return $"[Id = {this.Id}, Name = {this.Name}, HireDate = {this.HireDate:d}]";
        }
    }
}
