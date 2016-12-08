namespace ConsoleApplication.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class MacroTransformer : ITransform
    {
        IEnumerable<ITransform> transforms;

        public MacroTransformer(IEnumerable<ITransform> transforms)
        {
            this.transforms = transforms;
        }

        public void Transform()
        {
            foreach(var t in transforms)
            {
                t.Transform();
            }
        }
    }
}