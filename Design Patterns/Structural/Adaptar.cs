using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural
{
    class Adaptar: AdvancedVideoPlayer
    {
        private readonly AudioPlayer _audioPlayer = new AudioPlayer("Adapted media player");
        public Adaptar(string playerName): base(playerName)
        {

        }

        public override void Play(string fileName)
        {
            try
            {
                base.Play(fileName);
            }
            catch
            {
                try
                {
                    _audioPlayer.Play(fileName);
                }
                catch (NotSupportedException ex)
                {

                    throw ex;
                }
                
            }
        }
        /**
         * Main
         * // I need to play audio in my advanced player

            AdvancedVideoPlayer player = new Adaptar("Play4Me Media Player");


            try
            {
                player.Play("themartians.mp3");
            }
            catch (NotSupportedException e)
            {
                Println($"Failed to play media - Error: {e.Message}");
            }
         * 
         * 
         */

    }

    interface IMediaPlayer
    {
        string Name { get; }
        void Play(string fileName);
        void Pause();
    }

    class AudioPlayer : IMediaPlayer
    {
        public string Name { get; }
        private readonly List<string> SupportedFormats = new List<string> { "mp3", "ogg", "3gp", "wav" };
        public AudioPlayer(string playerName)
        {
            Name = playerName;
            Console.WriteLine($"Created {playerName}");
        }


        public void Pause()
        {
            Console.WriteLine("Music Paused");
        }

        public void Play(string fileName)
        {
            string extension = GrabExtension(fileName);
            if (!SupportedFormats.Contains(extension))
            {
                throw new NotSupportedException("File format not supported");
            }
            Console.WriteLine($"Playing {fileName}");
        }

        public string GrabExtension(string fileName)
        {
            fileName = fileName.Trim();
            string extension = fileName.Split('.')[1];
            return extension;
        }
     
    }

    class VideoPlayer : IMediaPlayer
    {
        public string Name { get; }
        public readonly List<string> SupportedFormats = new List<string> { "mp4", "mkv", "ts", "mov" };

        public VideoPlayer(string playerName)
        {
            Name = playerName;
            Console.WriteLine($"Created {playerName}");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Video Paused");
        }

        public virtual void Play(string fileName)
        {
            string extension = GrabExtension(fileName);
            if (!SupportedFormats.Contains(extension))
            {
                throw new NotSupportedException("File format not supported");
            }
            Console.WriteLine($"Playing {fileName}");
        }

        public string GrabExtension(string fileName)
        {
            fileName = fileName.Trim();
            string extension = fileName.Split('.')[1];
            return extension;
        }
    }

    /// <summary>
    /// Player should be able to play audio
    /// </summary>
    class AdvancedVideoPlayer : VideoPlayer
    {
 
        public AdvancedVideoPlayer(string playerName): base(playerName)
        {
 
        }

        public override void Pause()
        {
            base.Pause();
        }

        public override void Play(string fileName)
        {
            base.Play(fileName);
        }
    }
}
