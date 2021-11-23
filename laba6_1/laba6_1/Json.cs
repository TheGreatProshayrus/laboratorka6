using System;

namespace Task1
{
    public class JsonDocument : Document
    {
        public override string Name { get; protected set; }

        public override void Create(string path)
        {
            throw new NotImplementedException();
        }

        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public override string[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string line)
        {
            throw new NotImplementedException();
        }
    }
}
