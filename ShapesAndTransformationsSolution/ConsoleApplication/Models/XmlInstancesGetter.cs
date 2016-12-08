﻿namespace ConsoleApplication.Models
{
    using System.Collections.ObjectModel;
    using Interfaces;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class XmlInstancesGetter : IInstancesGetter
    {
        IInstanceFactory factory;
        IList<object> objects = new List<object>();

        public XmlInstancesGetter(IInstanceFactory factory)
        {
            this.factory = factory;
        }

        public IReadOnlyCollection<object> GetAll(XElement xml)
        {
            foreach(var element in xml.Elements())
            {
                var obj = factory.Create(element.ToString(), xml.Name.LocalName);
                objects.Add(obj);
            }

            return new ReadOnlyCollection<object>(objects);
        }
    }
}
