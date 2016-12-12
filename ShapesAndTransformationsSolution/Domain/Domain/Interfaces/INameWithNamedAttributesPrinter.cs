using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface INameWithNamedAttributesConsolePrinter
    {
        void Print(IEnumerable<INameWithNamedAttributes> shapesAttributes);
    }
}
