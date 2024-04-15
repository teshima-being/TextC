using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3 {

    //問題1-3-1
    //Personクラスを継承し、Studentクラスを定義してください。
    //Studentには2つのプロパティ、Grade(学年)とClassNumber(組)を追加してください。
    //2つのプロパティとも型はintとします。
    internal class Student: Person {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }

        //コンストラクタ
        public Student(string vName, int vGrade, int vClassNumber, DateTime vBirthday) {
            this.Name = vName;
            this.Grade = vGrade;
            this.ClassNumber = vClassNumber;
            this.Birthday = vBirthday;
        } 
    }
}
