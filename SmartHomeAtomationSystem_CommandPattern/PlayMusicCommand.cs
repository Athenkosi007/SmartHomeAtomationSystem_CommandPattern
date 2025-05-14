using System.Windows.Input;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class PlayMusicCommand : ICommand
    {
        private readonly MusicPlayer _player;
        public PlayMusicCommand(MusicPlayer player) => _player = player;

        public void Execute() => _player.Play();
        public void Undo() => _player.Stop();
    }

}
