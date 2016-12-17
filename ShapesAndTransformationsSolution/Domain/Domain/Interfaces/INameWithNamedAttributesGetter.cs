namespace Core.Interfaces
{
    using System.Collections.Generic;

    public interface INameWithNamedAttributesGetter
    {
        IEnumerable<INameWithNamedAttributes> Get();
    }
}
