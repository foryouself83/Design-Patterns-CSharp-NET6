using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TemplateMethod.Business;

namespace TemplateMethod.Model
{    
    public class FtaModel : ModelAccessor
    {
        [XmlAttribute(AttributeName = "Value")]
        public double FtaValue { get; set; }

        public FtaModel()
        {
            Id = Guid.NewGuid().ToString();
            Name = "FTA";
            Description = "FTA Description";
        }

        public override FtaModel? Deserialize(string path)
        {
            Console.WriteLine("Deserialize FTA Model");
            return XmlObjHelper.Parse<FtaModel>(path);            
        }
        public override XmlDocument? Serialize(object ftaModel)
        {
            if (ftaModel is not FtaModel model) throw new ArgumentException(nameof(ftaModel));

            Console.WriteLine("Serialize FTA Model");
            return XmlObjHelper.XmlSerialize(model);
        }
    }
}
