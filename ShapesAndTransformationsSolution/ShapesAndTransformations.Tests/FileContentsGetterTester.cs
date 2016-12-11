namespace ShapesAndTransformations.Tests
{
    using Moq;
    using NUnit.Framework;
    using Domain.Models;
    using Domain.Interfaces;

    [TestFixture]
    public class FileContentsGetterTester
    {
        [Test]
        public void CanCreateFileContentsGetter()
        {
            var g = new Mock<IFileContentsGetter>().Object;
        }

        [Test]
        public void CanCallGet()
        {
            var g = new Mock<IFileContentsGetter>().Object;
            g.Get();
        }

        [Test]
        public void CanInstantiateFileContentsGetterWithFilePath()
        {
            var filePath = "/App_Data/Shapes.xml";
            var g = new FileContentsGetter(filePath);
        }
    }
}
