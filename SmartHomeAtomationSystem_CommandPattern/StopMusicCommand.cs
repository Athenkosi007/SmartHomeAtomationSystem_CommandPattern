using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class StopMusicCommand : ICommand
    {
        private readonly MusicPlayer _player;
        public StopMusicCommand(MusicPlayer player) => _player = player;

        public void Execute() => _player.Stop();
        public void Undo() => _player.Play();
    }

}
