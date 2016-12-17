namespace Core.Interfaces
{
    using System.Collections.Generic;

    public interface INameWithNamedAttributesConsolePrinter
    {
        void Print(IEnumerable<INameWithNamedAttributes> shapesAttributes);
    }
}
