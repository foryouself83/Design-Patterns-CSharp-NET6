using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Business
{
    internal class FtaSystem
    {
        public bool CanSave(string path)
        {
            return string.IsNullOrEmpty(path);
        }
        public bool SaveFta(string path)
        {
            if (CanSave(path))
                return false;

            Console.WriteLine($"SaveFta {path}");

            return true;
        }
    }
}
