namespace ObjectOriented_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxMusic = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.comboBoxPhone = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTakePict = new System.Windows.Forms.Button();
            this.comboBoxTakePict = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMusic
            // 
            this.comboBoxMusic.FormattingEnabled = true;
            this.comboBoxMusic.Location = new System.Drawing.Point(26, 33);
            this.comboBoxMusic.Name = "comboBoxMusic";
            this.comboBoxMusic.Size = new System.Drawing.Size(152, 23);
            this.comboBoxMusic.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMusic);
            this.groupBox1.Controls.Add(this.comboBoxMusic);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音楽";
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.Location = new System.Drawing.Point(204, 31);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(47, 25);
            this.checkBoxMusic.TabIndex = 1;
            this.checkBoxMusic.Text = "再生";
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            this.checkBoxMusic.CheckedChanged += new System.EventHandler(this.checkBoxMusic_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPhone);
            this.groupBox2.Controls.Add(this.comboBoxPhone);
            this.groupBox2.Location = new System.Drawing.Point(28, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "電話";
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(204, 33);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(55, 25);
            this.checkBoxPhone.TabIndex = 2;
            this.checkBoxPhone.Text = "掛ける";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            this.checkBoxPhone.CheckedChanged += new System.EventHandler(this.checkBoxPhone_CheckedChanged);
            // 
            // comboBoxPhone
            // 
            this.comboBoxPhone.FormattingEnabled = true;
            this.comboBoxPhone.Location = new System.Drawing.Point(26, 33);
            this.comboBoxPhone.Name = "comboBoxPhone";
            this.comboBoxPhone.Size = new System.Drawing.Size(152, 23);
            this.comboBoxPhone.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonTakePict);
            this.groupBox3.Controls.Add(this.comboBoxTakePict);
            this.groupBox3.Location = new System.Drawing.Point(28, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 77);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "写真";
            // 
            // buttonTakePict
            // 
            this.buttonTakePict.Location = new System.Drawing.Point(204, 32);
            this.buttonTakePict.Name = "buttonTakePict";
            this.buttonTakePict.Size = new System.Drawing.Size(75, 23);
            this.buttonTakePict.TabIndex = 1;
            this.buttonTakePict.Text = "撮影";
            this.buttonTakePict.UseVisualStyleBackColor = true;
            this.buttonTakePict.Click += new System.EventHandler(this.buttonTakePict_Click);
            // 
            // comboBoxTakePict
            // 
            this.comboBoxTakePict.FormattingEnabled = true;
            this.comboBoxTakePict.Location = new System.Drawing.Point(26, 33);
            this.comboBoxTakePict.Name = "comboBoxTakePict";
            this.comboBoxTakePict.Size = new System.Drawing.Size(152, 23);
            this.comboBoxTakePict.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(332, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(544, 259);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 288);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "オブジェクト指向あり";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMusic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPhone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxTakePict;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.Button buttonTakePict;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}

