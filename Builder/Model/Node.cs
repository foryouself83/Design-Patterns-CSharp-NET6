using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
    internal class Node
    {
        private string? _id;
        private string? _name;
        private string? _description;
        private string? _type;
        private object? _parent;

        public Node()
        {

        }
        public Node SetId(string id)
        {
            _id = id;
            return this;
        }
        public Node SetName(string name)
        {
            _name = name;
            return this;
        }
        public Node SetDescription(string description)
        {
            _description = description;
            return this;
        }
        public Node SetType(string type)
        {
            _type = type;
            return this;
        }
        public Node SetParent(object? parent)
        {
            _parent = parent;
            return this;
        }
        public override string ToString()
        {
            return String.Format($"ID:{this._id}\r\nName:{this._name}\r\nDescription:{this._description}\r\nType:{this._type}\r\nParent:{this._parent ?? "NULL"}");
        }
    }

}
