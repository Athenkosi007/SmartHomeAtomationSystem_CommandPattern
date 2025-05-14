# SmartHomeAtomationSystem_CommandPattern

📌 Features
Control multiple smart home devices using commands

Turn Lights and Music ON or OFF

Set a desired Temperature for the Thermostat

Undo the last executed command

User-friendly prompts for interaction

🧠 Design Pattern Used
Command Pattern
The Command pattern encapsulates a request as an object, thereby allowing:

Parameterizing clients with queues, requests, or operations

Logging and undoing actions

Decoupling the invoker (RemoteControl) from the receiver (Light, MusicPlayer, Thermostat)

Each device operation is encapsulated in a command class implementing the ICommand interface.

SmartHomeControl/
│
├── ICommand.cs               # Command interface
├── RemoteControl.cs          # Invoker class
│
├── Devices/
│   ├── Light.cs
│   ├── MusicPlayer.cs
│   └── Thermostat.cs         # Receivers
│
├── Commands/
│   ├── LightOnCommand.cs
│   ├── LightOffCommand.cs
│   ├── PlayMusicCommand.cs
│   ├── StopMusicCommand.cs
│   └── SetTemperatureCommand.cs
│
└── Program.cs                # Console UI
