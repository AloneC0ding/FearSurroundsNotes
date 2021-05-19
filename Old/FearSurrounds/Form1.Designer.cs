
namespace FearSurrounds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FLP3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FLP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.CheckedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FLP1
            // 
            this.FLP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLP1.Location = new System.Drawing.Point(6, 19);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(100, 280);
            this.FLP1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 338);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "身份分類";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FLP3);
            this.groupBox4.Location = new System.Drawing.Point(250, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 310);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "壊人";
            // 
            // FLP3
            // 
            this.FLP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLP3.Location = new System.Drawing.Point(6, 19);
            this.FLP3.Name = "FLP3";
            this.FLP3.Size = new System.Drawing.Size(100, 280);
            this.FLP3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FLP2);
            this.groupBox3.Location = new System.Drawing.Point(130, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 310);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "好人";
            // 
            // FLP2
            // 
            this.FLP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLP2.Location = new System.Drawing.Point(6, 19);
            this.FLP2.Name = "FLP2";
            this.FLP2.Size = new System.Drawing.Size(100, 280);
            this.FLP2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FLP1);
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 310);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "未知";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CheckedListBox2);
            this.groupBox5.Controls.Add(this.CheckedListBox1);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(12, 356);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 284);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "証供";
            // 
            // CheckedListBox2
            // 
            this.CheckedListBox2.CheckOnClick = true;
            this.CheckedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedListBox2.FormattingEnabled = true;
            this.CheckedListBox2.Items.AddRange(new object[] {
            "  ==二樓==",
            "  住院室",
            "  注射室",
            "  廁所",
            "   門診部",
            "  ==一樓==",
            "  手術室",
            "  門診分部",
            "  扮工室",
            "  =地下室=",
            "  電子控制室",
            "  太平間",
            " ======",
            " 左樓梯",
            " 右樓梯"});
            this.CheckedListBox2.Location = new System.Drawing.Point(250, 19);
            this.CheckedListBox2.Name = "CheckedListBox2";
            this.CheckedListBox2.Size = new System.Drawing.Size(114, 259);
            this.CheckedListBox2.TabIndex = 14;
            // 
            // CheckedListBox1
            // 
            this.CheckedListBox1.CheckOnClick = true;
            this.CheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Location = new System.Drawing.Point(16, 24);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.CheckedListBox1.Size = new System.Drawing.Size(100, 256);
            this.CheckedListBox1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 26);
            this.button3.TabIndex = 12;
            this.button3.Text = "確定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "分隔線";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CheckedListBox3);
            this.groupBox7.Location = new System.Drawing.Point(130, 47);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 92);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(396, 41);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(127, 599);
            this.TextBox1.TabIndex = 9;
            this.TextBox1.Text = "";
            // 
            // CheckedListBox3
            // 
            this.CheckedListBox3.CheckOnClick = true;
            this.CheckedListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedListBox3.FormattingEnabled = true;
            this.CheckedListBox3.Items.AddRange(new object[] {
            " 關燈之前 ",
            " 關燈之後 ",
            " 條友尻玩 "});
            this.CheckedListBox3.Location = new System.Drawing.Point(8, 10);
            this.CheckedListBox3.Name = "CheckedListBox3";
            this.CheckedListBox3.Size = new System.Drawing.Size(100, 67);
            this.CheckedListBox3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 648);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "恐惧之间 Fear surrounds Notes (By Alone)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel FLP3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel FLP2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.CheckedListBox CheckedListBox1;
        private System.Windows.Forms.CheckedListBox CheckedListBox2;
        private System.Windows.Forms.CheckedListBox CheckedListBox3;
    }
}

