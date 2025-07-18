using System;
using System.Collections.Generic;

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
        private const int threshold = 65000;//52428
        bool isConnected = false;
        int id;
        SensorType type;
        UInt16 value;
        Timer timer;
        Random random = Random.Shared;


        /// <exception cref="SensorValueLimitException">When sensor reading is over 80%</exception>
        /// <exception cref="SensorCommunicationException">Randomply throw so simulate communication failure</exception>
        public Sensor()
        {
            this.timer = new Timer(this.Randomize, this.value, 0, 1000);
            this.id = Random.Shared.Next(0, 100);

        }


        private void Randomize(object? value)
        {
            value = (UInt16)this.random.Next(65535);
            if ((UInt16)value % 1212 == 0)
            {
                isConnected = false;
                throw new SensorCommunicationException(this.id);
            }

            if ((UInt16)value > threshold)
                throw new SensorValueLimitException(this.id);

            Console.WriteLine(value);
        }

    }
}
