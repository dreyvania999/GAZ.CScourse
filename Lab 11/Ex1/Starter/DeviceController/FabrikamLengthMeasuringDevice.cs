using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using DeviceControl;

namespace Fabrikam.Devices.MeasuringDevices
{
    class LengthMeasuringDevice : IControllableDevice
    {
        Random rnd;
        public LengthMeasuringDevice()
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
            Thread.Sleep(rnd.Next(6000));
            return rnd.Next(1000);
        }
    }
}
