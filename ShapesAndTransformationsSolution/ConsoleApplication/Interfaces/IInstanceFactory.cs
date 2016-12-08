namespace ConsoleApplication.Interfaces
{
    public interface IInstanceFactory
    {
        object Create(string str, string instanceFamily);
    }
}
