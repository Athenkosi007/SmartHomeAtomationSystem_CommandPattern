using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class MusicPlayer
    {
        public void Play() => Console.WriteLine("🎵 Music is playing");
        public void Stop() => Console.WriteLine("⏹️ Music stopped");
    }


}
