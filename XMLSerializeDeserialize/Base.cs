using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerializeDeserialize
{
    
    public abstract class Base 
    {
        public string Competencia { get; set; }
        public int UnidadeGestora { get; set; }
    }
}
