using System;
using OpenRGB.Devices;
using OpenRGB.lib;
using System.Drawing;
using System.Threading.Tasks;

namespace OpenRGB.Devices
{

    /// <summary>
    /// Describes a color with chanels from 0 to 100 instead of 0 to 255 used by logitech SDK
    /// </summary>
    struct LogiColor
    {
        private int red;
        private int green;
        private int blue;

        /// <summary>
        /// Initialize a logitech formated color form a System.Drawing.Color struct
        /// </summary>
        /// <param name="color"></param>
        public LogiColor(Color color)
        {
            this.red = (int)(color.R / 2.55);
            this.green = (int)(color.G / 2.55);
            this.blue = (int)(color.B / 2.55);
        }

        public int Red { get => red; set => red = value; }
        public int Green { get => green; set => green = value; }
        public int Blue { get => blue; set => blue = value; }

        /// <summary>
        /// Convert the current instance of a logitech color into a System.Drawing.Color struct
        /// </summary>
        /// <returns></returns>
        public Color GetNormalColor()
        {
            int _red, _green, _blue;
            _red = (int)(this.red * 2.55);
            _green = (int)(this.green * 2.55);
            _blue = (int)(this.blue * 2.55);
            return Color.FromArgb(_red, _green, _blue);
        }
        
        public static LogiColor FromColor(Color color)
        {
            return new LogiColor(color);
        }
    }

    public sealed class LogitechMouse : GenericDevice
    {
        #region Fields
        private LogiColor logiMainColor;
        #endregion

        #region Properties
        public new Color MainColor { get => logiMainColor.GetNormalColor(); set => logiMainColor = new LogiColor(value); }
        #endregion

        /// <summary>
        /// Constructor that also initializes the SDK
        /// </summary>
        public LogitechMouse()
        {
            // When initializing the logitech wrapper false means an error
            if (!LogiLEDAPI.LogiLedInit())
            {
                throw new RGBHardwareException("Could not start the logitech LED SDK");
            }
            this.type = DeviceType.LogitechMouse;
            LogiLEDAPI.LogiLedSetTargetDevice(LogiLEDAPI.LOGI_DEVICETYPE_RGB);
        }


        public override void WriteEffect(Effect effect, Color color)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Writes the described effect to the Logitech SDK with the MainColor
        /// </summary>
        /// <param name="effect"></param>
        public override void WriteEffect(Effect effect)
        {
            LogiLEDAPI.LogiLedSaveCurrentLighting();
            switch (effect)
            {
                case Effect.Off:
                    LogiLEDAPI.LogiLedStopEffects();
                    break;
                case Effect.Solid:
                    LogiLEDAPI.LogiLedSetLighting(logiMainColor.Red, logiMainColor.Green, logiMainColor.Blue);
                    break;
                case Effect.Flash:
                    LogiLEDAPI.LogiLedFlashLighting(logiMainColor.Red, logiMainColor.Green, logiMainColor.Blue, LogiLEDAPI.DURATION_INFINITE, interval);
                    break;
                case Effect.Breathe:
                    LogiLEDAPI.LogiLedPulseLighting(logiMainColor.Red, logiMainColor.Green, logiMainColor.Blue, LogiLEDAPI.DURATION_INFINITE, interval);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Shutdown the logitech API and dispose of all instance resources
        /// </summary>
        public override void Dispose()
        {
            LogiLEDAPI.LogiLedStopEffects();
            LogiLEDAPI.LogiLedRestoreLighting();
            LogiLEDAPI.LogiLedShutdown();
            this.Dispose();
        }

        public override void WriteColor(Color color)
        {
            throw new NotImplementedException();
        }

        public override void WriteColor(Color[] color)
        {
            throw new NotImplementedException();
        }

        public override Task WriteEffectAsync(Effect effect)
        {
            throw new NotImplementedException();
        }

        public override Task WriteEffectAsync(Effect effect, Color color)
        {
            throw new NotImplementedException();
        }

        public override Task WriteColorAsync(Color color)
        {
            throw new NotImplementedException();
        }

        public override Task WriteColorAsync(Color[] colors)
        {
            throw new NotImplementedException();
        }
    }

    public class LogitechKeyboard : GenericDevice
    {
        #region Fields
        private LogiColor logiMainColor;
        #endregion

        #region Properties
        public new Color MainColor { get => logiMainColor.GetNormalColor(); set => logiMainColor = new LogiColor(MainColor); }
        #endregion

        public LogitechKeyboard()
        {
            if (!LogiLEDAPI.LogiLedInit())
            {
                throw new RGBHardwareException("Error while communicating with LGS");
            }
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void WriteEffect(Effect effect, Color color)
        {
            throw new NotImplementedException();
        }

        public override void WriteEffect(Effect effect)
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

        public override Task WriteEffectAsync(Effect effect)
        {
            throw new NotImplementedException();
        }

        public override Task WriteEffectAsync(Effect effect, Color color)
        {
            throw new NotImplementedException();
        }

        public override Task WriteColorAsync(Color color)
        {
            throw new NotImplementedException();
        }

        public override Task WriteColorAsync(Color[] colors)
        {
            throw new NotImplementedException();
        }
    }
}
