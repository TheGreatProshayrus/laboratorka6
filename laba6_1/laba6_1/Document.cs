namespace Task1
{
    public abstract class Document
    {
        public abstract string Name { get; protected set; }

        public abstract void Open(string path);
        public abstract void Create(string path);
        public abstract string[] Read();
        public abstract void Write(string line);
    }
}
