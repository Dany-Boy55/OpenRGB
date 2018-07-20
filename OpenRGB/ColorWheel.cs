using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Configuration;

namespace OpenRGB
{
    /// <summary>
    /// Control that creates a Color Wheel using the hue-saturation space
    /// </summary>
    class ColorWheel : UserControl
    {
        private int radius;
        private Color _color;
        private Bitmap wheel;

        public int Radius { get => radius; }

        public ColorWheel(int rad = 50)
        {
            radius = rad;
            this.Size = new Size(rad * 2, rad * 2);
        }

        /// <summary>
        /// Calculates the distance between a point and the center of the control
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private int DistanceFromCenter(Point point)
        {
            Point center = new Point(this.Width / 2, this.Height / 2);
            double xDist, yDist, totalDist;
            // Simple pythagorean theorem distance = sqrt(x^2 + y^2)
            xDist = Math.Abs(point.X - center.X);
            yDist = Math.Abs(point.Y - center.Y);
            totalDist = yDist * yDist + xDist*xDist;
            totalDist = Math.Sqrt(totalDist);
            return (int)totalDist;
        }

        /// <summary>
        /// Generates a bitmap of a colorwheel with the control's specified radius
        /// </summary>
        private void generateWheel()
        {
            Graphics g = Graphics.FromImage(wheel);
            for (int x = 0; x < this.Width; x++)
            {
                for (int y = 0; y < this.Height; y++)
                {
                    Point current = new Point(x, y);
                    int dist = DistanceFromCenter(current);
                    if(dist > radius)
                    {
                        continue;
                    }
                    else
                    {
                        double angle = Math.Atan(y/x);

                    }
                }
            }

            throw new NotImplementedException();
        }
    }
}
