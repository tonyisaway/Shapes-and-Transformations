namespace ConsoleApplication.Interfaces
{
    using System.Collections.Generic;

    public interface ICoordinateTransform
    {
        IEnumerable<ICoordinatePoint> Coordinates { get; }
    }
}
