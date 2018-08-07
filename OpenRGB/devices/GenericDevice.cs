using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRGB.Devices;

namespace OpenRGB.Devices
{
    /// <summary>
    /// Type of hardware device
    /// </summary>
    public enum DeviceType
    {
        Empty,
        SerialAdressable,
        SerialMatrix,
        LogitechMouse,
        LogitechKeyboard,
        CorsairMouse,
        CorsairKeyboard,
    }

    /// <summary>
    /// Effects shared across all RGB devices
    /// </summary>
    public enum Effect
    {
        Off,
        Solid,
        Flash,
        Breathe,
        Matrix
    }

    /// <summary>
    /// Describes exceptions for hardware devices
    /// </summary>
    public class RGBHardwareException : Exception
    {
        // For generic exceptions
        private const string baseMessage = "There is an error with a hardware device";

        /// <summary>
        /// Instantiates a new rgbhardwareexception with the specified message
        /// </summary>
        /// <param name="message"></param>
        public RGBHardwareException(string message) : base(message) { }

        /// <summary>
        /// Instantiates a new rgb hardware exception with the specified message and innerexception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public RGBHardwareException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Instantiates a new rgbhardwareexception with a generic message
        /// </summary>
        public RGBHardwareException() : base(baseMessage) { }

    }

    /// <summary>
    /// Base class from which all devices are inherited
    /// </summary>
    public abstract class GenericDevice
    {
        #region Fields
        protected DeviceType type;
        protected Color mainColor;
        protected Color secondaryColor;
        protected int interval;
        #endregion

        #region Properties
        public DeviceType Type{ get => type; }
        public  Color MainColor { get => mainColor; set => mainColor = value; }
        public  Color SecondaryColor { get => secondaryColor; set => secondaryColor = value; }
        protected int Interval { get => interval; set => interval = value; }
        #endregion

        #region Constructors
        public GenericDevice()
        {
            this.type = DeviceType.Empty;
        }
        #endregion

        #region Members
        public abstract void Dispose();

        public abstract void WriteEffect(Effect effect, Color color);

        public abstract void WriteEffect(Effect effect);

        public abstract void WriteColor(Color color);

        public abstract void WriteColor(Color[] color);
        #endregion
    }

}
