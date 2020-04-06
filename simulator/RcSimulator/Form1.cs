using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RcSimulator
{
    public partial class Form1 : Form
    {
        public const int NCHANNELS = 6;
        public const int CONFIG_RESPONSE_SIZE = 28 * NCHANNELS;

        private TabPage previousSelectedPage = null;

        public Form1()
        {
            InitializeComponent();
            tabControlMain.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (Serial.Instance.IsConnected)
            {
                Serial.Instance.Disconnect();
                buttonConnect.BackColor = Color.Red;
                buttonConnect.Text = "Open";
            }
            else
            {
                Serial.Instance.Connect(textBoxPort.Text);
                buttonConnect.BackColor = Color.Green;
                buttonConnect.Text = "Close";
                Serial.Instance.ReadConfig();

                InitBinding();

            }
        }

        private void InitBinding()
        {
            LoadBindings();
            tabControlMain.Enabled = true;
            tabControlMain.SelectedIndex = 0;
            previousSelectedPage = null;
            MainTabChanged();
        }

        private void Disconnect()
        {
            try
            {

                buttonConnect.BackColor = Color.Red;
                buttonConnect.Text = "Open";

            }
            catch (Exception ex)
            {
            }
        }


        private void LoadBindings()
        {
            bindingCtrl1.Channel = RCSettingsHelper.Instance.Channels[0];
            bindingCtrl2.Channel = RCSettingsHelper.Instance.Channels[1];
            bindingCtrl3.Channel = RCSettingsHelper.Instance.Channels[2];
            bindingCtrl4.Channel = RCSettingsHelper.Instance.Channels[3];
            bindingCtrl5.Channel = RCSettingsHelper.Instance.Channels[4];
            bindingCtrl6.Channel = RCSettingsHelper.Instance.Channels[5];
        }

        private void SaveBindings()
        {
            bindingCtrl1.Save();
            bindingCtrl2.Save();
            bindingCtrl3.Save();
            bindingCtrl4.Save();
            bindingCtrl5.Save();
            bindingCtrl6.Save();
        }

        
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            richTextBoxOutput.AppendText(value);
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            /*
            if (!Serial.Instance.IsConnected)
                return;

            MemoryStream ms = new MemoryStream();
            ms.WriteByte((byte)'!');
            ms.WriteByte((byte)'0');
            ms.WriteByte((byte)joystickLeft.Y); // throttle
            ms.WriteByte((byte)joystickLeft.X); // yaw
            ms.WriteByte((byte)joystickRight.Y); // pitch
            ms.WriteByte(0); // roll
            ms.WriteByte(checkBoxAutolevel.Checked ? (byte)1 : (byte)0); // AUX1
            ms.WriteByte(0); // AUX2
            ms.WriteByte((byte)'>');

            Serial.Instance.SendStream(ms,0);
            */
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            buttonConnect.BackColor = Color.Red;
            timerSend.Start();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
        }

        private void comboBoxServo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTabChanged();
        }

        private void MainTabChanged()
        {
            // save old page data
            if (previousSelectedPage == tabPageBinding)
            {
                SaveBindings();
            }

            // new page
            if (tabControlMain.SelectedTab == tabPageCalibration)
            {
                calibrationCtrl.LoadCalibration();
            }

            previousSelectedPage = tabControlMain.SelectedTab;
        }


        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "RC Config|*.rcfg.xml";
            saveFileDialog1.Title = "Save RC Config";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter tw = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(RCSoftwareSettings), new XmlRootAttribute("RCConfig"));
                serializer.Serialize(tw, RCSettingsHelper.Instance);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "RC Config|*.rcfg.xml";
            openFileDialog1.Title = "Open RC Config";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextReader rd = new XmlTextReader(openFileDialog1.FileName);
                XmlSerializer serializer = new XmlSerializer(typeof(RCSoftwareSettings), new XmlRootAttribute("RCConfig"));
                RCSettingsHelper.Instance = (RCSoftwareSettings)serializer.Deserialize(rd);

                InitBinding();
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            Serial.Instance.WriteConfig(RCSettingsHelper.Instance);
        }
    }
}
