namespace Domain.Commands
{
    using Interfaces;
    using System.Collections.Generic;

    public class RotateCommand : IShapeCommand
    {
        public RotateCommand(int degrees)
        {
            Degrees = degrees;
        }

        public int Degrees { get; }

        public void Execute(IEnumerable<IShapeVertex> vertices)
        {
            
        }
    }
}
