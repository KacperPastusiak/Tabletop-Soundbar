using NAudio.Wave;

namespace Tabletop_Soundbar.Services
{
    internal class AudioService : IDisposable
    {
        private AudioFileReader? audioFile;
        private WaveOutEvent? audioOutEvent;

        public void SetSong(string path)
        {
            if (audioOutEvent != null)
            {
                audioOutEvent.Stop();
                audioOutEvent.Dispose();
                audioOutEvent = null;
            }

            try
            {
                audioFile = new AudioFileReader(path);

                audioOutEvent = new WaveOutEvent();
                audioOutEvent.Init(audioFile);
            }
            catch (Exception)
            {
                // log here
            }
        }

        public string GetSongName()
        {
            if (audioFile != null)
            {
                return audioFile.FileName.Split(Path.DirectorySeparatorChar).Last();
            }

            return "";
        }

        public void Play()
        {
            if (audioOutEvent != null && audioOutEvent.PlaybackState != PlaybackState.Playing)
                audioOutEvent.Play();
        }

        public void Pause()
        {
            if (audioOutEvent != null && audioOutEvent.PlaybackState == PlaybackState.Playing)
                audioOutEvent.Pause();
        }

        public void Stop()
        {
            if (audioOutEvent != null && audioOutEvent.PlaybackState == PlaybackState.Playing)
                audioOutEvent.Stop();
        }

        public void Dispose()
        {
            if (audioOutEvent != null)
            {
                try
                {
                    audioOutEvent.Stop();
                    audioOutEvent.Dispose();
                    audioOutEvent = null;
                }
                catch (Exception)
                {
                    // log here
                }
            }

            if (audioFile != null)
            {
                try
                {
                    audioFile.Close();
                    audioFile.Dispose();
                    audioFile = null;
                }
                catch (Exception)
                {
                    // log here
                }
            }
        }
    }
}
