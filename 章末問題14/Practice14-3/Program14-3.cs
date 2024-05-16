using System;
using System.Configuration;

namespace Practice14_3 {
    public class Program {

        //本文で示したmyAppSettings要素（※）に以下のセクションを追加し、プログラムから参照できるようにしてください。

        /*
        <calendarOption stringFormat="yyyy年MM月dd日(ddd)>
                        minimum="1900/1/1"
                        maximum="2100/12/31"
                        mondayIsFirstDay="True" />
        */

        /*
        （※）
        <myAppSettings>
            <traceOption enabled="true"
                         filePath="C:MyApp\Trace.log"
                         bufferSize="10240" />
        </myAppSettings>
        */

        static void Main(string[] args) {

            var wSettings = ConfigurationManager.GetSection("myAppSettings") as MyAppSettings;

            //TraceOptionの確認
            TraceOption wTraceOption = wSettings.TraceOption;
            Console.WriteLine($"{wTraceOption.BufferSize}\n{wTraceOption.Enabled}\n{wTraceOption.FilePath}");

            //CalendarOptionの確認
            CalendarOption wCalendarOption = wSettings.CalendarOption;
            Console.WriteLine($"{wCalendarOption.StringFormat}\n{wCalendarOption.Minimum:d}\n{wCalendarOption.Maximum:d}\n{wCalendarOption.MondayIsFirstDay}");

            Console.ReadLine(); //確認用
        }
    }
}
