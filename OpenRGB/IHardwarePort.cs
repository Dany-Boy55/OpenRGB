using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRGB
{
    /// <summary>
    /// Specifies methods and fields used for communicating with hardware regardless of port type
    /// </summary>
    interface IHardwarePort
    {
        Task WriteAsync(string data);
        Task WriteAsync(byte[] data);

        event EventHandler DataAvaileable;

        void OnDataAvaileable();
    }
    
}
