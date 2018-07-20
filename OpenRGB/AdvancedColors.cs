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
            throw new NotImplementedException();
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
            float huePrime = Hue / 60;
            float X = chroma * (1 - Math.Abs((huePrime % 2) - 1));

            throw new NotImplementedException();
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
        private int ClampTo8Bit(float input)
        {
            int output;
            if (input > 255)
                output = 255;
            else if (input < 0)
                output = 0;
            else
                output = (int) input;
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
