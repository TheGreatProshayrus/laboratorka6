using System;
using System.IO;

namespace laba6_2
{
    public class WavFile : IRecordable, IPlayable
    {
        public string FilePath => filePath;
        private string filePath;

        public string FileName => fileName;
        private string fileName;

        public WavFile(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }

        void IRecordable.Pause()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Pause()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Play()
        {
            throw new NotImplementedException();
        }

        void IRecordable.Record()
        {
            throw new NotImplementedException();
        }

        void IRecordable.Stop()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
