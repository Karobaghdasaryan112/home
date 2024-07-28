using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal  class MediaPlayer : IPlayable,IRecordable
    {
        void IRecordable.Record()
        {
            Console.WriteLine("Recording");
        }
        void IRecordable.StopRecord()
        {
            Console.WriteLine("stop Recording");
        }
        void IPlayable.Play()
        {
            Console.WriteLine("Playing");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop Playing");
        }
    }
}
