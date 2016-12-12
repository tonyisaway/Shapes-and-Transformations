namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface INameWithNamedAttributesGetter
    {
        IEnumerable<INameWithNamedAttributes> Get();
    }
}
