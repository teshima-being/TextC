using System;

namespace Practice1_1_3 {

    //問題1-3-1
    //Personクラスを継承し、Studentクラスを定義してください。
    //Studentには2つのプロパティ、Grade(学年)とClassNumber(組)を追加してください。
    //2つのプロパティとも型はintとします。

    /// <summary>
    /// Studentクラス
    /// </summary>
    internal class Student: Person {
        /// <summary>
        /// 学年
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 組
        /// </summary>
        public int ClassNumber { get; set; }

        /// <summary>
        /// 学年クラスのコンストラクタ
        /// </summary>
        /// <param name="vName">名前</param>
        /// <param name="vGrade">学年</param>
        /// <param name="vClassNumber">組</param>
        /// <param name="vBirthday">誕生日</param>
        public Student(string vName, int vGrade, int vClassNumber, DateTime vBirthday) {
            this.Name = vName;
            this.Grade = vGrade;
            this.ClassNumber = vClassNumber;
            this.Birthday = vBirthday;
        } 
    }
}
