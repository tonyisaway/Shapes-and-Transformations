namespace Core.Services.Commands
{
    using Interfaces;
    using System.Collections.Generic;

    public class MoveCommand : IShapeCommand
    {
        public MoveCommand(int left, int up)
        {
            Left = left;
            Up = up;
        }

        public int Left { get; }
        public int Up { get; }

        public void Execute(IEnumerable<IShapeVertex> vertices)
        {
           
        }
    }
}
