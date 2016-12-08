namespace ConsoleApplication.Models.Parameters.Transformations
{
    using Interfaces;

    public class RotateParameters : ITransformationParameters
    {
        public int Degrees { get; set; }
    }
}
