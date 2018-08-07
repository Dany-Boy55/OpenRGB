using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;

namespace OpenRGB.Devices
{

    /// <summary>
    /// Provides methods and properties common serial based communication
    /// </summary>
    public class SerialController : GenericDevice
    {
        /// <summary>
        /// Describes the different types of RGB controllers availeable
        /// </summary>        
        private enum Commands
        {
            Color = 0x00,
            Off = 0x01,
            SolidColor = 0x02,
            ColorChase1 = 0x03,            
        }

        public enum Effect
        {
            Off,
            SolidColor,
            ColorChase1,
            ColorChase2,
            ColorRain,
        }

        #region private fields
        private SerialPort port;
        private static int instanceNumber;
        private string name;
        private int id;
        private bool connected;
        #endregion

        #region encapsulated properties
        public string Name { get => name; }
        public int Id { get => id; }
        public bool Connected { get => connected; }
        public static int InstanceNumber { get => instanceNumber; }
        #endregion

        public event EventHandler<EventArgs> DeviceRemoved;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="serialPort"></param>
        public SerialController(SerialPort serialPort)
        {
            if (!PortNameValid(serialPort.PortName))
                throw new RGBHardwareException();
            this.port = serialPort;
            this.name = null;
            this.id = 0;
            this.type = DeviceType.SerialAdressable;
            instanceNumber++;
        }

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="portName"> </param>
        public SerialController(string portName)
        {
            if (!PortNameValid(portName))
                throw new RGBHardwareException();
            this.port.ErrorReceived += Port_ErrorReceived;
            this.port = new SerialPort(portName, 19200);
            this.name = null;
            this.id = 0;
            this.type = DeviceType.SerialAdressable;
        }

        protected virtual void OnPortError(EventArgs e)
        {
            throw new RGBHardwareException("There was a problem with the Serial port on device" + this.ToString());
        }

        private void Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            OnPortError(new EventArgs());
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
        /// Used to get data from the serial device
        /// </summary>
        /// <returns></returns>
        public void Identify()
        {
            // length,crc8,data request
            byte[] dataOut = new byte[] { 0x01, 0x00, 0x00};
            if (connected){
                try
                {
                    port.Write(dataOut, 0, 3);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private byte CRC8(byte[] data, int length)
        {
            return 0x45;
        }

        public void ChangeName()
        {
            if (!connected)
                throw new RGBHardwareException();
            else
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

        public override void Dispose()
        {
            port.Dispose();
            this.Dispose();
        }

        public override void WriteEffect(Devices.Effect effect, Color color)
        {
            throw new NotImplementedException();
        }

        public override void WriteEffect(Devices.Effect effect)
        {
            throw new NotImplementedException();
        }

        public override void WriteColor(Color color)
        {
            throw new NotImplementedException();
        }

        public override void WriteColor(Color[] color)
        {
            throw new NotImplementedException();
        }
    }

    
}
