
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
            this.button4 = new System.Windows.Forms.Button();
            this.CheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.CheckBox();
            this.Hit = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(416, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 26);
            this.button4.TabIndex = 15;
            this.button4.Text = "同一組";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CheckedListBox2
            // 
            this.CheckedListBox2.CheckOnClick = true;
            this.CheckedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedListBox2.FormattingEnabled = true;
            this.CheckedListBox2.Location = new System.Drawing.Point(256, 25);
            this.CheckedListBox2.Name = "CheckedListBox2";
            this.CheckedListBox2.Size = new System.Drawing.Size(100, 256);
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
            this.button3.Location = new System.Drawing.Point(130, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 26);
            this.button3.TabIndex = 12;
            this.button3.Text = "確定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "分隔線";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Save);
            this.groupBox7.Controls.Add(this.Hit);
            this.groupBox7.Location = new System.Drawing.Point(130, 113);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 69);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Location = new System.Drawing.Point(6, 40);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 17);
            this.Save.TabIndex = 12;
            this.Save.Text = "=====保=====";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.CheckedChanged += new System.EventHandler(this.Save_CheckedChanged);
            // 
            // Hit
            // 
            this.Hit.AutoSize = true;
            this.Hit.Location = new System.Drawing.Point(6, 17);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(98, 17);
            this.Hit.TabIndex = 11;
            this.Hit.Text = "=====打=====";
            this.Hit.CheckedChanged += new System.EventHandler(this.Hit_CheckedChanged_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox12);
            this.groupBox6.Controls.Add(this.checkBox13);
            this.groupBox6.Controls.Add(this.checkBox14);
            this.groupBox6.Controls.Add(this.checkBox15);
            this.groupBox6.Controls.Add(this.checkBox16);
            this.groupBox6.Controls.Add(this.checkBox17);
            this.groupBox6.Controls.Add(this.checkBox18);
            this.groupBox6.Controls.Add(this.checkBox19);
            this.groupBox6.Controls.Add(this.checkBox20);
            this.groupBox6.Controls.Add(this.checkBox21);
            this.groupBox6.Controls.Add(this.checkBox22);
            this.groupBox6.Location = new System.Drawing.Point(396, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 274);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "見過";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(5, 247);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(101, 17);
            this.checkBox12.TabIndex = 10;
            this.checkBox12.Text = "  玩家 號碼  11";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(5, 224);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(101, 17);
            this.checkBox13.TabIndex = 9;
            this.checkBox13.Text = "  玩家 號碼  10";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(5, 201);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(101, 17);
            this.checkBox14.TabIndex = 8;
            this.checkBox14.Text = "  玩家 號碼  09";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(5, 178);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(101, 17);
            this.checkBox15.TabIndex = 7;
            this.checkBox15.Text = "  玩家 號碼  08";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(5, 157);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(101, 17);
            this.checkBox16.TabIndex = 6;
            this.checkBox16.Text = "  玩家 號碼  07";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(5, 134);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(101, 17);
            this.checkBox17.TabIndex = 5;
            this.checkBox17.Text = "  玩家 號碼  06";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(5, 111);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(101, 17);
            this.checkBox18.TabIndex = 4;
            this.checkBox18.Text = "  玩家 號碼  05";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(5, 88);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(101, 17);
            this.checkBox19.TabIndex = 3;
            this.checkBox19.Text = "  玩家 號碼  04";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(5, 65);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(101, 17);
            this.checkBox20.TabIndex = 2;
            this.checkBox20.Text = "  玩家 號碼  03";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(5, 42);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(101, 17);
            this.checkBox21.TabIndex = 1;
            this.checkBox21.Text = "  玩家 號碼  02";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(5, 19);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(101, 17);
            this.checkBox22.TabIndex = 0;
            this.checkBox22.Text = "  玩家 號碼  00";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(396, 321);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(133, 319);
            this.TextBox1.TabIndex = 9;
            this.TextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 642);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.CheckBox Save;
        private System.Windows.Forms.CheckBox Hit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.CheckedListBox CheckedListBox1;
        private System.Windows.Forms.CheckedListBox CheckedListBox2;
        private System.Windows.Forms.Button button4;
    }
}

