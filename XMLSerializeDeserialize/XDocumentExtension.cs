using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLSerializeDeserialize
{
    public static class XDocumentExtension
    {
        public static T MapearPara<T>(this XDocument document)
        {
            XmlSerializer ser;
            var tipo = typeof(T);

            if (tipo.IsGenericType && tipo.GetGenericTypeDefinition() == typeof(List<>))
            {
                var xmlWrapper = tipo.GetGenericArguments().Single().GetCustomAttributes(typeof(XmlWrapperAttribute), true).FirstOrDefault() as XmlWrapperAttribute;
                ser = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlWrapper.Nome));
            }
            else
            {
                ser = new XmlSerializer(typeof(T));
            }

            using (StringReader sr = new StringReader(document.ToString()))
            {
                return (T)ser.Deserialize(sr);
            }
        }

    }
}
