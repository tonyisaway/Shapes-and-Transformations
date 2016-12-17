namespace Core.Services
{
    using Commands;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapeCommandGetter : IShapeCommandGetter
    {
        public IShapeCommand Get(INameWithNamedAttributes instructions)
        {
            if (instructions == null)
            {
                throw new ArgumentNullException(nameof(instructions));
            }
            
            switch (instructions.Name.ToLower())
            {
                case "scale":

                    var factorAttribute = instructions.Attributes.SingleOrDefault(x =>  x.Key == "factor");
                    if (factorAttribute.Equals(default(KeyValuePair<string, int>)))
                    {
                        throw new InvalidOperationException("Factor attribute not found on scale instructions");
                    }

                    return new ScaleCommand(factorAttribute.Value);

                case "move":

                    var left = instructions.Attributes.SingleOrDefault(x => x.Key == "left");
                    if (left.Equals(default(KeyValuePair<string, int>)))
                    {
                        throw new InvalidOperationException("Left attribute not found on move instructions");
                    }

                    var up = instructions.Attributes.SingleOrDefault(x => x.Key == "up");
                    if (up.Equals(default(KeyValuePair<string, int>)))
                    {
                        throw new InvalidOperationException("Up attribute not found on move instructions");
                    }

                    return new MoveCommand(left.Value, up.Value);

                case "rotate":

                    var degrees = instructions.Attributes.SingleOrDefault(x => x.Key == "degrees");
                    if (degrees.Equals(default(KeyValuePair<string, int>)))
                    {
                        throw new InvalidOperationException("Degrees attribute not found on rotate instructions");
                    }

                    return new RotateCommand(degrees.Value);
            }

            return new NoCommand();
        }
    }
}
