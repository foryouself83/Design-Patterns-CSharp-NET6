using System.Xml;

namespace TemplateMethod.Model.Interface
{
    internal interface IModelAccessor
    {
        bool IsExist(string path);
        object? Load(string path);
        void Save(string path, object model);
        XmlDocument? Serialize(object model);
        object? Deserialize(string path);
    }
}