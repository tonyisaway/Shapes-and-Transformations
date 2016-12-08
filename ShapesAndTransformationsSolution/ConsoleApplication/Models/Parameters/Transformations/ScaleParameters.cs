namespace ConsoleApplication.Models.Parameters.Transformations
{
    using Interfaces;

    public class ScaleParameters : ITransformationParameters
    {
        public int Factor { get; set; }
    }
}
