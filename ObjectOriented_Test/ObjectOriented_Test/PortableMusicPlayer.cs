using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Test
{
    /// <summary>
    /// ポータブル音楽プレイヤー（抽象クラス）
    /// </summary>
    public abstract class PortableMusicPlayer : Device, IMusicPlayable
    {
        public PortableMusicPlayer(string name) : base(name) { }

        protected bool _playingStatus = false; // 音楽再生状態(true：再生中、false：停止中)

        // 継承先で実装するメソッド群(本来は関数名を変えた方がよい。大文字小文字だけの違いは微妙）
        abstract protected bool play();
        abstract protected bool stop();

        /// <summary>
        /// 音楽再生機能(どの音楽プレイヤーでも共通した処理）
        /// </summary>
        public bool Play()
        {
            // 既に再生中なら何もしない
            if (true == _playingStatus)
            {
                return true;
            }

            // 具体的な再生処理は、派生先に委譲
            if (play() == false)
            {
                return false;
            }

            _playingStatus = true;
            return true;
        }

        /// <summary>
        /// 音楽停止処理(どの音楽プレイヤーでも共通した処理）
        /// </summary>
        public bool Stop()
        {
            // 既に停止中なら何もしない
            if (false == _playingStatus)
            {
                return true;
            }

            // 具体的な再生処理は、派生先に委譲
            if (stop() == false)
            {
                return false;
            }

            _playingStatus = false;
            return true;
        }

    }

    /// <summary>
    /// ウォークマン(具象クラス)
    /// </summary>
    public class WalkMan : PortableMusicPlayer
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WalkMan(string name) : base(name)
        {
        }

        /// <summary>
        /// 再生
        /// </summary>
        protected override bool play()
        {
            FireReport("WalkMan-音楽再生します");
            return true;
        }

        /// <summary>
        /// ストップ
        /// </summary>
        protected override bool stop()
        {
            FireReport("WalkMan-音楽停止します");
            return true;
        }
    }

    #region STEP2
    /// <summary>
    /// iPodクラス
    /// </summary>
    //public class iPod : PortableMusicPlayer
    //{
    //    /// <summary>
    //    /// コンストラクタ
    //    /// </summary>
    //    public iPod(string name) : base(name)
    //    {
    //    }

    //    /// <summary>
    //    /// 再生
    //    /// </summary>
    //    public override void Play()
    //    {
    //        FireReport("iPod-音楽再生します");
    //    }

    //    /// <summary>
    //    /// ストップ
    //    /// </summary>
    //    public override void Stop()
    //    {
    //        FireReport("iPod-音楽停止します");
    //    }
    //}
    #endregion
}
