namespace SmartHomeAtomationSystem_CommandPattern
{
    class Program
    {
        static void Main()
        {
            var remote = new RemoteControl();

            var light = new Light();
            var musicPlayer = new MusicPlayer();
            var thermostat = new Thermostat();

            while (true)
            {
                Console.WriteLine("\n--- Smart Home Control ---");
                Console.WriteLine("1. Light");
                Console.WriteLine("2. Music");
                Console.WriteLine("3. Thermostat");
                Console.WriteLine("4. Undo last command");
                Console.WriteLine("5. Exit");
                Console.Write("Choose a device (1-5): ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Turn light ON or OFF? (on/off): ");
                        var lightChoice = Console.ReadLine()?.ToLower();
                        if (lightChoice == "on")
                            remote.SendCommand(new LightOnCommand(light));
                        else
                            remote.SendCommand(new LightOffCommand(light));
                        break;

                    case "2":
                        Console.Write("Turn music ON or OFF? (on/off): ");
                        var musicChoice = Console.ReadLine()?.ToLower();
                        if (musicChoice == "on")
                            remote.SendCommand(new PlayMusicCommand(musicPlayer));
                        else
                            remote.SendCommand(new StopMusicCommand(musicPlayer));
                        break;

                    case "3":
                        Console.Write("Enter temperature in °C: ");
                        if (int.TryParse(Console.ReadLine(), out int temp))
                            remote.SendCommand(new SetTemperatureCommand(thermostat, temp));
                        else
                            Console.WriteLine("❌ Invalid temperature.");
                        break;

                    case "4":
                        remote.UndoLastCommand();
                        break;

                    case "5":
                        Console.WriteLine("👋 Exiting Smart Home System.");
                        return;

                    default:
                        Console.WriteLine("❌ Invalid choice.");
                        break;
                }
            }
        }
    }

}
