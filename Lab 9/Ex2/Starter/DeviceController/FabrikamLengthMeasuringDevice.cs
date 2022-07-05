﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return rnd.Next(1000);
        }
    }
}
