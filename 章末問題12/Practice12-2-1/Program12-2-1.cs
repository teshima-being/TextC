using System;
using System.Xml;
using System.Xml.Serialization;

namespace Practice12_2_1 {
    internal class Program {

        //問題12-2-1
        //XmlSerializerクラスを使って、以下のXMLファイルを逆シリアル化し、Novelistオブジェクトを作成してください。
        //Novelistクラスには必要ならば適切な属性を付加してください。

        /* XMLファイル
        <?xml version="1.0" encoding="utf-8"?>
        <Novelist>
           <name>アーサー・C・クラーク</name>
           <birth>1917-12-16T00:00:00</birth>
           <masterpieces>
              <title>2001年宇宙の旅</title>
              <title>幼年期の終り</title>
           </masterpieces>
        </Novelist>
        */

        static void Main(string[] args) {

            string wXmlFilePath = @"..\..\novelist.xml";

            using (var wReader = XmlReader.Create(wXmlFilePath)) {
                var wSerializer = new XmlSerializer(typeof(Novelist));
                var wNovelist = wSerializer.Deserialize(wReader);

                //結果確認用
                Console.WriteLine(wNovelist.ToString());
            }
        }
    }
}
