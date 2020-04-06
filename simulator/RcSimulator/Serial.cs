using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RcSimulator
{
    class Serial
    {
        static private Serial _singleton;

        private string lastPort;
        private SerialPort mySerialPort;
        MemoryStream readAllBytes = new MemoryStream(Form1.CONFIG_RESPONSE_SIZE);

        static public Serial Instance
        {
            get {
                if (_singleton == null)
                {
                    _singleton = new Serial();
                }
                return _singleton;
            }
        }

        public bool IsConnected {
            get
            {
                return (mySerialPort != null);
            }
        }

        public void ReadStream(MemoryStream readAllBytes, int v)
        {
            readAllBytes.SetLength(0);
            for (int i = 0; i < v; i++)
            {
                readAllBytes.WriteByte((byte)mySerialPort.ReadByte());
            }
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //AppendTextBox(mySerialPort.ReadExisting());

            //ExecResponse();
        }

        public byte[] SendStream(MemoryStream ms, int responseSize)
        {
            if (mySerialPort == null)
                return null;

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    byte[] buffer = ms.GetBuffer();
                    mySerialPort.Write(buffer, 0, (int)ms.Length);

                    byte[] response = new byte[responseSize];
                    try
                    {
                        mySerialPort.Read(response, 0, responseSize);
                        return response;
                    }
                    catch(TimeoutException timeout)
                    {
                        //
                    }
                }                
            }
            catch (IOException ec)
            {
                Disconnect();
                if (lastPort != null)
                Connect(lastPort);
            }

            return null;
        }

        internal void ReadConfig()
        {
            MemoryStream ms = new MemoryStream();
            ms.WriteByte((byte)'!');
            ms.WriteByte((byte)'2'); // 2- read settings
            ms.WriteByte((byte)'>');
            RCSettingsHelper.ReadFromBuffer(SendStream(ms, Form1.CONFIG_RESPONSE_SIZE));
        }

        internal void RawMoveServo(RCSinkMode sink, byte value)
        {
            MemoryStream ms = new MemoryStream();
            ms.WriteByte((byte)'!');
            ms.WriteByte((byte)'1');
            ms.WriteByte((byte)sink); // servo #id
            ms.WriteByte((byte)value); // value
            ms.WriteByte((byte)'>');

            Serial.Instance.SendStream(ms, 0);
        }

        public void Connect(string portName)
        {
            try
            {
                lastPort = portName;

                SerialPort lSerialPort = new SerialPort();
                lSerialPort.DataReceived += DataReceived;
                lSerialPort.PortName = portName;
                lSerialPort.BaudRate = 115200;
                lSerialPort.ReadTimeout = 1500;
                lSerialPort.Open();
                mySerialPort = lSerialPort;
                lSerialPort.ReadExisting();
            }
            catch (Exception ex)
            {
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }

        public void Disconnect()
        {
            SerialPort lSerialPort = mySerialPort;
            mySerialPort = null;
            if (lSerialPort != null)
            {
                lSerialPort.Close();
            }
        }

        internal void WriteConfig(RCSoftwareSettings instance)
        {
            MemoryStream ms = new MemoryStream();
            ms.WriteByte((byte)'!');
            ms.WriteByte((byte)'3'); // 3- write settings

            RCSettingsHelper.WriteToBuffer(ms, instance);

            ms.WriteByte((byte)'>');

            byte[] rsp = SendStream(ms, 3);
        }
    }
}
