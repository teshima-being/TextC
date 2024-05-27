using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;
using Practice12_2_1;

namespace Practice12_2_2 {
    internal class Program {

        //問題12-2-2
        //12-2-1で作成したNovelistオブジェクトの内容を以下のようなJSONファイルにシリアル化するコードを書いてください。

        /*
        {"birth":"1917-12-16T00:00:00Z","masterpieces":["2001年宇宙の旅","幼年期の終り"],"name":"アーサー・C・クラーク"}        
        */

        static void Main(string[] args) {

            string wXmlFilePath = @"..\..\novelist.xml";
            var wNovelist = new Novelist();

            //XmlSerializerクラスを使ったデシリアライズ
            using (var wReader = XmlReader.Create(wXmlFilePath)) {
                var wSerializer = new XmlSerializer(typeof(Novelist));
                wNovelist = wSerializer.Deserialize(wReader) as Novelist;
            }

            string wJsonFilePath = @"..\..\novelist.json";

            //DataContractJsonSerializerクラスを使ったシリアライズ
            var wSettings = new DataContractJsonSerializerSettings() {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
            };

            using (var wStream = new FileStream(wJsonFilePath, FileMode.Create, FileAccess.Write)) {
                var wSerializer = new DataContractJsonSerializer(wNovelist.GetType(), wSettings);
                wSerializer.WriteObject(wStream, wNovelist);
            }
            Console.WriteLine("JSONシリアライズが完了しました。");
        }
    }
}
