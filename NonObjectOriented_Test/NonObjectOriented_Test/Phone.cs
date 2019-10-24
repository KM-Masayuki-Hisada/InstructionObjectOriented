﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Test
{
    public delegate void ReportEventHandler(object sender, string message);

    /// <summary>
    /// iPhoneクラス
    /// </summary>
    public class iPhone
    {
        protected string _name;
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public iPhone(string name)
        {
            _name = name;
        }

        /// <summary>
        /// イベント発火
        /// </summary>
        /// <param name="message"></param>
        public event ReportEventHandler Reported;
        protected void FireReport(string message)
        {
            string reportMsg = string.Format("クラス名:{0}, デバイス名:{1}・・・{2}", 
                this.GetType().Name, 
                _name,
                message);

            if (Reported != null)
            {
                Reported.Invoke(this, reportMsg);
            }

            // C#6(VS2015)以降なら、以下の様に1行で書ける。
            //            Reported?.Invoke(this, reportMsg);
        }

        /// <summary>
        /// iPhoneの音楽再生処理
        /// </summary>
        public void Play()
        {
            FireReport("音楽再生します");
        }

        /// <summary>
        /// iPhoneの音楽停止処理
        /// </summary>
        public void Stop()
        {
            FireReport("音楽停止します");
        }

        /// <summary>
        /// iPhoneで電話を掛ける処理
        /// </summary>
        public void Call()
        {
            FireReport("電話かけます");
        }

        /// <summary>
        /// iPhoneで電話を切る処理
        /// </summary>
        public void HandUp()
        {
            FireReport("電話切ります");
        }

        /// <summary>
        /// iPhoneでの写真撮影
        /// </summary>
        public void Take()
        {
            FireReport("写真撮ります");
        }
    }
}
