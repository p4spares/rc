using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RcSimulator
{
    public partial class CalibrationCtrl : UserControl
    {
        private RCChannelSettings _currentChannel;

        public CalibrationCtrl()
        {
            InitializeComponent();

            comboBoxMode.Items.Clear();
            comboBoxMode.Items.Add("NORMAL");
            comboBoxMode.Items.Add("EXPONENTIAL");            
        }

        private void comboBoxChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentChannel != null)
            {
                SaveChannel(_currentChannel);
            }

            int nServo = comboBoxChannel.SelectedIndex;

            _currentChannel = RCSettingsHelper.Instance.Channels[nServo];

            comboBoxMode.SelectedIndex = (int)_currentChannel.Mode;
            checkBoxInverted.Checked = _currentChannel.Inverted;
            numericUpDownMin.Minimum = 0;
            numericUpDownMin.Maximum = 180;
            numericUpDownMax.Minimum = 0;
            numericUpDownMax.Maximum = 180;
            numericUpDownZero.Minimum = 0;
            numericUpDownZero.Maximum = 180;

            numericUpDownMin.Value = _currentChannel.MinValue;
            numericUpDownMax.Value = _currentChannel.MaxValue;
            numericUpDownZero.Value = _currentChannel.Zero;

            numericUpDownMin.Enabled = false;
            buttonMin.BackColor = Color.Red;
            numericUpDownMax.Enabled = false;
            buttonMax.BackColor = Color.Red;
            numericUpDownZero.Enabled = false;
            buttonZero.BackColor = Color.Red;
        }

        private void SaveChannel(RCChannelSettings channel)
        {
            channel.Mode = (RCChannelMode)comboBoxMode.SelectedIndex;
            channel.Inverted = checkBoxInverted.Checked;
            channel.MinValue = (byte)numericUpDownMin.Value;
            channel.MaxValue = (byte)numericUpDownMax.Value;
            channel.Zero = (byte)numericUpDownZero.Value;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            ToggleEditButton(buttonMin, numericUpDownMin, buttonMax, buttonZero);
        }

        void ToggleEditButton(Button button, NumericUpDown upDown, Button other1, Button other2)
        { 
            if (upDown.Enabled)
            {
                upDown.Enabled = false;
                button.BackColor = Color.Red;
                button.Text = "Edit";
                other1.Enabled = true;
                other2.Enabled = true;
                MoveServo(upDown);
            }
            else
            {
                upDown.Enabled = true;
                button.BackColor = Color.Green;
                button.Text = "Stop";
                other1.Enabled = false;
                other2.Enabled = false;
                MoveServo(upDown);
            }
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            MoveServo(numericUpDownMin);
        }

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            MoveServo(numericUpDownMax);
        }

        private void numericUpDownZero_ValueChanged(object sender, EventArgs e)
        {
            MoveServo(numericUpDownZero);
        }

        void MoveServo(NumericUpDown upDown)
        {
            int nServo = comboBoxChannel.SelectedIndex;
            byte value = (byte)upDown.Value;

            Serial.Instance.RawMoveServo(
                RCSettingsHelper.Instance.Channels[nServo].Sink,
                value
                );
        }

        internal void LoadCalibration()
        {
            comboBoxChannel.Items.Clear();

            foreach (RCChannelSettings channel in RCSettingsHelper.Instance.Channels)
            {
                if (channel.Binding == RCChannelBinding.DISABLED)
                    continue;

                comboBoxChannel.Items.Add(channel.Name);
            }
            comboBoxChannel.SelectedIndex = 0;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            ToggleEditButton(buttonMax, numericUpDownMax, buttonMin, buttonZero);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            ToggleEditButton(buttonZero, numericUpDownZero, buttonMin, buttonMax);
        }

    }
}
