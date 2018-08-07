using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;

namespace OpenRGB.Devices
{
    public class SerialMatrix : GenericDevice
    {
        #region fields
        private SerialPort port;
        #endregion

        public enum Effect
        {
            SolidColor,
            Visor,
            Rain,
            Wave,
            Spectrum,
            Bitmap,
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public SerialMatrix(string portName)
        {
            port = new SerialPort(portName, 19200);
        }

        public override void WriteEffect(Effect effect)
        {
            throw new NotImplementedException();
        }

        public override void WriteColor()
        {
            throw new NotImplementedException();
        }

    }


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
            Task.Run(() => tryConnect());
        }

        protected virtual void tryConnect()
        {
            try
            {
                port.Open();
                byte[] dataOut = new byte[] { 0x01, 0x23, 0x00};
                port.Write(dataOut, 0, dataOut.Length);
                
            }
            catch (Exception)
            {
                connected = false;
            }
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

        public override void WriteColor(Color color, int colorNumber)
        {
            try
            {
                if (!port.IsOpen)
                    port.Open();
                byte[] dataOut = new byte[7];
                dataOut[0] = 0x06;  // length
                dataOut[1] = 0x56;  // CRC
                dataOut[2] = 0x01;  // Write color
                dataOut[3] = (byte)colorNumber; 
                dataOut[4] = color.R;
                dataOut[5] = color.G;
                dataOut[6] = color.B;
                Task.Run(() => port.Write(dataOut, 0, 7));
            }
            catch (Exception)
            {
                OnPortError(new EventArgs());
            }
        }
        
        public override void WriteEffect(Effect eff)
        {
            try
            {
                if (!port.IsOpen)
                    port.Open();
                byte[] dataOut = new byte[7];
                dataOut[0] = 0x06;
                dataOut[1] = 0x00;
                dataOut[2] = 0x01;
                Task.Run(() => port.Write(dataOut, 0, 7));
            }
            catch (Exception)
            {
                OnPortError(new EventArgs());
            }
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

        public override void Dispose()
        {
            port.Dispose();
            this.Dispose();
        }
    }

    
}
