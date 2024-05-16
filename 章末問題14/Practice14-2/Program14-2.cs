using System;
using System.Diagnostics;
using System.Reflection;

namespace Practice14_2 {
    internal class Program {

        //問題14-2
        //自分自身のファイルバージョンとアセンブリバージョンを表示するコンソールアプリケーションを作成してください。

        static void Main(string[] args) {

            Console.WriteLine("自分自身のファイルバージョンは以下の通りです。");
            var wFileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine($"{wFileVersion.FileMajorPart}.{wFileVersion.FileMinorPart}.{wFileVersion.FileBuildPart}.{wFileVersion.FilePrivatePart}");

            Console.WriteLine($"自分自身のアセンブリバージョンは以下の通りです。");
            var wAssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            Console.WriteLine($"{wAssemblyVersion.Major}.{wAssemblyVersion.Minor}.{wAssemblyVersion.Build}.{wAssemblyVersion.Revision}");

            Console.ReadLine(); //確認用
        }
    }
}
