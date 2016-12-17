namespace Core.Services
{
    using Interfaces;
    using System.Collections.Generic;

    public class ShapeCommandsGetter : IShapeCommandsGetter
    {
        IShapeCommandGetter shapeCommandGetter;

        public ShapeCommandsGetter(IShapeCommandGetter shapeCommandGetter)
        {
            this.shapeCommandGetter = shapeCommandGetter;
        }

        public IEnumerable<IShapeCommand> Get(IEnumerable<INameWithNamedAttributes> instructions)
        {
            var commands = new List<IShapeCommand>();

            foreach(var instruction in instructions)
            {
                var command = shapeCommandGetter.Get(instruction);
                commands.Add(command);
            }

            return commands;
        }
    }
}
