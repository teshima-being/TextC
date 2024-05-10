using System;
using System.IO;
using System.Xml.Linq;

namespace Practice11_1_4 {
    internal class Program {

        //問題11-1-4
        //サッカーの情報を追加し、新たなXMLファイルに出力してください。ファイル名は特に問いません。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドライン引数でXMLファイルのパスを指定してください。");
                return;
            }

            string wXFilePath = args[0];

            if (!File.Exists(wXFilePath)) {
                Console.WriteLine("指定したファイルが見つかりません。パスを確認してください。");
                return;
            }

            if (Path.GetExtension(wXFilePath) != ".xml") {
                Console.WriteLine("ファイルの拡張子が正しくありません。XMLファイルを指定してください。");
            }

            var wSoccerData = new XElement("ballsport",
                                  new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                  new XElement("teammembers", "6"),
                                  new XElement("firstplayed", "1863"));

            var wBallSportsData = XDocument.Load(wXFilePath);
            wBallSportsData.Root.Add(wSoccerData);

            //読み込んだXMLファイルと同じ階層にBallSportsDataの名前で保存する
            wBallSportsData.Save(Path.Combine(Path.GetDirectoryName(wXFilePath), "BallSportsData.xml"));

            //確認用
            Console.WriteLine(wBallSportsData.ToString());
        }
    }
}
