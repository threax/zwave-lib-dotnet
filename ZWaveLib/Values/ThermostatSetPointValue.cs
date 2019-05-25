using System;
using System.Collections.Generic;
using System.Text;
using ZWaveLib.CommandClasses;

namespace ZWaveLib.Values
{
    public class ThermostatSetPointValue
    {
        public ThermostatSetPoint.Value Type { get; set; }

        public double Value { get; set; }
    }
}
