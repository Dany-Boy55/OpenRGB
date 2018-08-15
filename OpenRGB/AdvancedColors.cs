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
        /// Used to for parsing a color struct into a hex string
        /// </summary>
        private static Dictionary<int, char> IntToHexChar = new Dictionary<int, char>()
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

        /// <summary>
        /// Used for parsing a hex string into a color
        /// </summary>
        private static Dictionary<char, int> HexCharToInt = new Dictionary<char, int>()
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
            output[0] = IntToHexChar[color.R / 16];
            output[1] = IntToHexChar[color.R % 16];
            output[2] = IntToHexChar[color.G / 16];
            output[3] = IntToHexChar[color.G % 16];
            output[4] = IntToHexChar[color.B / 16];
            output[5] = IntToHexChar[color.B % 16];
            return new string(output);
        }

        /// <summary>
        /// Converts a string in hexadecimal form into a color struct
        /// </summary>
        /// <param name="hexcolor"> hexadecimal representation of an 8 bit color</param>
        /// <returns></returns>
        public static Color HexStringToColor(string hexcolor)
        {
            if (hexcolor.Length != 6)
                throw new ArgumentException("Hexadecimal color must contain 6 characters");
            else
            {
                hexcolor = hexcolor.ToUpper();
                int red = HexCharToInt[hexcolor[0]] * 16;
                red += HexCharToInt[hexcolor[1]];
                int green = HexCharToInt[hexcolor[2]] * 16;
                green += HexCharToInt[hexcolor[3]];
                int blue = HexCharToInt[hexcolor[4]] * 16;
                blue += HexCharToInt[hexcolor[5]];
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
        /// <param name="Hue"> Hue between 0 and 2*pi</param>
        /// <param name="Saturation"> Saturation between 0 and 1</param>
        /// <param name="Value"> Value between 0 and 1</param>
        /// <returns></returns>
        public static Color FromHSV(float hue, float saturation, float value)
        {
            // Since hue is cyclic, we make sure to limit it between 0 and 2 pi
            while (hue < 0) hue += (float)(2 * Math.PI);
            while (hue > 2 * Math.PI) hue -= (float)(2 * Math.PI);
            // Saturation and Value however must be between 0 and 1
            if (saturation < 0 || saturation > 1)
                throw new ArgumentOutOfRangeException("Saturation must have a value between 0 and 1");
            if (value < 0 || value > 1)
                throw new ArgumentOutOfRangeException("Value must have a value between 0 and 1");
            // Method taken from https://en.wikipedia.org/wiki/HSL_and_HSV#From_HSV
            double chroma = (double)(value * saturation);
            double huePrime = hue / (Math.PI / 3);
            double x = chroma * (1 - Math.Abs((huePrime % 2) - 1));
            double m = (double)(value - chroma);
            int r = 0, g = 0, b = 0;
            if (x > 0 && x <= 1)
            {
                r = ClampTo8Bit(chroma + m);
                g = ClampTo8Bit(x + m);
                b = ClampTo8Bit(m);
                return Color.FromArgb(r, g, b);
            }
            else if (huePrime> 1 && huePrime<= 2)
            {
                r = ClampTo8Bit(x + m);
                g = ClampTo8Bit(chroma + m);
                b = ClampTo8Bit(m);
                return Color.FromArgb(r, g, b);
            }
            else if (huePrime> 2 && huePrime<= 3)
            {
                r = ClampTo8Bit(m);
                g = ClampTo8Bit(chroma + m);
                b = ClampTo8Bit(x + m);
                return Color.FromArgb(r, g, b);
            }
            else if (huePrime> 3 && huePrime<= 4)
            {
                r = ClampTo8Bit(m);
                g = ClampTo8Bit(x + m);
                b = ClampTo8Bit(chroma + m);
                return Color.FromArgb(r, g, b);
            }
            else if (huePrime> 4 && huePrime<= 5)
            {
                r = ClampTo8Bit(x + m);
                g = ClampTo8Bit(m);
                b = ClampTo8Bit(chroma + m);
                return Color.FromArgb(r, g, b);
            }
            else if (huePrime> 5 && huePrime<= 6)
            {
                r = ClampTo8Bit(chroma + m);
                g = 0;
                b = ClampTo8Bit(x + m);
                return Color.FromArgb(r, g, b);
            }
            else return Color.FromArgb(0,0,0);
        }

        /// <summary>
        /// Generates a color structure from HSV values
        /// </summary>
        /// <param name="Hue"> Hue between 0 and 360 degrees</param>
        /// <param name="Saturation"> Saturation between 0 and 100</param>
        /// <param name="Value"> Value between 0 and 100</param>
        /// <returns></returns>
        public static Color FromHSV(int hue, int saturation, int value)
        {
            // Convert hue into radians, sat and value from 0-1
            float _hue = (float)(hue * Math.PI / 180);
            if (saturation < 0 || saturation > 100)
                throw new ArgumentOutOfRangeException("Saturation must be between 0 and 100");
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException("Value must be between 0 and 100");
            float _satturation = saturation / 100;
            float _value = value / 100;
            return FromHSV(_hue, _satturation, _value);
        }

        /// <summary>
        /// Constraints a number between 0 and 255
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int ClampTo8Bit(float input)
        {
            int output;
            if (input > 1)
                output = 255;
            else if (input < 0)
                output = 0;
            else
                output = (int)(input * 255);
            return output;
        }

        /// <summary>
        /// Constraints a number between 0 and 255
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int ClampTo8Bit(double input)
        {
            int output;
            if (input > 1)
                output = 255;
            else if (input < 0)
                output = 0;
            else
                output = (int)(input * 255);
            return output;
        }
    }
}
