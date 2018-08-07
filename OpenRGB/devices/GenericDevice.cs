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
    /// Type of hardware device, used to determinte hardware connection type
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
        private const string baseMessage = "There is an error with a hardware device";

        public RGBHardwareException(string message) : base(message) { }

        public RGBHardwareException(string message, Exception innerException) : base(message, innerException) { }

        public RGBHardwareException() : base(baseMessage) { }

    }

    /// <summary>
    /// Base class from which all devices are inherited
    /// </summary>
    public abstract class GenericDevice
    {
        protected DeviceType type;

        public DeviceType Type{ get => type; }

        public GenericDevice()
        {
            this.type = DeviceType.Empty;
        }

        public abstract void Dispose();

        public abstract void WriteEffect(Effect effect, Color color);

        public abstract void WriteEffect(Effect effect);

        public abstract void WriteColor(Color color);

        public abstract void WriteColor(Color[] color);
    }
}
