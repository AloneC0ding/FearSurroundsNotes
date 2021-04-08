using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FearSurrounds
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillFLP(FLP1, 88);

            for (int i = 0; i < 12; i++)
            {
                CheckedListBox1.Items.Add("  號碼 " + i.ToString("00") + "    ");
                CheckedListBox2.Items.Add("  號碼 " + i.ToString("00") + "    ");
            }
        }

        void fillFLP(FlowLayoutPanel FLP, int cc)
        {
            for (int i = 0; i < 12; i++)
            {
                Label l = new Label();
                l.AutoSize = false;
                l.Text = "  號碼  " + i.ToString("00");
                l.BackColor = Color.FromArgb(255, cc * 2 - i, 255 - 5 * i, cc + 5 * i);
                FLP.Controls.Add(l);
                l.MouseDown += l_MouseDown;
                l.MouseMove += l_MouseMove;
                l.MouseUp += l_MouseUp;
            }
        }
        Label mvLabel = null;
        private IEnumerable<Control> controls;

        void l_MouseDown(object sender, MouseEventArgs e)
        {
            mvLabel = (Label)sender;
        }

        void l_MouseMove(object sender, MouseEventArgs e)
        {
            if (mvLabel != null)
            {
                Point mvPoint = this.PointToClient(Control.MousePosition);
                if (mvLabel.Parent != this)
                {
                    mvLabel.Parent = this;
                    mvLabel.Location = mvPoint;
                    mvLabel.BringToFront();
                }
                else
                {
                    mvLabel.Location = mvPoint;
                }
            }
        }

        void l_MouseUp(object sender, MouseEventArgs e)
        {
            Point MP = Control.MousePosition;
            FlowLayoutPanel FLP = null;

            Point mLoc1 = FLP1.PointToClient(MP);
            Point mLoc2 = FLP2.PointToClient(MP);
            Point mLoc3 = FLP3.PointToClient(MP);

            if (FLP1.ClientRectangle.Contains(mLoc1)) FLP = FLP1;
            else if (FLP2.ClientRectangle.Contains(mLoc2)) FLP = FLP2;
            else if (FLP3.ClientRectangle.Contains(mLoc3)) FLP = FLP3;
            else return;  
            mvLabel.SendToBack();
            Control cc = FLP.GetChildAtPoint(FLP.PointToClient(MP));
            int mvIndex = FLP.Controls.Count; 
            if (cc != null) mvIndex = FLP.Controls.IndexOf(cc);
            FLP.Controls.Add(mvLabel);
            FLP.Controls.SetChildIndex(mvLabel, mvIndex);
            mvLabel = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var LselectedItems = CheckedListBox1.CheckedItems.OfType<String>().ToList();
            var RselectedItems = CheckedListBox2.CheckedItems.OfType<String>().ToList();

            TextBox1.Text += string.Join(System.Environment.NewLine, "     ==============    ");
            TextBox1.Text += Environment.NewLine + "";

            TextBox1.Text += string.Join(" ", LselectedItems);

            if (Hit.Checked == true)
            {
                TextBox1.Text += Environment.NewLine + "";
                TextBox1.Text += string.Join(System.Environment.NewLine, "      ===== 打 =====    ");
                TextBox1.Text += Environment.NewLine + "";
            }
            if (Save.Checked == true)
            {
                TextBox1.Text += Environment.NewLine + "";
                TextBox1.Text += string.Join(System.Environment.NewLine, "      ===== 保 =====    ");
                TextBox1.Text += Environment.NewLine + "";
            }

            TextBox1.Text += string.Join(" ", RselectedItems);
            TextBox1.Text += Environment.NewLine + ""; 
            TextBox1.Text += string.Join(System.Environment.NewLine, "      ==============    ");
            TextBox1.Text += Environment.NewLine + "";

            bool state = false;
            for (int i = 0; i < CheckedListBox1.Items.Count; i++)
                CheckedListBox1.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
            for (int i = 0; i < CheckedListBox1.Items.Count; i++)
                CheckedListBox2.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }
        private void Save_CheckedChanged(object sender, EventArgs e)
        {
            Hit.Checked = !Save.Checked;
        }
        private void Hit_CheckedChanged_1(object sender, EventArgs e)
        {
            Save.Checked = !Hit.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Environment.NewLine + "";
            TextBox1.Text += string.Join(System.Environment.NewLine, "      ====加一晚====    ");
            TextBox1.Text += Environment.NewLine + "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Environment.NewLine + "";
            TextBox1.Text += string.Join(System.Environment.NewLine, "      =====一組=====    ");
            var LselectedItems = CheckedListBox1.CheckedItems.OfType<String>().ToList();
            TextBox1.Text += string.Join(" ", LselectedItems);
            TextBox1.Text += Environment.NewLine + "";
            TextBox1.Text += string.Join(System.Environment.NewLine, "      ==============    ");
            TextBox1.Text += Environment.NewLine + "";

            bool state = false;
            for (int i = 0; i < CheckedListBox1.Items.Count; i++)
                CheckedListBox1.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }
    }
}
