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
        /// Used to be parsed a color struct as a hex string
        /// </summary>
        private static Dictionary<int, char> ByteHEXInt = new Dictionary<int, char>()
        {
            [0] = '0',
            [1] = '1',
            [2] = '2',
            [3] = '3',
            [4] = '4',
            [5] = '5',
            [6] = '6',
            [7] = '7',
            [8] = '8',
            [9] = '9',
            [10] = 'A',
            [11] = 'B',
            [12] = 'C',
            [13] = 'D',
            [14] = 'E',
            [15] = 'F',
        };

        private static Dictionary<char, int> HEXChar = new Dictionary<char, int>()
        {
            ['0'] = 0,
            ['1'] = 1,
            ['2'] = 2,
            ['3'] = 3,
            ['4'] = 4,
            ['5'] = 5,
            ['6'] = 6,
            ['7'] = 7,
            ['8'] = 8,
            ['9'] = 9,
            ['A'] = 10,
            ['B'] = 11,
            ['C'] = 12,
            ['D'] = 13,
            ['E'] = 14,
            ['F'] = 15,
        };

        /// <summary>
        /// Represents a color structure in hexadecimal form
        /// </summary>
        /// <param name="color"> Color to be prased as hex</param>
        /// <returns></returns>
        public static string ColorToHex(Color color)
        {
            char[] output = new char[6];
            // Use a dictionary to convert the numeric values into hexadecimal characters
            output[0] = ByteHEXInt[color.R / 16];
            output[1] = ByteHEXInt[color.R % 16];
            output[2] = ByteHEXInt[color.G / 16];
            output[3] = ByteHEXInt[color.G % 16];
            output[4] = ByteHEXInt[color.B / 16];
            output[5] = ByteHEXInt[color.B % 16];
            return new string(output);
        }

        /// <summary>
        /// Converts a string in hexadecimal form into a color struct
        /// </summary>
        /// <param name="hexcolor"> hexadecimal representation of an 8 bit color</param>
        /// <returns></returns>
        public static Color HexToColor(string hexcolor)
        {
            if (hexcolor.Length != 6)
                throw new ArgumentException("Hexadecimal color must contain 6 characters");
            else
            {
                hexcolor = hexcolor.ToUpper();
                int red = HEXChar[hexcolor[0]] * 16;
                red += HEXChar[hexcolor[1]];
                int green = HEXChar[hexcolor[2]] * 16;
                green += HEXChar[hexcolor[3]];
                int blue = HEXChar[hexcolor[4]] * 16;
                blue += HEXChar[hexcolor[5]];
                return Color.FromArgb(red, green, blue);
            }
        }

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
            return Color.FromArgb(0, 0, 0);
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
