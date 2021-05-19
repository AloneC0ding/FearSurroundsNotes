using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FearSurroundsNotes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		// Move your controls
			Helper.ControlMover.Init(this.Num0);
			Helper.ControlMover.Init(this.Num1);
			Helper.ControlMover.Init(this.Num2);
			Helper.ControlMover.Init(this.Num3);
			Helper.ControlMover.Init(this.Num4);
			Helper.ControlMover.Init(this.Num5);
			Helper.ControlMover.Init(this.Num6);
			Helper.ControlMover.Init(this.Num7);
			Helper.ControlMover.Init(this.Num8);
			Helper.ControlMover.Init(this.Num9);
			Helper.ControlMover.Init(this.Num10);
			Helper.ControlMover.Init(this.Num11);
			Helper.ControlMover.Init(this.Body1);
			Helper.ControlMover.Init(this.Body2);

			// Move a panel by its toolstrip
			//Helper.ControlMover.Init(this.toolStrip2, this.panel3, Helper.ControlMover.Direction.Any);

			// Make a splitter from toolstrip
			//Helper.ControlMover.Init(this.toolStrip1, Helper.ControlMover.Direction.Vertical);
			//this.toolStrip1.LocationChanged += delegate (object sender, EventArgs e)
			//{
			//	this.panel1.Height = this.toolStrip1.Top;
			//};
		}

		Label mvLabel = null;
		private IEnumerable<Control> controls;

		private void Form1_Load(object sender, EventArgs e)
        {
			fillFLP(FLP1, 120);
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
		private void button4_Click(object sender, EventArgs e)
        {
			Application.Restart();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			TextBox1.Text += Environment.NewLine + "";
			TextBox1.Text += string.Join(System.Environment.NewLine, "   ==========   ");
			TextBox1.Text += Environment.NewLine + "";
		}

        private void button1_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button1.Text;
		}

        private void button2_Click_1(object sender, EventArgs e)
        {
			TextBox1.Text += button2.Text;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			TextBox1.Text += button13.Text;
			TextBox1.Text += Environment.NewLine + "";
		}

        private void button3_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button3.Text;
		}

        private void button4_Click_1(object sender, EventArgs e)
        {
			TextBox1.Text += button4.Text;
		}

        private void button5_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button5.Text;
		}

        private void button6_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button6.Text;
		}

        private void button7_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button7.Text;
		}

        private void button8_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button8.Text;
		}

        private void button9_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button9.Text;
		}

        private void button10_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button10.Text;
		}

        private void button11_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button11.Text;
		}

        private void button12_Click(object sender, EventArgs e)
        {
			TextBox1.Text += button12.Text;
		}

        private void button14_Click(object sender, EventArgs e)
        {
			TextBox1.Text += Environment.NewLine + "";
			TextBox1.Text += button14.Text;

		}

        private void button15_Click(object sender, EventArgs e)
        {
			TextBox1.Text += Environment.NewLine + "";
			TextBox1.Text += button15.Text;
		}
    }


}