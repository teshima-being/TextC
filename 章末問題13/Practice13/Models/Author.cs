using System;
using System.Collections.Generic;

namespace Practice13.Models {
    /// <summary>
    /// 著者クラス
    /// </summary>
    public class Author {

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// 氏名
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 生年
        /// </summary>
        public DateTime Birthday { get; private set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; private set; }

        /// <summary>
        /// 著作
        /// </summary>
        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        /// 著者クラスのコンストラクタ
        /// </summary>
        /// <param name="vName">氏名</param>
        /// <param name="vBirthday">生年</param>
        /// <param name="vGender">性別</param>
        public Author(string vName, DateTime vBirthday, string vGender) {
            this.Name = vName;
            this.Birthday = vBirthday;
            this.Gender = vGender;
        }

        /// <summary>
        /// 引数なしの著者クラスのコンストラクタ
        /// </summary>
        public Author() { }
    }
}
