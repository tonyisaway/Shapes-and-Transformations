namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface INameWithNamedAttributes
    {
        string Name { get; set; }
        IEnumerable<KeyValuePair<string, int>> Attributes { get; set; }
    }
}
