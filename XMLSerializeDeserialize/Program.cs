using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace XMLSerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = Directory.GetCurrentDirectory() + @"\Customer.xml";
            var documento = XDocument.Load(path);

            ImportacaoEntidadeX customers = documento.MapearPara<ImportacaoEntidadeX>();
            XDocument customerXML = customers.ToXML();


        }
    }
}
