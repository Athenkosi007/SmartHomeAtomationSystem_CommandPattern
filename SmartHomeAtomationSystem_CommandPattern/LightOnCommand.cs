﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public LightOnCommand(Light light) => _light = light;

        public void Execute() => _light.TurnOn();
        public void Undo() => _light.TurnOff();
    }
}
