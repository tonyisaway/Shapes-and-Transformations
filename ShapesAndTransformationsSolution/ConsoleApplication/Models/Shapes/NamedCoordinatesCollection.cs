namespace ConsoleApplication.Models.Shapes
{
    using System.Collections.Generic;
    using Interfaces;

    public class NamedCoordinatesCollection
    {
        IList<KeyValuePair<string, ICoordinatePoint>> namedCoordinates = new List<KeyValuePair<string, ICoordinatePoint>>();

        public IList<KeyValuePair<string, ICoordinatePoint>> NamedCoordinates => namedCoordinates;

        public void Add(string name, ICoordinatePoint point)
        {
            var kvp = new KeyValuePair<string, ICoordinatePoint>(name, point);
            namedCoordinates.Add(kvp);
        }
    }
}
