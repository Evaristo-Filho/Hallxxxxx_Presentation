using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    public class Class1
    {

        public static int Main()
        {
            return 100;
        }

    }


}


public interface SensorOutput
{
    public void Current();
    public void Resistence();
    public void Frequency();
    public void Voltage();

}