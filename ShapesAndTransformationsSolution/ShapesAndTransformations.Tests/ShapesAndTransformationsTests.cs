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

    [TestFixture]
    public class ShapesAndTransformationsTests
    {
        [Test]
        public void CanIntialiseShapesAndTransformations()
        {
            Assert.That(new Mock<IShapesAndTransformations>().Object, Is.InstanceOf<IShapesAndTransformations>());
        }

        [Test]
        public void ShapesAndTransformationsHasLoadShapes()
        {
            new Mock<IShapesAndTransformations>().Object.LoadShapes();
        }

        [Test]
        public void ShapesAndTransformationsHasPrintShapes()
        {
            new Mock<IShapesAndTransformations>().Object.PrintShapes();
        }

        [Test]
        public void ShapesAndTransformationsHasLoadTransforms()
        {
            new Mock<IShapesAndTransformations>().Object.LoadTransforms();
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

            try
            {
                var cr = new ShapesAndTransformationsConsoleRunner(shapesAndTransformations);
                Assert.Fail("An exception was expected.");
            }
            catch(ShapesAndTransformationsIsNullException)
            {
                Assert.Pass(string.Format("Exception of type ShapesAndTransformationsConsoleRunner.ShapesAndTransformationsIsNullException was thrown."));
            }
            catch(Exception ex)
            {
                Assert.Fail(string.Format("Exception of type '{0}' caught '{1}'.", ex.GetType(), ex.Message));
            }
        }

        [Test]
        public void CanCreateShapeAttributes()
        {
            var sa = new Mock<IShapeAttributes>().Object;
        }

        [Test]
        public void CanCreateShapeAttributesGetter()
        {
            var g = new Mock<IShapesAttributesGetter>().Object;
        }

        [Test]
        public void CanCallGetOnShapeAttributesGetter()
        {
            var g = new Mock<IShapesAttributesGetter>().Object;
            g.Get();
        }

        [Test]
        public void WhenCallingGetOnShapeAttributesGetterThenReturnedIsNotNull()
        {
            var g = new ShapesAttributesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.Not.Null);
        }

        [Test]
        public void WhenCallingGetOnShapeAttributesGetterThenReturnedIsCorrectInstanceOf()
        {
            var g = new ShapesAttributesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.InstanceOf<IEnumerable<IShapeAttributes>>());
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
        public void CanCreateShapeTransformationAttributes()
        {
            var sa = new Mock<IShapeTransformationAttributes>().Object;
        }

        [Test]
        public void CanCreateShapeTransformationsAttributesGetter()
        {
            var g = new Mock<IShapeTransformationsAttributesGetter>().Object;
        }

        [Test]
        public void CanCallGetOnShapeTransformationsAttributesGetter()
        {
            var g = new Mock<IShapeTransformationsAttributesGetter>().Object;
            g.Get();
        }

        [Test]
        public void WhenCallingGetOnShapeTransformationsAttributesGetterThenReturnedIsNotNull()
        {
            var g = new ShapeTransformationsAttributesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.Not.Null);
        }

        [Test]
        public void WhenCallingGetOnShapeTransformationsAttributesGetterThenReturnedIsCorrectInstanceOf()
        {
            var g = new ShapeTransformationsAttributesGetter();
            var returned = g.Get();

            Assert.That(returned, Is.InstanceOf<IEnumerable<IShapeTransformationAttributes>>());
        }

        [Test]
        public void CanCreateShapeAttributesPrinter()
        {
            var p = new Mock<IShapeAttributesPrinter>().Object;
        }

        [Test]
        public void CanCallPrintOnShapeAttributesPrinter()
        {
            var p = new Mock<IShapeAttributesPrinter>().Object;
            p.Print();

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
    }
}
