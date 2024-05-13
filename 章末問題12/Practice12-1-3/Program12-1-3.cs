using System;
using System.Runtime.Serialization;
using System.Xml;
using Practice12_1_1;

namespace Practice12_1_3 {
    internal class Program {

        //問題12-1-3
        //12-1-2で作成したファイルを読み込み、逆シリアル化してください。

        static void Main(string[] args) {

            using (var wReader = XmlReader.Create(@"..\..\..\Practice12-1-2\employees.xml")) {
                var wSerializer = new DataContractSerializer(typeof(Employee[]));
                var wEmployees = wSerializer.ReadObject(wReader) as Employee[];

                //結果確認用
                foreach (var wEmployee in wEmployees) {
                    Console.WriteLine(wEmployee.ToString());
                }
            }
        }
    }
}
