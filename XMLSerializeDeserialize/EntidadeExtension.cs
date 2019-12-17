using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLSerializeDeserialize
{
    public static class EntidadeExtension
    {
        public static XDocument ToXML<T>(this T entidade)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(entidade.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, entidade);
                return XDocument.Parse(textWriter.ToString());
            }
        }
    }
}
