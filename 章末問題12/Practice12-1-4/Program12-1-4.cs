using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Practice12_1_4 {
    internal class Program {

        //問題12-1-4
        //複数のEmployeeオブジェクトが配列に格納されているとします。この配列をDataContractJsonSerializerを
        //使って、JSONファイルに出力してください。この時のシリアル化対象にIdは含めないでください。

        static void Main(string[] args) {

            var wEmployees = new[]{
                new Employee (1, "総務太郎", new DateTime(1993,4,1)),
                new Employee (2, "三重花子", new DateTime(2000,10,1)),
                new Employee (3, "事務健太", new DateTime(2012, 7,1)),
                new Employee (4, "名張美佳", new DateTime(2020, 5,1)),
                new Employee (5, "美旗浩二", new DateTime(2024, 4,1)),
            };

            using (var wStream = new FileStream(@"..\..\employees.json", FileMode.Create, FileAccess.Write)) {
                var wSerializer = new DataContractJsonSerializer(wEmployees.GetType());
                wSerializer.WriteObject(wStream, wEmployees);
            }
            Console.WriteLine("シリアル化が完了しました。");
        }
    }
}
