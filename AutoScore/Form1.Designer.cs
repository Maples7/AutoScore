namespace AutoScore
{
    partial class AutoScore
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.radio10in = new System.Windows.Forms.RadioButton();
            this.radio20in = new System.Windows.Forms.RadioButton();
            this.radioMulti = new System.Windows.Forms.RadioButton();
            this.autoShowNext = new System.Windows.Forms.CheckBox();
            this.butFaster = new System.Windows.Forms.Button();
            this.butSlower = new System.Windows.Forms.Button();
            this.butNextOne = new System.Windows.Forms.Button();
            this.autoShowAns = new System.Windows.Forms.CheckBox();
            this.firstNum = new System.Windows.Forms.Label();
            this.oprater = new System.Windows.Forms.Label();
            this.secondNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ansBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightRate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkAns = new System.Windows.Forms.Button();
            this.lastAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "题目类型：";
            // 
            // radio10in
            // 
            this.radio10in.AutoSize = true;
            this.radio10in.Location = new System.Drawing.Point(27, 56);
            this.radio10in.Name = "radio10in";
            this.radio10in.Size = new System.Drawing.Size(95, 16);
            this.radio10in.TabIndex = 1;
            this.radio10in.TabStop = true;
            this.radio10in.Text = "10以内加减法";
            this.radio10in.UseVisualStyleBackColor = true;
            this.radio10in.CheckedChanged += new System.EventHandler(this.radio10in_CheckedChanged);
            // 
            // radio20in
            // 
            this.radio20in.AutoSize = true;
            this.radio20in.Location = new System.Drawing.Point(27, 78);
            this.radio20in.Name = "radio20in";
            this.radio20in.Size = new System.Drawing.Size(95, 16);
            this.radio20in.TabIndex = 2;
            this.radio20in.TabStop = true;
            this.radio20in.Text = "20以内加减法";
            this.radio20in.UseVisualStyleBackColor = true;
            this.radio20in.CheckedChanged += new System.EventHandler(this.radio20in_CheckedChanged);
            // 
            // radioMulti
            // 
            this.radioMulti.AutoSize = true;
            this.radioMulti.Location = new System.Drawing.Point(27, 100);
            this.radioMulti.Name = "radioMulti";
            this.radioMulti.Size = new System.Drawing.Size(47, 16);
            this.radioMulti.TabIndex = 3;
            this.radioMulti.TabStop = true;
            this.radioMulti.Text = "乘法";
            this.radioMulti.UseVisualStyleBackColor = true;
            this.radioMulti.CheckedChanged += new System.EventHandler(this.radioMulti_CheckedChanged);
            // 
            // autoShowNext
            // 
            this.autoShowNext.AutoSize = true;
            this.autoShowNext.Location = new System.Drawing.Point(304, 27);
            this.autoShowNext.Name = "autoShowNext";
            this.autoShowNext.Size = new System.Drawing.Size(108, 16);
            this.autoShowNext.TabIndex = 4;
            this.autoShowNext.Text = "自动显示下一题";
            this.autoShowNext.UseVisualStyleBackColor = true;
            this.autoShowNext.CheckedChanged += new System.EventHandler(this.autoShowNext_CheckedChanged);
            // 
            // butFaster
            // 
            this.butFaster.Location = new System.Drawing.Point(418, 23);
            this.butFaster.Name = "butFaster";
            this.butFaster.Size = new System.Drawing.Size(75, 23);
            this.butFaster.TabIndex = 5;
            this.butFaster.Text = "快些";
            this.butFaster.UseVisualStyleBackColor = true;
            this.butFaster.Click += new System.EventHandler(this.butFaster_Click);
            // 
            // butSlower
            // 
            this.butSlower.Location = new System.Drawing.Point(499, 23);
            this.butSlower.Name = "butSlower";
            this.butSlower.Size = new System.Drawing.Size(75, 23);
            this.butSlower.TabIndex = 6;
            this.butSlower.Text = "慢些";
            this.butSlower.UseVisualStyleBackColor = true;
            this.butSlower.Click += new System.EventHandler(this.butSlower_Click);
            // 
            // butNextOne
            // 
            this.butNextOne.Location = new System.Drawing.Point(323, 49);
            this.butNextOne.Name = "butNextOne";
            this.butNextOne.Size = new System.Drawing.Size(75, 23);
            this.butNextOne.TabIndex = 7;
            this.butNextOne.Text = "下一题";
            this.butNextOne.UseVisualStyleBackColor = true;
            this.butNextOne.Click += new System.EventHandler(this.butNextOne_Click);
            // 
            // autoShowAns
            // 
            this.autoShowAns.AutoSize = true;
            this.autoShowAns.Location = new System.Drawing.Point(304, 78);
            this.autoShowAns.Name = "autoShowAns";
            this.autoShowAns.Size = new System.Drawing.Size(96, 16);
            this.autoShowAns.TabIndex = 8;
            this.autoShowAns.Text = "自动显示答案";
            this.autoShowAns.UseVisualStyleBackColor = true;
            this.autoShowAns.CheckedChanged += new System.EventHandler(this.autoShowAns_CheckedChanged);
            // 
            // firstNum
            // 
            this.firstNum.AutoSize = true;
            this.firstNum.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstNum.Location = new System.Drawing.Point(133, 151);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(28, 29);
            this.firstNum.TabIndex = 9;
            this.firstNum.Text = "A";
            // 
            // oprater
            // 
            this.oprater.AutoSize = true;
            this.oprater.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oprater.Location = new System.Drawing.Point(167, 151);
            this.oprater.Name = "oprater";
            this.oprater.Size = new System.Drawing.Size(28, 29);
            this.oprater.TabIndex = 10;
            this.oprater.Text = "+";
            // 
            // secondNum
            // 
            this.secondNum.AutoSize = true;
            this.secondNum.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secondNum.Location = new System.Drawing.Point(201, 151);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(28, 29);
            this.secondNum.TabIndex = 11;
            this.secondNum.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(235, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // ansBox
            // 
            this.ansBox.BackColor = System.Drawing.SystemColors.Window;
            this.ansBox.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ansBox.Location = new System.Drawing.Point(269, 145);
            this.ansBox.Multiline = true;
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(116, 40);
            this.ansBox.TabIndex = 13;
            this.ansBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "您的正确率：";
            // 
            // rightRate
            // 
            this.rightRate.AutoSize = true;
            this.rightRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rightRate.Location = new System.Drawing.Point(280, 215);
            this.rightRate.Name = "rightRate";
            this.rightRate.Size = new System.Drawing.Size(23, 12);
            this.rightRate.TabIndex = 15;
            this.rightRate.Text = "0/0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkAns
            // 
            this.checkAns.Location = new System.Drawing.Point(323, 100);
            this.checkAns.Name = "checkAns";
            this.checkAns.Size = new System.Drawing.Size(75, 23);
            this.checkAns.TabIndex = 16;
            this.checkAns.Text = "Check";
            this.checkAns.UseVisualStyleBackColor = true;
            this.checkAns.Click += new System.EventHandler(this.checkAns_Click);
            // 
            // lastAns
            // 
            this.lastAns.AutoSize = true;
            this.lastAns.Location = new System.Drawing.Point(391, 173);
            this.lastAns.Name = "lastAns";
            this.lastAns.Size = new System.Drawing.Size(125, 12);
            this.lastAns.TabIndex = 17;
            this.lastAns.Text = "您已开启自动显示答案";
            this.lastAns.Visible = false;
            // 
            // AutoScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 250);
            this.Controls.Add(this.lastAns);
            this.Controls.Add(this.checkAns);
            this.Controls.Add(this.rightRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ansBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.oprater);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.autoShowAns);
            this.Controls.Add(this.butNextOne);
            this.Controls.Add(this.butSlower);
            this.Controls.Add(this.butFaster);
            this.Controls.Add(this.autoShowNext);
            this.Controls.Add(this.radioMulti);
            this.Controls.Add(this.radio20in);
            this.Controls.Add(this.radio10in);
            this.Controls.Add(this.label1);
            this.Name = "AutoScore";
            this.Text = "AutoScore - From Maples7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio10in;
        private System.Windows.Forms.RadioButton radio20in;
        private System.Windows.Forms.RadioButton radioMulti;
        private System.Windows.Forms.CheckBox autoShowNext;
        private System.Windows.Forms.Button butFaster;
        private System.Windows.Forms.Button butSlower;
        private System.Windows.Forms.Button butNextOne;
        private System.Windows.Forms.CheckBox autoShowAns;
        private System.Windows.Forms.Label firstNum;
        private System.Windows.Forms.Label oprater;
        private System.Windows.Forms.Label secondNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ansBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rightRate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button checkAns;
        private System.Windows.Forms.Label lastAns;
    }
}

