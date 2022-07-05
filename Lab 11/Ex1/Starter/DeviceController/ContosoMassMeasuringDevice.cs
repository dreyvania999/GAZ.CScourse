using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using DeviceControl;

namespace Contoso.MeasuringDevices
{
    class MassMeasuringDevice : IControllableDevice
    {
        Random rnd;
        public MassMeasuringDevice()
        {
            rnd = new Random();
        }
        public void StartDevice()
        {
        }

        public void StopDevice()
        {
        }
        public int GetLatestMeasure()
        {
            Thread.Sleep(rnd.Next(5000));
            return rnd.Next(1390);
        }
    }
}
