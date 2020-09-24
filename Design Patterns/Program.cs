using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Structural;

namespace Design_Patterns
{
    class Program
    {
        static public void Println<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            // I need to play audio in my advanced player

            AdvancedVideoPlayer player = new Adaptar("Play4Me Media Player");


            try
            {
                player.Play("themartians.mp3");
            }
            catch (NotSupportedException e)
            {
                Println($"Failed to play media - Error: {e.Message}");
            }
        }
    }

}
