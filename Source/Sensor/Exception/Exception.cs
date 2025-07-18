using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace System

{
    /// <summary>
    /// Represents a sensor reading over limits threshold.
    /// </summary>
    internal class SensorValueLimitException : Exception
    {
        public TimeOnly Time { get; private set; }
        public int id { get; private set; }
        
        public SensorValueLimitException(int id) : base()
        {
            this.Time = TimeOnly.FromTimeSpan(DateTime.Now.TimeOfDay);
            this.id = id;
        }
        public SensorValueLimitException(int id,string message) : base(message)
        {
            this.Time = TimeOnly.FromTimeSpan(DateTime.Now.TimeOfDay);
            this.id = id;
        }


    }

    /// <summary>
    /// Represents sensor communication failure.
    /// </summary>
    internal class SensorCommunicationException : Exception
    {
        public TimeOnly Time { get; private set; }
        public int id { get; private set; }
        public SensorCommunicationException(int id) : base()
        {
            this.Time = TimeOnly.FromTimeSpan(DateTime.Now.TimeOfDay);
            this.id = id;
        }
        public SensorCommunicationException(int id,string message) : base(message)
        {
            this.Time = TimeOnly.FromTimeSpan(DateTime.Now.TimeOfDay);
            this.id = id;
        }


    }
}
