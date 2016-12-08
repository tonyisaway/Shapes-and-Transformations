namespace ConsoleApplication.Interfaces
{
    public interface IShapeFactory
    {
        IShape Create(IShapeParameters parameters);
    }
}