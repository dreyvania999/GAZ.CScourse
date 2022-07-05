using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return rnd.Next(1390);
        }
    }
}
