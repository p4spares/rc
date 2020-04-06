using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RcSimulator
{
    public partial class Joystick : UserControl
    {
        private Point px = new Point(0, 0);

        public int X { get { return px.X + 127; } }
        public int Y { get { return px.Y + 127; } }

        public Joystick()
        {
            InitializeComponent();
            UpdatePositionXy();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(127, 127);
            Rectangle rc = new Rectangle(px.X - 5, px.Y - 5, 10, 10);
            e.Graphics.FillEllipse(Brushes.Red, rc);
            e.Graphics.ResetTransform();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                px.X = e.X - 127;
                px.Y = e.Y - 127;
                panel1.Invalidate();
                UpdatePositionXy();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!checkBoxLock.Checked)
            {
                MoveToZero();
            }
        }

        private void UpdatePositionXy()
        {
            if (px.X < -127) px.X = -127;
            if (px.Y < -127) px.Y = -127;
            if (px.X > 127) px.X = 127;
            if (px.Y > 127) px.Y = 127;
            labelXy.Text = X + ", " + Y;
        }

        private void checkBoxLock_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxLock.Checked)
            {
                MoveToZero();
            }
        }

        private void MoveToZero()
        {
            px.X = 0;
            px.Y = 0;
            panel1.Invalidate();
            UpdatePositionXy();
        }
    }
}
