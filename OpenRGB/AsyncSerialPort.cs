using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OpenRGB
{
    /// <summary>
    /// Wrapper for system.io.ports that provides asynchronous functionality
    /// </summary>
    public class AsyncSerialPort : SerialPort
    {
        public AsyncSerialPort() : base()
        {
        }

        public AsyncSerialPort(IContainer container) : base(container)
        {
        }

        public AsyncSerialPort(string portName) : base(portName)
        {
        }

        public AsyncSerialPort(string portName, int baudRate) : base(portName, baudRate)
        {
        }

        public AsyncSerialPort(string portName, int baudRate, Parity parity) : base(portName, baudRate, parity)
        {
        }

        public AsyncSerialPort(string portName, int baudRate, Parity parity, int dataBits) : base(portName, baudRate, parity, dataBits)
        {
        }

        public AsyncSerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits)
        {
        }
    }
}
