using System;
using System.IO;

namespace laba6_2
{
    public class Mp3File : IRecordable
    {
        public string FilePath => filePath;
        private string filePath;

        public string FileName => fileName;
        private string fileName;

        public Mp3File(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Record()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
