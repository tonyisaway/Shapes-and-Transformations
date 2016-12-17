namespace Core.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class NameWithNamedAttributes : INameWithNamedAttributes
    {
        public IEnumerable<KeyValuePair<string, int>> Attributes { get; set; }
        public string Name { get; set; }
    }
}
