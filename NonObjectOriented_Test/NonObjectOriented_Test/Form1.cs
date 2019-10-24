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

            // 制御対象のデバイスのインスタンスを生成
            iPhone iPhone = new iPhone("iPhone8");
            iPhone.Reported += Reported;

            WalkMan walkman = new WalkMan("WalkmanWM1");
            walkman.Reported += Reported;

            CompactDegiCame degiCame = new CompactDegiCame("FinePix");
            degiCame.Reported += Reported;

            // 音楽再生コンボボックスに追加
            comboBoxMusic.Items.Add( new ComboBoxCustomItem(iPhone.GetName(), iPhone));
            comboBoxMusic.Items.Add(new ComboBoxCustomItem(walkman.GetName(), walkman));
            comboBoxMusic.SelectedIndex = 0;

            // 電話コンボボックスに追加
            comboBoxPhone.Items.Add(new ComboBoxCustomItem(iPhone.GetName(), iPhone));
            comboBoxPhone.SelectedIndex = 0;

            // 写真撮影コンボボックスに追加
            comboBoxTakePict.Items.Add(new ComboBoxCustomItem(iPhone.GetName(), iPhone));
            comboBoxTakePict.Items.Add(new ComboBoxCustomItem(degiCame.GetName(), degiCame));
            comboBoxTakePict.SelectedIndex = 0;
        }

        /// <summary>
        /// 音楽制御ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMusic_CheckedChanged(object sender, EventArgs e)
        {
            var cmbItem = comboBoxMusic.SelectedItem as ComboBoxCustomItem;

            // 選択されたデバイスがiPhoneか調べる
            var iPhoneObj = cmbItem.Obj as iPhone;
            if(iPhoneObj != null)
            {
                // iPhoneだった場合は、iPhoneクラスに再生命令
                iPhoneObj.Play();
                return;
            }

            // 選択されたデバイスがWalkManか調べる
            var walkManObj = cmbItem.Obj as WalkMan;
            if (walkManObj != null)
            {
                // walkManだった場合は、WalkManクラスに再生命令
                walkManObj.Play();
                return;
            }
        }

        /// <summary>
        /// 電話かける
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            var cmbItem = comboBoxPhone.SelectedItem as ComboBoxCustomItem;

            // 選択されたデバイスがiPhoneか調べる
            var iPhone = cmbItem.Obj as iPhone;
            if (iPhone != null)
            {
                // iPhoneだった場合
                iPhone.Call();
                return;
            }
        }

        /// <summary>
        /// 写真撮影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePict_Click(object sender, EventArgs e)
        {
            var cmbItem = comboBoxTakePict.SelectedItem as ComboBoxCustomItem;

            // 選択されたデバイスがiPhoneか調べる
            var iPhone = cmbItem.Obj as iPhone;
            if (iPhone != null)
            {
                // iPhoneだった場合
                iPhone.Take();
                return;
            }

            // 選択されたデバイスがデジカメか調べる
            var dejiCame = cmbItem.Obj as CompactDegiCame;
            if (dejiCame != null)
            {
                // iPhoneだった場合
                dejiCame.Take();
                return;
            }
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
