using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Practice12_1_1 {
    internal class Program {

        //問題12-1-1
        //以下のEmployeeクラスが定義されています。このオブジェクトをXMLにシリアル化するコードと逆シリアル化するコードを、
        //XmlSerializerクラスを使って書いてください。このとき、XMLの要素名(タグ名)はすべて小文字にしてください。

        /*
        public class Employee {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime HireDate { get; set; }
        }
        */

        static void Main(string[] args) {

            var wEmployee = new Employee(1, "総務太郎", new DateTime(2024, 4, 1));

            //タグ毎に改行とインデントする設定
            var wSettings = new XmlWriterSettings() {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            //保存先のパスの指定
            string wXmlFilePath = @"..\..\employee.xml";

            if (File.Exists(wXmlFilePath)) {
                //オブジェクトを逆シリアル化する
                using (var wReader = XmlReader.Create(wXmlFilePath)) {
                    var wSerializer = new XmlSerializer(typeof(Employee));
                    var wOutputEmployee = wSerializer.Deserialize(wReader) as Employee;

                    //確認用
                    Console.WriteLine(wOutputEmployee.ToString());
                }
                File.Delete(wXmlFilePath); //演習中に繰り返し確認するため
            } else {
                //オブジェクトをシリアル化する
                using (var wWriter = XmlWriter.Create(wXmlFilePath, wSettings)) {
                    var wSerializer = new XmlSerializer(wEmployee.GetType());
                    wSerializer.Serialize(wWriter, wEmployee);

                    Console.WriteLine("オブジェクトのシリアル化が完了しました。");
                }
            }
        }
    }
}
