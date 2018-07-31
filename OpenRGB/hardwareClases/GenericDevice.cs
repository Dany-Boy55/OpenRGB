using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRGBDevices;

namespace OpenRGB.hardwareClases
{
    /// <summary>
    /// Used as a placeholder while an actual device is being set up
    /// </summary>
    class GenericDevice
    {
        private ControllerType type;

        protected ControllerType Type { get => type; }

        public GenericDevice(ControllerType initialType)
        {
            this.type = initialType;
        }
    }
}
