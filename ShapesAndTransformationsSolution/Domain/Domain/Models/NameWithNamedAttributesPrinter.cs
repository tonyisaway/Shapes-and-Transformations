namespace Domain.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    public class NameWithNamedAttributesConsolePrinter : INameWithNamedAttributesConsolePrinter
    {
        public void Print(IEnumerable<INameWithNamedAttributes> nameWithNamedAttributeses)
        {
            foreach(var n in nameWithNamedAttributeses)
            {
                Console.WriteLine(string.Format("Name: {0}", n.Name));

                foreach (var a in n.Attributes)
                {
                    Console.WriteLine(string.Format("{0}: {1}", a.Key, a.Value));
                }

                Console.WriteLine("---");
            }

            Console.WriteLine();
        }
    }
}
