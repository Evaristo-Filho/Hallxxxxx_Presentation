using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.Enums
{
    /// <summary>
    /// Describes sensor type
    /// </summary>
    public enum SensorType
    {
        Unselected,
        Temperature,
        Pressure,
        Flow

    }
    /// <summary>
    /// Describes sensor output type
    /// </summary>
    public enum SensorOutput
    {
        Unselected,
        CurrentLoop,
        Voltage,
        Resistence,
        Frequency
    }
    //public enum Type { }

}
