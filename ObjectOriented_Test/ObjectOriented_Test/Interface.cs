using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Test
{
    public delegate void ReportEventHandler(object sender, string message);

    /// <summary>
    /// デバイス インターフェイス
    /// </summary>
    public interface IDevice
    {
        string GetName();

        #region C#6
        //        string Name { get; }
        #endregion

        event ReportEventHandler Reported;
    }

    /// <summary>
    /// デバイスクラス(抽象クラス）
    /// </summary>
    public abstract class Device : IDevice
    {
        protected string _name;
        public string GetName()
        {
            return _name;
        }

        #region C#6
        //public string Name { get; }
        #endregion

        /// <summary>
        /// デフォルトのコンストラクタは使用させない。必ず引数付き（名前）コンストラクタを使用することを強制させる
        /// </summary>
        private Device()
        {
        }

        /// <summary>
        /// コンストラクタ（名前指定）
        /// </summary>
        /// <param name="name"></param>
        public Device( string name )
        {
            _name = name;
        }

        /// <summary>
        /// 状況イベント発火
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
    }

    /// <summary>
    /// 音楽再生できるI/F
    /// </summary>
    public interface IMusicPlayable
    {
        bool Play();
        bool Stop();
    }

    /// <summary>
    /// 電話を掛けることができるI/F
    /// </summary>
    public interface IPhoneable
    {
        bool Call();
        bool HandUp();

    }

    /// <summary>
    /// 写真を撮ることができるI/F
    /// </summary>
    public interface ITakePictable
    {
        bool Take();
    }
}
