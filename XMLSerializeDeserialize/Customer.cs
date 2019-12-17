using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerializeDeserialize
{
    [XmlWrapper("Customers")]
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Fax { get; set; }
        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }
    }
}
