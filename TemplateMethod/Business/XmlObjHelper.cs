using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TemplateMethod.Business
{
    public class XmlObjHelper
    {
        public static T? Parse<T>(string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                string outerXml = File.ReadAllText(path);
                StringReader textReader = new StringReader(outerXml);
                return (T?)xmlSerializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static XmlDocument? XmlSerialize<T>(T targetObject)
        {
            if (targetObject == null)
            {
                throw new ArgumentNullException("targetObject");
            }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlDeclaration newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);
                xmlDocument.InsertBefore(newChild, xmlDocument.DocumentElement);
                var navigator = xmlDocument.CreateNavigator();

                if (navigator is null) return null;

                using (XmlWriter xmlWriter = navigator.AppendChild())
                {
                    new XmlSerializer(targetObject.GetType()).Serialize(xmlWriter, targetObject);
                }

                return xmlDocument;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
