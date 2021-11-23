using System;
using System.IO;

namespace laba6_2
{
    public class MkvFile : IPlayable
    {
        public string FilePath => filePath;
        private string filePath;

        public string FileName => fileName;
        private string fileName;

        public MkvFile(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
