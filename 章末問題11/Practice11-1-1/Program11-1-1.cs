using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Practice11_1_1 {
    internal class Program {

        //問題11-1-1
        //XMLファイルを読み込み、競技名とチームメンバー数の一覧を表示してください。

        //サンプルファイルのパス
        //\\being.group\Being-組織\システム開発課\Doc\中途入社研修\20240401-シャレッチョ・手島悠介\手島悠介\C#テキスト《イディオム》\Sample11-1.xml

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

            var wBallSportsData = XDocument.Load(wXFilePath);
            IEnumerable<XElement> wBallSports = wBallSportsData.Root.Elements();

            foreach (XElement wBallSport in wBallSports) {
                XElement wSportName = wBallSport.Element("name");
                XElement wTeamMembers = wBallSport.Element("teammembers");

                Console.WriteLine($"{wSportName.Value}は1チーム{wTeamMembers.Value}名で構成されています。");
            }
        }
    }
}
