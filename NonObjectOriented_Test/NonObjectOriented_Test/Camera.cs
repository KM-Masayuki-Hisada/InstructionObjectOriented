using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Test
{

    /// <summary>
    /// コンパクトデジタルカメラ
    /// </summary>
    public class CompactDegiCame
    {
        protected string _name;
        public string GetName()
        {
            return _name;
        }

        public CompactDegiCame(string name)
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


        public void Take()
        {
            FireReport("写真とります");
        }
    }
}
