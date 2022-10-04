using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Business
{
    internal class StpaSystem
    {
        public bool CanSave(string path)
        {
            return string.IsNullOrEmpty(path);
        }
        public bool SaveStpa(string path)
        {
            if (CanSave(path))
                return false;

            Console.WriteLine($"SaveStpa {path}");

            return true;
        }
    }
}
