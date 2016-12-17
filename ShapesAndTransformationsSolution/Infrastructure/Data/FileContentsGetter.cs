namespace Infrastructure.Data
{
    using Core.Interfaces;

    public class FileContentsGetter : IFileContentsGetter
    {
        string filePath;

        public FileContentsGetter(string filePath)
        {
            this.filePath = filePath;
        }

        public string Get() => System.IO.File.ReadAllText(filePath);
    }
}
