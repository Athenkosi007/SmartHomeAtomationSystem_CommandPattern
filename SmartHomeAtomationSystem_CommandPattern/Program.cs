namespace SmartHomeAtomationSystem_CommandPattern
{
    internal class Program
    {
        static void Main()
        {
            var remote = new RemoteControl();

            var light = new Light();
            var musicPlayer = new MusicPlayer();
            var thermostat = new Thermostat();

            var lightCommand = new LightOnCommand(light);
            var musicCommand = new PlayMusicCommand(musicPlayer);
            var tempCommand = new SetTemperatureCommand(thermostat, 22);

            remote.SendCommand(lightCommand);
            remote.SendCommand(musicCommand);
            remote.SendCommand(tempCommand);

            Console.WriteLine("\nUndoing last command:");
            remote.UndoLastCommand();

            Console.WriteLine("\nUndoing all:");
            remote.UndoLastCommand();
            remote.UndoLastCommand();
            remote.UndoLastCommand();

        }
    }
}
