using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Practice14_4 {
    internal class Program {

        //あなたがよく訪れるWebページのHTMLを取得し、ファイルに保存するプログラムを書いてください。

        static void Main(string[] args) {

            if (args.Length != 2) {
                Console.WriteLine("引数が不正です。第1引数にHTMLデータを取得したいWebサイトのURL、第2引数に出力先ファイルのパスを指定してください。");
                return;
            }

            string wURL = args[0];

            var wWebClient = new WebClient();
            wWebClient.Encoding = Encoding.UTF8;

            string wHTMLText;
            try {
                wHTMLText = wWebClient.DownloadString(wURL);
            } catch (WebException) {
                Console.WriteLine("サイトの情報を読み込めません。URLを確認してください。");
                return;
            }

            //ファイルへの書き出し
            string wOutputFilePath = args[1];
            File.WriteAllText(wOutputFilePath, wHTMLText);
            Console.WriteLine("処理が終了しました。");

            Console.ReadLine(); //確認用
        }
    }
}
