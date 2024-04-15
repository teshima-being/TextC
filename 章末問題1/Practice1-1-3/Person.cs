using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3 {
    internal class Person {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        
        /// <summary>
        /// 誕生日と今日の日付から現在の年齢を取得する
        /// </summary>
        /// <returns>現在の年齢</returns>
        public int GetAge() {
            DateTime wToday = DateTime.Today;
            int wAge = wToday.Year - Birthday.Year;
            if (wToday < Birthday.AddYears(wAge)) 
                wAge--;
            return wAge;
        }
    }
}