using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerializeDeserialize
{
    public class ImportacaoEntidadeX : Base
    {
        public List<Customer> Customers { get; set; }
    }
}
