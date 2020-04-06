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
    public partial class BindingCtrl : UserControl
    {
        private RCChannelSettings _channel;

        public BindingCtrl()
        {
            InitializeComponent();

            comboBoxBinding.Items.Clear();
            comboBoxBinding.Items.Add("DISABLED");
            comboBoxBinding.Items.Add("JOYLEFT_X");
            comboBoxBinding.Items.Add("JOYLEFT_Y");
            comboBoxBinding.Items.Add("JOYRIGHT_X");
            comboBoxBinding.Items.Add("JOYRIGHT_Y");
            comboBoxBinding.Items.Add("POTENTIOMETER_1");
            comboBoxBinding.Items.Add("POTENTIOMETER_2");

            comboBoxSink.Items.Clear();
            comboBoxSink.Items.Add("ESC");
            comboBoxSink.Items.Add("SERVO_0");
            comboBoxSink.Items.Add("SERVO_1");
            comboBoxSink.Items.Add("SERVO_2");
            comboBoxSink.Items.Add("SERVO_3");

        }

        internal RCChannelSettings Channel
        {
            set
            {
                _channel = value;

                comboBoxBinding.SelectedIndex = (int)value.Binding;
                textBoxName.Text = value.Name;
                comboBoxSink.SelectedIndex = (int)value.Sink;
            }
        }

        private void comboBoxBinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBinding.SelectedIndex == 0)
            {
                textBoxName.Enabled = false;
                comboBoxSink.Enabled = false;
            }
            else
            {
                textBoxName.Enabled = true;
                comboBoxSink.Enabled = true;
            }
        }

        internal void Save()
        {
            _channel.Binding = (RCChannelBinding)comboBoxBinding.SelectedIndex;
            _channel.Sink = (RCSinkMode)comboBoxSink.SelectedIndex;
            _channel.Name = textBoxName.Text;
        }
    }
}
