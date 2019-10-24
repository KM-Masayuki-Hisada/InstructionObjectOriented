using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Test
{
    /// <summary>
    /// スマートフォンクラス(抽象クラス）
    /// スマホとしての共通部
    /// </summary>
    public abstract class SmartPhone : Device, IMusicPlayable, IPhoneable, ITakePictable
    {
        public SmartPhone( string name ) : base( name ) { } // コンストラクタ

        protected bool _musicPlayingStatus = false; // 音楽再生状態(true：再生中、false：停止中)
        protected bool _phoneCallStatus = false;    // 電話発信状態(true：通話中、false：非通話中)

        // 継承先で実装するメソッド群
        abstract protected bool PlayMusic();                // 具体的な音楽再生処理（派生クラスでオーバライド)
        abstract protected bool StopMusic();                // 具体的な音楽停止処理（派生クラスでオーバライド)
        abstract protected bool CallPhone();                // 具体的な電話発信処理（派生クラスでオーバライド)
        abstract protected bool HandUpPhone();              // 具体的な電話切る処理（派生クラスでオーバライド)
        abstract protected bool TakePicture();              // 具体的な写真撮影処理（派生クラスでオーバライド)

        /// <summary>
        /// 音楽再生機能(どのスマホでも共通した処理）
        /// </summary>
        public bool Play()
        {
            // 既に再生中なら何もしない
            if ( true == _musicPlayingStatus )
            {
                return true;
            }

            // 具体的な再生処理は、派生先に委譲
            if (PlayMusic() == false)
            {
                return false;
            }

           _musicPlayingStatus = true;
           return true;
        }

        /// <summary>
        /// 音楽停止処理(どのスマホでも共通した処理）
        /// </summary>
        public bool Stop()
        {
            // 既に停止中なら何もしない
            if (false == _musicPlayingStatus)
            {
                return true;
            }

            // 具体的な再生処理は、派生先に委譲
            if (StopMusic() == false)
            {
                return false;
            }

            _musicPlayingStatus = false;
            return true;
        }


        /// <summary>
        /// 電話発信機能(どのスマホでも共通した処理）
        /// </summary>
        public bool Call()
        {
            // 既に通話中なら何もしない
            if (true == _phoneCallStatus)
            {
                return true;
            }

            // 具体的な発信処理は、派生先に委譲
            if (CallPhone() == true)
            {
                return false;
            }

            _phoneCallStatus = true;
            return true;
       }

        /// <summary>
        /// 電話を切る処理
        /// </summary>
        public bool HandUp()
        {
            // 通話中でなければ何もしない
            if (false == _phoneCallStatus)
            {
                return true;
            }

            // 具体的な切る処理は、派生先に委譲
            if (HandUpPhone() == true)
            {
                return false;
            }

            _phoneCallStatus = false;
            return true;
        }

        /// <summary>
        /// 写真撮影処理
        /// </summary>
        public bool Take()
        {
            return TakePicture();
        }
    }

    /// <summary>
    /// iPhoneクラス
    /// </summary>
    public class iPhone : SmartPhone
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public iPhone(string name) : base( name )
        {
        }

        /// <summary>
        /// iPhoneの音楽再生処理
        /// </summary>
        protected override bool PlayMusic()
        {
            FireReport("iPhone-音楽再生します");
            return true;
        }

        /// <summary>
        /// iPhoneの音楽停止処理
        /// </summary>
        protected override bool StopMusic()
        {
            FireReport("iPhone-音楽停止します");
            return true;
        }

        /// <summary>
        /// iPhoneで電話を掛ける処理
        /// </summary>
        protected override bool CallPhone()
        {
            FireReport("iPhone-電話かけます");
            return true;
        }

        /// <summary>
        /// iPhoneで電話を切る処理
        /// </summary>
        protected override bool HandUpPhone()
        {
            FireReport("iPhone-電話切ります");
            return true;
        }

        /// <summary>
        /// iPhoneでの写真撮影
        /// </summary>
        protected override bool TakePicture()
        {
            FireReport("iPhone-写真撮ります");
            return true;
        }
    }

    #region STEP2
    /// <summary>
    /// Andoroidクラス
    /// </summary>
    //public class AndoroidPhone : SmartPhone
    //{
    //    /// <summary>
    //    /// コンストラクタ
    //    /// </summary>
    //    public AndoroidPhone(string name) : base( name )
    //    {
    //    }

    //    /// <summary>
    //    /// Andoroidの音楽再生処理
    //    /// </summary>
    //    public override void Play()
    //    {
    //        FireReport("Andoroid-音楽再生します");
    //    }

    //    /// <summary>
    //    /// Andoroidの音楽停止処理
    //    /// </summary>
    //    public override void Stop()
    //    {
    //        FireReport("Andoroid-音楽停止します");
    //    }

    //    /// <summary>
    //    /// Andoroidで電話を掛ける処理
    //    /// </summary>
    //    public override void Call()
    //    {
    //        FireReport("Andoroid-電話かけます");
    //    }

    //    /// <summary>
    //    /// Andoroidで電話を切る処理
    //    /// </summary>
    //    public override void HandUp()
    //    {
    //        FireReport("Andoroid-電話切ります");
    //    }

    //    /// <summary>
    //    /// Andoroidでの写真撮影
    //    /// </summary>
    //    public override void Take()
    //    {
    //        FireReport("Andoroid-写真撮ります");
    //    }
    //}
    #endregion
}
