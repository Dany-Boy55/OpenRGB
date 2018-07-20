using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRGB
{

    /// <summary>
    /// Describes the different types of RGB controllers availeable
    /// </summary>
    public enum ControllerType
    {
        Simple = 0,
        Addresseable = 1,
        SimpleAndAdresseable = 2,

    }

    /// <summary>
    /// Provides methods and properties common to all types of RGB controllers
    /// </summary>
    public class GenericController
    {
        private string name;
        private int id;
        private ControllerType type;

        public string Name { get => name; }
        public int Id { get => id;}

        public event EventHandler<EventArgs> DeviceRemoved;

        public void ChangeName()
        {
            throw new NotImplementedException();
        }

        public void Identify()
        {
            throw new NotImplementedException();
        }

        public Color ReadColor(Color color)
        {
            throw new NotImplementedException();
        }

        public Color ReadColor(Color[] colors)
        {
            throw new NotImplementedException();
        }

        public Color ReadColor(int colorNumber, Color color)
        {
            throw new NotImplementedException();
        }

        public void WriteColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void WriteColor(Color[] colors)
        {
            throw new NotImplementedException();
        }

        public void WriteColor(int colorNumber, Color color)
        {
            throw new NotImplementedException();
        }

        public void WriteEffect()
        {
            throw new NotImplementedException();
        }
    }
}
