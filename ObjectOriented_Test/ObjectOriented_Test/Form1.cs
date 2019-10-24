using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOriented_Test
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  制御機器一覧
        /// </summary>
        protected List<IDevice> m_deviceList = new List<IDevice>()
        {
            new iPhone("iPhone8"),
            new WalkMan("walkmanWM1"),
            new CompactDegiCame("FinePix"),

            #region STEP2
            //new AndoroidPhone("Xperia"),
            //new iPod("ipod touch 7"),
            #endregion
        };

        /// <summary>
        /// 各デバイスからの通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        public void Reported(object sender, string message)
        {
            listBox1.Items.Add(message);
        }

        public Form1()
        {
            InitializeComponent();

            // 各コンボボックスにデバイスを追加
            foreach( var dev in m_deviceList)
            {
                // デバイス毎に通知イベントを登録（デバイス → 画面へのイベント）
                dev.Reported += Reported;

                if( (dev as IMusicPlayable) != null)
                {
                    // デバイスが音楽プレイヤーの機能を有している場合
                    comboBoxMusic.Items.Add(new ComboBoxCustomItem(dev.GetName(), dev));
                }

                if ((dev as IPhoneable) != null)
                {
                    // デバイスが電話機の機能を有している場合
                    comboBoxPhone.Items.Add(new ComboBoxCustomItem(dev.GetName(), dev));
                }

                if ((dev as ITakePictable) != null)
                {
                    // デバイスがカメラの機能を有している場合
                    comboBoxTakePict.Items.Add(new ComboBoxCustomItem(dev.GetName(), dev));
                }

            }

            comboBoxMusic.SelectedIndex = 0;
            comboBoxPhone.SelectedIndex = 0;
            comboBoxTakePict.SelectedIndex = 0;
        }

        /// <summary>
        /// 音楽制御ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMusic_CheckedChanged(object sender, EventArgs e)
        {
             // asキャスト後のNULLチェックは不要（Form1のコンストラクタで保証している）
            var musicPlayer = (comboBoxMusic.SelectedItem as ComboBoxCustomItem).Obj as IMusicPlayable;
            musicPlayer.Play();

// 以下の様に1行でも書ける 
//            ((comboBoxMusic.SelectedItem as ComboBoxCustomItem).Obj as IMusicPlayable).Play();
        }

        /// <summary>
        /// 電話かける
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            var phone = (comboBoxPhone.SelectedItem as ComboBoxCustomItem).Obj as IPhoneable;
            phone.Call();
        }

        /// <summary>
        /// 写真撮影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePict_Click(object sender, EventArgs e)
        {
            var camera = (comboBoxTakePict.SelectedItem as ComboBoxCustomItem).Obj as ITakePictable;
            camera.Take();
        }
    }

    // コンボボックスの1アイテム
    public class ComboBoxCustomItem
    {
        protected string Name;                  // コンボボックス表示名
        public object Obj { set; get; }         // コンボボックスのアイテムに紐づくインスタンス

        public ComboBoxCustomItem(string viewName, object obj)
        {
            Name = viewName;
            Obj = obj;
        }

        // コンボボックスからコールされる
        public override string ToString()
        {
            return Name;
        }
    }
}
