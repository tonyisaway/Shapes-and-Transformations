namespace Domain.Models
{
    using System;
    using Interfaces;

    public class FileContentsGetter : IFileContentsGetter
    {
        string filePath;

        public FileContentsGetter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Get()
        {
            // throw new NotImplementedException();
        }
    }
}
