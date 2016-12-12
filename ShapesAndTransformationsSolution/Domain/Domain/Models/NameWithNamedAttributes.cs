namespace Domain.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class NameWithNamedAttributes : INameWithNamedAttributes
    {
        public IEnumerable<KeyValuePair<string, int>> Attributes { get; set; }
        public string Name { get; set; }
    }
}
