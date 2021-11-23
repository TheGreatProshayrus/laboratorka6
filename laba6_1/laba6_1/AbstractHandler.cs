namespace Task1
{
    public class AbstractHandler
    {
        public void Handle(Document document)
        {
            string[] lines = document.Read();

            for (int i = lines.Length - 1; i >= 0; i--)
                document.Write(lines[i]);
        }
    }
}
