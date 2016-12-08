namespace ConsoleApplication.Models.Parameters.Transformations
{
    using Interfaces;

    public class MoveParameters : ITransformationParameters
    {
        public int Left { get; set; }
        public int Up { get; set; }
    }
}
