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
    public class StpaModel : ModelAccessor
    {
        [XmlAttribute(AttributeName = "Value")]
        public double SptaValue { get; set; }
        public StpaModel()
        {
            Id = Guid.NewGuid().ToString();
            Name = "STPA";
            Description = "STPA Description";
        }
        public override StpaModel? Deserialize(string path)
        {
            Console.WriteLine("Deserialize STPA Model");
            return XmlObjHelper.Parse<StpaModel>(path);
        }
        public override XmlDocument? Serialize(object stpaModel)
        {
            if (stpaModel is not StpaModel model) throw new ArgumentException(nameof(stpaModel));

            Console.WriteLine("Serialize STPA Model");
            return XmlObjHelper.XmlSerialize(model);
        }
    }
}
