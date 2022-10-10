using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TemplateMethod.Model.Interface;

namespace TemplateMethod.Business
{
    public abstract class ModelAccessor : IModelAccessor
    {
        [XmlIgnore]
        public string CurrentFilePath { get; private set; } = string.Empty;

        [XmlAttribute(AttributeName = "ID")]
        public string Id { get; set; } = string.Empty;
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; } = string.Empty;
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// File 유/무 체크
        /// </summary>
        public bool IsExist(string path)
        {
            return File.Exists(path);
        }
        /// <summary>
        /// File format에 맞는 Serialize
        /// </summary>
        public abstract XmlDocument? Serialize(object model);
        /// <summary>
        /// File format에 맞는 Deserialize
        /// </summary>
        public abstract object? Deserialize(string path);
        public void Save(string path, object model)
        {
            CurrentFilePath = path;
            if (!IsExist(path)) throw new ArgumentException(nameof(path));
            Serialize(model);
        }
        public object? Load(string path)
        {
            CurrentFilePath = path;
            if (!IsExist(path)) throw new ArgumentException(nameof(path));
            return Deserialize(path);
        }
    }
}
