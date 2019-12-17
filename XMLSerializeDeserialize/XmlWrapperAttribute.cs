using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSerializeDeserialize
{
    public class XmlWrapperAttribute : Attribute
    {
        public string Nome { get; set; }

        public XmlWrapperAttribute(string nome)
        {
            Nome = nome;
        }
    }
}
