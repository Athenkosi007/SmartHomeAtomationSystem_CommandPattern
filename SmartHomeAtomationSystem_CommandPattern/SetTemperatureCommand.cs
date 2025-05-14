using System.Windows.Input;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class SetTemperatureCommand : ICommand
    {
        private readonly Thermostat _thermostat;
        private readonly int _temperature;
        public SetTemperatureCommand(Thermostat thermostat, int temperature)
        {
            _thermostat = thermostat;
            _temperature = temperature;
        }

        public void Execute() => _thermostat.SetTemperature(_temperature);
        public void Undo() => Console.WriteLine("🌡️ Temperature reset (undo not implemented)");
    }

}
