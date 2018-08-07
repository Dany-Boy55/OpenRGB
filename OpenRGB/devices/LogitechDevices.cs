using System;
using OpenRGB.Devices;
using OpenRGB.lib;
using System.Drawing;

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

    public class LogitechMouse : GenericDevice
    {
        #region Fields
        private LogiColor mainColor;
        private int interval;
        #endregion

        #region Properties
        public Color MainColor { get => mainColor.GetNormalColor(); set => mainColor = new LogiColor(value); }
        // Milliseconds bewteen actions for Flash and Breathe
        public int Interval { get => interval; set => interval = value; }
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
                    LogiLEDAPI.LogiLedSetLighting(mainColor.Red, mainColor.Green, mainColor.Blue);
                    break;
                case Effect.Flash:
                    LogiLEDAPI.LogiLedFlashLighting(mainColor.Red, mainColor.Green, mainColor.Blue, LogiLEDAPI.DURATION_INFINITE, interval);
                    break;
                case Effect.Breathe:
                    LogiLEDAPI.LogiLedPulseLighting(mainColor.Red, mainColor.Green, mainColor.Blue, LogiLEDAPI.DURATION_INFINITE, interval);
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
    }

    public class LogitechKeyboard
    {
        #region Fields
        private LogiColor mainColor;
        private int interval;
        #endregion

        #region Properties
        public Color MainColor { get => mainColor.GetNormalColor(); set => mainColor = new LogiColor(MainColor); }
        #endregion

        public LogitechKeyboard()
        {
            if (!LogiLEDAPI.LogiLedInit())
            {
                throw new RGBHardwareException("Error while communicating with LGS");
            }
        }

    }
}
