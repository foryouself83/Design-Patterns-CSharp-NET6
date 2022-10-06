﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Model
{
    internal class Item
    {
        string _name;
        public Item(string name)
        {
            _name = name;
        }
        public string Name
        {
            get => _name;
        }
    }
}
