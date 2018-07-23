using System;
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
        Matix,
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
            Identify();
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
            Identify();
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

        public void WriteColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void WriteColor(Color[] colors)
        {
            throw new NotImplementedException();
        }

        public void WriteColor(int colorNumber, Color color)
        {
            throw new NotImplementedException();
        }

        public void WriteEffect()
        {
            throw new NotImplementedException();
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
