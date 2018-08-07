using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRGB.Devices;

namespace OpenRGB.Devices
{
    public sealed class SerialMatrix : GenericDevice
    {
        public override void Dispose()
        {
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

        public override void WriteEffect(Effect effect, Color color)
        {
            throw new NotImplementedException();
        }

        public override void WriteEffect(Effect effect)
        {
            throw new NotImplementedException();
        }
    }
}
