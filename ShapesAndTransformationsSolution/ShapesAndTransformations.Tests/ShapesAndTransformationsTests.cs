namespace ShapesAndTransformations.Tests
{
    using NUnit.Framework;
    using Contracts;
    using Moq;
    using ConsoleApplication;
    using System;
    using Domain.Exceptions;
    using Domain.Interfaces;
    using System.Collections.Generic;
    using Domain.Models;
    using NUnit.Framework.Constraints;

    [TestFixture]
    public class ShapesAndTransformationsTests
    {
        [Test]
        public void CanIntialiseShapesAndTransformations()
        {
            Assert.That(new Mock<IShapesAndTransformations>().Object, Is.InstanceOf<IShapesAndTransformations>());
        }

        [Test]
        public void ShapesAndTransformationsHasTransformShapes()
        {
            new Mock<IShapesAndTransformations>().Object.TransformShapes();
        }

        [Test]
        public void CanPassShapesAndTransformationsToConsoleRunner()
        {
            var shapesAndTransformations = new Mock<IShapesAndTransformations>().Object;
            var st = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);
        }

        [Test]
        public void PassingNullShapesAndTransformationsToConsoleRunnerThrowsException()
        {

            IShapesAndTransformations shapesAndTransformations = null;

            //Act
            ActualValueDelegate<object> testDelegate = () => new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);

            //Assert
            Assert.That(testDelegate, Throws.TypeOf<ShapesAndTransformationsIsNullException>());

            //try
            //{
            //    var cr = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);
            //    Assert.Fail("An exception was expected.");
            //}
            //catch(ShapesAndTransformationsIsNullException)
            //{
            //    Assert.Pass(string.Format("Exception of type ShapesAndTransformationsConsoleRunner.ShapesAndTransformationsIsNullException was thrown."));
            //}
            //catch(Exception ex)
            //{
            //    Assert.Fail(string.Format("Exception of type '{0}' caught '{1}'.", ex.GetType(), ex.Message));
            //}
        }

        [Test]
        public void CanCreateShapeAttributes()
        {
            var sa = new Mock<INameWithNamedAttributes>().Object;
        }

        [Test]
        public void CanCreateShapeAttributesGetter()
        {
            var g = new Mock<INameWithNamedAttributesGetter>().Object;
        }

        [Test]
        public void CanCallGetOnShapeAttributesGetter()
        {
            var g = new Mock<INameWithNamedAttributesGetter>().Object;
            g.Get();
        }

        [Test]
        public void WhenCallingGetOnShapeAttributesGetterThenReturnedIsNotNull()
        {
            var g = GetNameWithNamedAttributesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.Not.Null);
        }

        static NameWithNamedAttributesGetter GetNameWithNamedAttributesGetter()
        {
            return new NameWithNamedAttributesGetter(new Mock<IFileContentsGetter>().Object
                , new Mock<IXElementToNameWithNamedAttributesConvertor>().Object);
        }

        [Test]
        public void WhenCallingGetOnShapeAttributesGetterThenReturnedIsCorrectInstanceOf()
        {
            var g = GetNameWithNamedAttributesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.InstanceOf<IEnumerable<INameWithNamedAttributes>>());
        }

        [Test]
        public void CanCreateShapeVertex()
        {
            var sa = new Mock<IShapeVertex>().Object;
        }

        [Test]
        public void CanCreateShapeVerticesGetter()
        {
            var g = new Mock<IShapeVerticesGetter>().Object;
        }

        [Test]
        public void CanCallGetOnShapeVerticesGetter()
        {
            var g = new Mock<IShapeVerticesGetter>().Object;
            g.Get();
        }

        [Test]
        public void WhenCallingGetOnShapeVerticesGetterThenReturnedIsNotNull()
        {
            var g = new ShapeVerticesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.Not.Null);
        }

        [Test]
        public void WhenCallingGetOnShapeVerticesGetterThenReturnedIsCorrectInstanceOf()
        {
            var g = new ShapeVerticesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.InstanceOf<IEnumerable<IShapeVertex>>());
        }
        
        [Test]
        public void CanCreateShapeAttributesPrinter()
        {
            var p = new Mock<INameWithNamedAttributesConsolePrinter>().Object;
        }

        [Test]
        public void CanCallPrintOnShapeAttributesPrinter()
        {
            var p = new Mock<INameWithNamedAttributesConsolePrinter>().Object;
            var attributes = new List<INameWithNamedAttributes>();
            p.Print(attributes);

        }

        [Test]
        public void CanCreateShapeTransformer()
        {
            var p = new Mock<IShapeTransformer>().Object;
        }

        [Test]
        public void CanCallTransformOnShapeTransformer()
        {
            var p = new Mock<IShapeTransformer>().Object;
            p.Transform();

        }

        [Test]
        public void Test()
        {

        }
    }
}
