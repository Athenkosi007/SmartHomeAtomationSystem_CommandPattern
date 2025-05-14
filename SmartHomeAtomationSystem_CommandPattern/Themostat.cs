using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class Thermostat
    {
        public void SetTemperature(int temperature) => Console.WriteLine($"🌡️ Temperature set to {temperature}°C");
    }
}
