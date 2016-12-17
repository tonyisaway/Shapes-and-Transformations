namespace Core.Services.Commands
{
    using Interfaces;
    using System.Collections.Generic;

    public class ScaleCommand : IShapeCommand
    {
        public ScaleCommand(int factor)
        {
            Factor = factor;
        }

        public int Factor { get; }

        public void Execute(IEnumerable<IShapeVertex> vertices)
        {
            
        }
    }
}
