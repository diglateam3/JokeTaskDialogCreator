
namespace JokeTaskDialogCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.s_messageCaption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.s_messageHeading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s_messageText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.s_choice1text = new System.Windows.Forms.TextBox();
            this.b_1stchoiceUAC = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.s_choice1desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.s_choice2desc = new System.Windows.Forms.TextBox();
            this.b_2ndchoiceUAC = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s_choice2text = new System.Windows.Forms.TextBox();
            this.b_expandenable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 64);
            this.button1.TabIndex = 19;
            this.button1.Text = "表示する！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // s_messageCaption
            // 
            this.s_messageCaption.Location = new System.Drawing.Point(12, 27);
            this.s_messageCaption.Name = "s_messageCaption";
            this.s_messageCaption.PlaceholderText = "JokeTaskDialogCreator";
            this.s_messageCaption.Size = new System.Drawing.Size(360, 23);
            this.s_messageCaption.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "メッセージのタイトル:";
            // 
            // s_messageHeading
            // 
            this.s_messageHeading.Location = new System.Drawing.Point(12, 71);
            this.s_messageHeading.Name = "s_messageHeading";
            this.s_messageHeading.PlaceholderText = "Hello, World!";
            this.s_messageHeading.Size = new System.Drawing.Size(360, 23);
            this.s_messageHeading.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "メッセージの見出し（キャプション）: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "メッセージの本文: ";
            // 
            // s_messageText
            // 
            this.s_messageText.Location = new System.Drawing.Point(12, 115);
            this.s_messageText.Multiline = true;
            this.s_messageText.Name = "s_messageText";
            this.s_messageText.PlaceholderText = "Hello, World!";
            this.s_messageText.Size = new System.Drawing.Size(360, 124);
            this.s_messageText.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "表示しない",
            "情報（「i」マーク）",
            "警告（「！」マーク）",
            "エラー（「×」マーク）",
            "シールド（管理者権限が必要な操作の時に出るマーク）",
            "シールド（青）（見出し部分が青いバーで表示されるシールド）",
            "シールド（グレー）（見出し部分が灰色のバーで表示されるシールド）",
            "シールド（エラー）",
            "シールド（警告）",
            "シールド（成功）"});
            this.comboBox1.Location = new System.Drawing.Point(11, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "メッセージのアイコン: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "選択肢1の内容:";
            // 
            // s_choice1text
            // 
            this.s_choice1text.Location = new System.Drawing.Point(11, 304);
            this.s_choice1text.Name = "s_choice1text";
            this.s_choice1text.PlaceholderText = "選択肢1";
            this.s_choice1text.Size = new System.Drawing.Size(360, 23);
            this.s_choice1text.TabIndex = 10;
            // 
            // b_1stchoiceUAC
            // 
            this.b_1stchoiceUAC.AutoSize = true;
            this.b_1stchoiceUAC.Location = new System.Drawing.Point(151, 285);
            this.b_1stchoiceUAC.Name = "b_1stchoiceUAC";
            this.b_1stchoiceUAC.Size = new System.Drawing.Size(221, 19);
            this.b_1stchoiceUAC.TabIndex = 9;
            this.b_1stchoiceUAC.Text = "管理者権限が必要な操作のマークを出す";
            this.b_1stchoiceUAC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "選択肢1の説明:";
            // 
            // s_choice1desc
            // 
            this.s_choice1desc.Location = new System.Drawing.Point(11, 348);
            this.s_choice1desc.Name = "s_choice1desc";
            this.s_choice1desc.PlaceholderText = "選択肢1の説明だよ";
            this.s_choice1desc.Size = new System.Drawing.Size(360, 23);
            this.s_choice1desc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "選択肢2の説明:";
            // 
            // s_choice2desc
            // 
            this.s_choice2desc.Location = new System.Drawing.Point(11, 436);
            this.s_choice2desc.Name = "s_choice2desc";
            this.s_choice2desc.PlaceholderText = "選択肢2の説明だよ";
            this.s_choice2desc.Size = new System.Drawing.Size(360, 23);
            this.s_choice2desc.TabIndex = 17;
            // 
            // b_2ndchoiceUAC
            // 
            this.b_2ndchoiceUAC.AutoSize = true;
            this.b_2ndchoiceUAC.Location = new System.Drawing.Point(151, 373);
            this.b_2ndchoiceUAC.Name = "b_2ndchoiceUAC";
            this.b_2ndchoiceUAC.Size = new System.Drawing.Size(221, 19);
            this.b_2ndchoiceUAC.TabIndex = 14;
            this.b_2ndchoiceUAC.Text = "管理者権限が必要な操作のマークを出す";
            this.b_2ndchoiceUAC.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "選択肢2の内容:";
            // 
            // s_choice2text
            // 
            this.s_choice2text.Location = new System.Drawing.Point(11, 392);
            this.s_choice2text.Name = "s_choice2text";
            this.s_choice2text.PlaceholderText = "選択肢2";
            this.s_choice2text.Size = new System.Drawing.Size(360, 23);
            this.s_choice2text.TabIndex = 15;
            // 
            // b_expandenable
            // 
            this.b_expandenable.AutoSize = true;
            this.b_expandenable.Location = new System.Drawing.Point(11, 465);
            this.b_expandenable.Name = "b_expandenable";
            this.b_expandenable.Size = new System.Drawing.Size(230, 19);
            this.b_expandenable.TabIndex = 18;
            this.b_expandenable.Text = "詳細が出てきそうなボタンを左下に表示する";
            this.b_expandenable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 565);
            this.Controls.Add(this.b_expandenable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.s_choice2desc);
            this.Controls.Add(this.b_2ndchoiceUAC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.s_choice2text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s_choice1desc);
            this.Controls.Add(this.b_1stchoiceUAC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_choice1text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.s_messageText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s_messageHeading);
            this.Controls.Add(this.s_messageCaption);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JokeTaskDialogCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox s_messageCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox s_messageHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox s_messageText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox s_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox s_choice1text;
        private System.Windows.Forms.CheckBox b_1stchoiceUAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s_choice1desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s_choice2desc;
        private System.Windows.Forms.CheckBox b_2ndchoiceUAC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox s_choice2text;
        private System.Windows.Forms.CheckBox b_expandenable;
    }
}

