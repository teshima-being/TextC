﻿using System;

namespace Practice1_1_3 {
    /// <summary>
    /// Personクラス
    /// </summary>
    internal class Person {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 誕生日
        /// </summary>
        public DateTime Birthday { get; set; }
        
        /// <summary>
        /// 誕生日と今日の日付から現在の年齢を取得する
        /// </summary>
        /// <returns>現在の年齢</returns>
        public int GetAge() {
            var wToday = DateTime.Today;
            int wAge = wToday.Year - this.Birthday.Year;
            if (wToday < this.Birthday.AddYears(wAge))
                wAge--;
            return wAge;
        }
    }
}