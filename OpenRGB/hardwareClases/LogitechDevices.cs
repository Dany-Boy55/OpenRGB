using System;
using LogitechLEDSDK;
using System.Drawing;

namespace OpenRGB.hardwareClases
{

    public enum LogiMouseEffects
    {
        Off,
        Solid, 
        Flash,
        Breathe,
    }

    public enum LogiKeyboardEffects
    {
        Off,
        Solid,
        Flash,
        Breathe,
        Matrix
    }


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
    }

    public class LogitechMouse
    {
        private LogiColor mainColor;
        private int interval;

        /// <summary>
        /// Constructor that also initializes the SDK
        /// </summary>
        public LogitechMouse()
        {
            LogitechGAPI.LogiLedInit();
            LogitechGAPI.LogiLedSetTargetDevice(LogitechGAPI.LOGI_DEVICETYPE_RGB);
        }

        public Color MainColor { get => mainColor.GetNormalColor(); set => mainColor = new LogiColor(value); }
        // Milliseconds bewteen actions for Flash and Breathe
        public int Interval { get => interval; set => interval = value; }

        /// <summary>
        /// Writes the described effect to the Logitech SDK with the MainColor
        /// </summary>
        /// <param name="effect"></param>
        public void writeEffect(LogiMouseEffects effect)
        {
            LogitechGAPI.LogiLedSaveCurrentLighting();
            switch (effect)
            {
                case LogiMouseEffects.Off:
                    LogitechGAPI.LogiLedStopEffects();
                    break;
                case LogiMouseEffects.Solid:
                    LogitechGAPI.LogiLedSetLighting(mainColor.Red, mainColor.Green, mainColor.Blue);
                    break;
                case LogiMouseEffects.Flash:
                    LogitechGAPI.LogiLedFlashLighting(mainColor.Red, mainColor.Green, mainColor.Blue, LogitechGAPI.LOGI_LED_DURATION_INFINITE, 500);
                    break;
                case LogiMouseEffects.Breathe:
                    LogitechGAPI.LogiLedPulseLighting(mainColor.Red, mainColor.Green, mainColor.Blue, LogitechGAPI.LOGI_LED_DURATION_INFINITE, 500);
                    break;
                default:
                    break;
            }
        }
    }
}
