namespace ShapesAndTransformations.Tests
{
    using Core.Interfaces;
    using Infrastructure.Data;
    using Moq;
    using NUnit.Framework;

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
