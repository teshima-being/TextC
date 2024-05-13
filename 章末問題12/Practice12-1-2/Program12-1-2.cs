using System;
using System.Runtime.Serialization;
using System.Xml;
using Practice12_1_1;

namespace Practice12_1_2 {
    internal class Program {

        //問題12-1-2
        //複数のEmployeeオブジェクトが配列に格納されているとします。この配列をDataContractSerializerクラスを
        //使ってXMLファイルにシリアル化してください。

        static void Main(string[] args) {

            var wEmployees = new[]{
                new Employee (1, "総務太郎", new DateTime(1993, 4, 1)),
                new Employee (2, "三重花子", new DateTime(2000, 10, 1)),
                new Employee (3, "事務健太", new DateTime(2012, 7, 1)),
                new Employee (4, "名張美佳", new DateTime(2020, 5, 1)),
                new Employee (5, "美旗浩二", new DateTime(2024, 4, 1)),
            };

            //タグ毎に改行とインデントする設定
            var wSettings = new XmlWriterSettings() {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " "
            };

            //Employee配列をシリアル化する
            using (var wWriter = XmlWriter.Create(@"..\..\employees.xml", wSettings)) {
                var wSerializer = new DataContractSerializer(wEmployees.GetType());
                wSerializer.WriteObject(wWriter, wEmployees);
            }
            Console.WriteLine("シリアル化が完了しました。");
        }
    }
}
