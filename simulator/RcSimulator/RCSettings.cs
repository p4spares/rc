using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcSimulator
{
    public enum RCChannelBinding : byte
    {
        DISABLED = 0,
        JOYLEFT_X, // joystick left, x axis
        JOYLEFT_Y, // joystick right, y axis
        JOYRIGHT_X, // joystick left, x axis
        JOYRIGHT_Y, // joystick right, y axis
        POTENTIOMETER_1, // potentiometer #1
        POTENTIOMETER_2, // potentiometer #1
    };

    public enum RCChannelMode : byte
    {
        NORMAL = 0,
        EXPONENTIAL
    };

    public enum RCSinkMode : byte
    {
        ESC = 0,
        SERVO_0,
        SERVO_1,
        SERVO_2,
        SERVO_3
    };

    public class RCChannelSettings
    {
        public RCChannelBinding Binding;
        public RCSinkMode Sink;
        public RCChannelMode Mode;
        public string Name;
        public bool Inverted;
        public byte MinValue;
        public byte MaxValue;
        public byte Zero;
    }

    public class RCSoftwareSettings
    {
        public List<RCChannelSettings> Channels;

        public RCSoftwareSettings()
        {
            Channels = new List<RCChannelSettings>();
        }
    }

    class RCSettingsHelper
    {
        public static RCSoftwareSettings Instance;

        static public RCSoftwareSettings ReadFromBuffer(byte[] readAllBytes)
        {
            RCSoftwareSettings settings = new RCSoftwareSettings();
            int ip = 0;

            for(int i=0; i<6; i++)
            {
                RCChannelSettings channel = new RCChannelSettings();
                channel.Binding = (RCChannelBinding)readAllBytes[ip++];
                channel.Sink = (RCSinkMode)readAllBytes[ip++];
                channel.Mode = (RCChannelMode)readAllBytes[ip++];
                channel.Name = ReadZeroString(readAllBytes, ip);
                ip += 21; // channel name
                channel.Inverted = readAllBytes[ip++] != 0 ? true : false;
                channel.MinValue = (byte)readAllBytes[ip++];
                channel.MaxValue = (byte)readAllBytes[ip++];
                channel.Zero = (byte)readAllBytes[ip++];

                settings.Channels.Add(channel);
            }

            Instance = settings;

            return settings;
        }

        static private string ReadZeroString(byte[] readAllBytes, int ip)
        {
            StringBuilder sb = new StringBuilder();
            while(readAllBytes[ip] != 0)
            {
                sb.Append((char)readAllBytes[ip++]);
            }
            return sb.ToString();
        }

        internal static void WriteToBuffer(MemoryStream ms, RCSoftwareSettings instance)
        {
            for (int i = 0; i < 6; i++)
            {
                ms.WriteByte((byte)instance.Channels[i].Binding);
                ms.WriteByte((byte)instance.Channels[i].Sink);
                ms.WriteByte((byte)instance.Channels[i].Mode);
                ms.Write(
                    Encoding.ASCII.GetBytes(instance.Channels[i].Name.PadRight(21, '\0')),
                    0, 21);
                ms.WriteByte(instance.Channels[i].Inverted ? (byte)1: (byte)0);
                ms.WriteByte((byte)instance.Channels[i].MinValue);
                ms.WriteByte((byte)instance.Channels[i].MaxValue);
                ms.WriteByte((byte)instance.Channels[i].Zero);

            }
        }
    }
}
