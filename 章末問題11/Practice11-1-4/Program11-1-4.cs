﻿using System;
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

            if (!IsXmlFile(wXFilePath)) return;

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

        /// <summary>
        /// ファイルパスを引数に取り、指定したファイルが存在するかと、指定したファイルがXMLファイルであるかを判定します。
        /// 指定したファイルが存在し、かつXMLファイルであった場合のみtrueを返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        static bool IsXmlFile(string vFilePath) {
            if (!File.Exists(vFilePath)) {
                Console.WriteLine("指定したファイルが見つかりません。パスを確認してください。");
                return false;
            }
            if (Path.GetExtension(vFilePath) != ".xml") {
                Console.WriteLine("ファイルの拡張子が正しくありません。XMLファイルを指定してください。");
                return false;
            }
            return true;
        }
    }
}
