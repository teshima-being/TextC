using System;
using System.Configuration;

namespace Practice14_3 {

    /// <summary>
    /// カレンダー設定クラス
    /// </summary>
    public class CalendarOption : ConfigurationElement {

        /// <summary>
        /// 表示形式
        /// </summary>
        [ConfigurationProperty("stringFormat")]
        public string StringFormat {
            get{ return (string)this["stringFormat"]; }
        }

        /// <summary>
        /// 最小指定可能日付
        /// </summary>
        [ConfigurationProperty("minimum")]
        public DateTime Minimum {
            get{return(DateTime)this["minimum"]; }
        }

        /// <summary>
        /// 最大指定可能日付
        /// </summary>
        [ConfigurationProperty("maximum")]
        public DateTime Maximum {
            get { return (DateTime)this["maximum"]; }
        }

        /// <summary>
        /// 週が月曜日開始か判定
        /// </summary>
        [ConfigurationProperty("mondayIsFirstDay")]
        public bool MondayIsFirstDay {
            get { return (bool)this["mondayIsFirstDay"]; }
        }
    }
}
