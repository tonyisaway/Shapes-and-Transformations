namespace Domain.Commands
{
    using Interfaces;
    using System.Collections.Generic;

    public class NoCommand : IShapeCommand
    {
        public void Execute(IEnumerable<IShapeVertex> vertices)
        {
            
        }
    }
}
