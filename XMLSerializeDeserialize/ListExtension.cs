using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLSerializeDeserialize
{
    public static class ListExtension
    {
        public static XDocument ToXML<T>(this List<T> list) {

            var xmlWrapper = typeof(T).GetCustomAttributes(typeof(XmlWrapperAttribute), true).FirstOrDefault() as XmlWrapperAttribute;
            XmlSerializer xmlSerializer = new XmlSerializer(list.GetType(), new XmlRootAttribute(xmlWrapper.Nome)) ;

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, list);
                return XDocument.Parse(textWriter.ToString());
            }
        }
       
    }
}
