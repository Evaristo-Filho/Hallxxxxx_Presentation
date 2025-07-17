using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Sensor.Enums;

namespace Sensor
{
    /// <summary>
    /// Represents unmanaged data read from a sensor driver
    /// </summary>
    public struct Sensor
    {
        SensorType type;
        UInt16 value;
        Timer timer;
        Random random=Random.Shared;
        public Sensor()
        {
            this.timer = new Timer(this.Randomize,this.value,0,1000);
                       
        }
        public void Randomize(object? value)
        {
            value = (UInt16)this.random.Next(65535);
            Console.WriteLine(value);
        }

    }
}
