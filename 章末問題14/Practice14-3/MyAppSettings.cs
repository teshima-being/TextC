using System.Configuration;

namespace Practice14_3 {
    
    /// <summary>
    /// 独自のアプリケーション設定クラス
    /// </summary>
    public class MyAppSettings : ConfigurationSection {

        /// <summary>
        /// トレース設定
        /// </summary>
        [ConfigurationProperty("traceOption")]
        public TraceOption TraceOption {
            get { return (TraceOption)this["traceOption"]; }
            set { this["traceOption"] = value; }
        }

        /// <summary>
        /// カレンダー設定
        /// </summary>
        [ConfigurationProperty("calendarOption")]
        public CalendarOption CalendarOption {
            get { return (CalendarOption)this["calendarOption"]; }
            set { this["calendarOption"] = value; }
        }
    }
}
