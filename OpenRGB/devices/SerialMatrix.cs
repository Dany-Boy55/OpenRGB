using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using OpenRGB.Devices;

namespace OpenRGB.Devices
{
    public sealed class SerialMatrix : GenericDevice
    {

        #region Fields
        private SerialPort port;
        #endregion

        #region properties

        #endregion

        public SerialMatrix(string portName)
        {
            port = new SerialPort(portName, 19200);
        }

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

        public override Task WriteColorAsync(Color color)
        {
            throw new NotImplementedException();
        }

        public override Task WriteColorAsync(Color[] colors)
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

        public override Task WriteEffectAsync(Effect effect)
        {
            throw new NotImplementedException();
        }

        public override Task WriteEffectAsync(Effect effect, Color color)
        {
            throw new NotImplementedException();
        }
    }
}
