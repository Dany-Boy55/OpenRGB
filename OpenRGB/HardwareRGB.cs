using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace OpenRGB
{
    /// <summary>
    /// Describes the different types of RGB controllers availeable
    /// </summary>
    public enum ControllerType
    {
        Empty,
        Simple,
        Addresseable,
        SimpleAndAdresseable,
        Matrix,
    }

    public enum Effect
    {
        Off,
        SolidColor,
        ColorChase1,
        ColorChase2,
        ColorRain,
    }

    public class RGBHardwareException : Exception
    {
        public RGBHardwareException()
        {

        }
        public override IDictionary Data => base.Data;
    }

    /// <summary>
    /// Provides methods and properties common serial based communication
    /// </summary>
    public class GenericSerialController
    {
        #region internal fields
        private AsyncSerialPort port;
        private string name;
        private int id;
        private ControllerType type;
        private bool connected;
        #endregion

        #region encapsulated properties
        public string Name { get => name; }
        public int Id { get => id; }
        public ControllerType Type { get => type; }
        public bool Connected { get => connected; }
        #endregion

        public event EventHandler<EventArgs> DeviceRemoved;
        public event EventHandler<EventArgs> InformationReceived;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="serialPort"></param>
        public GenericSerialController(SerialPort serialPort)
        {
            if (!PortNameValid(serialPort.PortName))
                throw new RGBHardwareException();
            port = (AsyncSerialPort) serialPort;
            
            //Identify();
        }

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="portName"> </param>
        public GenericSerialController(string portName)
        {
            if (!PortNameValid(portName))
                throw new RGBHardwareException();
            port = new AsyncSerialPort(portName, 19200);
            name = "Empty";
            id = 0;
            type = ControllerType.Empty;
            //Identify();
        }

        /// <summary>
        /// Check if the specified string can be used as a portname for a serial port
        /// </summary>
        /// <param name="portName"> String to be checked</param>
        /// <returns> True if the string is valid, false otherwise</returns>
        private bool PortNameValid(string portName)
        {
            // compare the specified string to the availeable ports
            foreach (string item in SerialPort.GetPortNames())
            {
                if (portName.ToLower() == item.ToLower())
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task Identify()
        {
            throw new NotImplementedException();
        }

        public void ChangeName()
        {
            if (!connected)
                throw new RGBHardwareException();
            else
                throw new NotImplementedException();
        }

        public Color ReadColor(Color color)
        {
            throw new NotImplementedException();
        }

        public Color ReadColor(Color[] colors)
        {
            throw new NotImplementedException();
        }

        public Color ReadColor(int colorNumber, Color color)
        {
            throw new NotImplementedException();
        }

        public void WriteColor(Color color, int colorNumber)
        {
            byte[] dataOut = new byte[7];
            dataOut[0] = 0x06;
            dataOut[1] = 0x56;
            dataOut[2] = 0x01;
            dataOut[3] = (byte)colorNumber;
            dataOut[4] = color.B;
            dataOut[5] = color.B;
            dataOut[6] = color.B;
            Task.Run(() => port.Write(dataOut, 0, 7));
        }
        
        public void WriteEffect(Effect eff, bool state)
        {

        }

        /// <summary>
        /// Sends a lighting effect to a hardware device
        /// </summary>
        /// <param name="eff"></param>
        /// <param name="state"></param>
        /// <param name="arguments"></param>
        public void WriteEffect(Effect eff, bool state, int[] arguments)
        {
            int length = 3 + arguments.Length;
            byte[] dataOut = new byte[length];
            dataOut[0] = (byte)length;  //packet length without this byte
            dataOut[1] = 0x00;  // CRC not implemented yet
            dataOut[2] = (byte)eff;  // effect
            dataOut[3] = (byte)(state ? 0x00 : 0x01); // state of the effect (on / off) = (1 or 0)
            for (int i = 0; i < arguments.Length; i++)
            {
                dataOut[i + 4] = (byte)arguments[i];
            }
            Task.Run(() => port.Write(dataOut, 0, length + 1));
        }

        /// <summary>
        /// Override for ToString method
        /// </summary>
        /// <returns> Name of the hardware serial controller </returns>
        public override string ToString()
        {
            return name;
        }        
    }
}
