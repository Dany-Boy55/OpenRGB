using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRGB
{
    /// <summary>
    /// Provides aditional functionality for operating colors, particularly in HSV space
    /// </summary>
    public abstract class AdvancedColors
    {
        /// <summary>
        /// Transforms a color by rotating its hue in the HSV space
        /// </summary>
        /// <param name="color">Initial color</param>
        /// <param name="radians">Angle for hue rotation in radians</param>
        /// <returns></returns>
        public static Color RotateHue(Color color, double radians)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Transforms a color by rotating its hue in the HSV space
        /// </summary>
        /// <param name="color">Initial color</param>
        /// <param name="degrees">Angle for hue rotation in degrees</param>
        /// <returns></returns>
        public static Color RotateHue(Color color, int degrees)
        {
            int Hue =(int)color.GetHue();
            float Value = color.GetBrightness();
            float Saturation = color.GetSaturation();
            Hue = Hue + degrees;
            Color newcolor = new Color();
            newcolor = FromHSV(Hue, Value, Saturation);
            return newcolor;
        }

        /// <summary>
        /// Generates a color structure from HSV values
        /// </summary>
        /// <param name="Hue"> Hue between 0 and 1</param>
        /// <param name="Saturation"> Saturation between 0 and 1</param>
        /// <param name="Value"> Value between 0 and 1</param>
        /// <returns></returns>
        public static Color FromHSV(float Hue, float Saturation, float Value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a color structure from HSV values
        /// </summary>
        /// <param name="Hue"> Hue between 0 and 360 degrees</param>
        /// <param name="Saturation"> Saturation between 0 and 1</param>
        /// <param name="Value"> Value between 0 and 1</param>
        /// <returns></returns>
        static Color FromHSV(int Hue, float Saturation, float Value)
        {
            float chroma = Saturation * Value;
            float huePrime = Hue / 60F;
            float X = chroma * (1 - Math.Abs((huePrime % 2) - 1));
            float m = Value - chroma;
            float[] matrix = new float[3];
            if (Hue>=0 & Hue < 60)
            {
                matrix[0] = chroma;
                matrix[1] = X;
                matrix[2] = 0;
            }
            else if (Hue>=60 & Hue < 120)
            {
                matrix[0] = X;
                matrix[1] = chroma;
                matrix[2] = 0;
            }
            else if (Hue >= 120 & Hue < 180)
            {
                matrix[0] = 0;
                matrix[1] = chroma;
                matrix[2] = X;
            }
            else if (Hue >= 180 & Hue < 240)
            {
                matrix[0] = 0;
                matrix[1] = X;
                matrix[2] = chroma;
            }
            else if (Hue >= 240 & Hue < 300)
            {
                matrix[0] = X;
                matrix[1] = 0;
                matrix[2] = chroma;
            }
            else if (Hue >= 300 & Hue < 360)
            {
                matrix[0] = chroma;
                matrix[1] = 0;
                matrix[2] = X;
            }
            else
            {
                Console.WriteLine("Not a valid Hue (Must be between 0 and 360 degrees)");
            }
            return Color.FromArgb(ClampTo8Bit((matrix[0]+m)*255), ClampTo8Bit((matrix[1] + m) * 255), ClampTo8Bit((matrix[2] + m) * 255));
        }

        /// <summary>
        /// Constraints a number between 0 and 255
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int ClampTo8Bit(int input)
        {
            int output;
            if (input > 255)
                output = 255;
            else if (input < 0)
                output = 0;
            else
                output = input;
            return output;
        }

        /// <summary>
        /// Constraints a number between 0 and 255
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ClampTo8Bit(float input)
        {
            int output;
            if (input > 255)
                output = 255;
            else if (input < 0)
                output = 0;
            else
                output = (int)Math.Round(input);
            return output;
        }

        /// <summary>
        /// Constraints a number between 0 and 255
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int ClampTo8Bit(double input)
        {
            int output;
            if (input > 255)
                output = 255;
            else if (input < 0)
                output = 0;
            else
                output = (int)input;
            return output;
        }

        /// <summary>
        /// Constraints a number between 0 and 255
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int ClampTo8Bit(string input)
        {
            try
            {
                int output = Int32.Parse(input);
                if (output > 255)
                    output = 255;
                else if (output < 0)
                    output = 0;
                return output;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }
}
