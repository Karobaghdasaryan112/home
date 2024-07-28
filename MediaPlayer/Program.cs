using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new MediaPlayer();
            playable.Play();
            playable.Stop();
            IRecordable recordable = new MediaPlayer();
            recordable.Record();
            recordable.StopRecord();
            Console.ReadLine();
        }
    }
}
