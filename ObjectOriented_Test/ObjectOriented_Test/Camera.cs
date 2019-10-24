using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Test
{
    /// <summary>
    /// カメラクラス（抽象クラス）
    /// </summary>
    public abstract class DegitalCamera : Device, ITakePictable
    {
        public DegitalCamera(string name) : base(name) { }

        // 継承先で実装するメソッド群
        abstract protected bool take();

        public bool Take()
        {
            return take();
        }
    }

    /// <summary>
    /// コンパクトデジタルカメラ(具象クラス)
    /// </summary>
    public class CompactDegiCame : DegitalCamera
    {
        public CompactDegiCame( string name ) : base( name) { }

        protected override bool take()
        {
            FireReport("コンパクトデジカメ-写真とります");
            return true;
        }
    }
}
