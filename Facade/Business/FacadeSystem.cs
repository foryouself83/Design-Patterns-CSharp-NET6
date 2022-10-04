using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Business
{
    internal class FacadeSystem
    {
        private StpaSystem? _stpa;
        private FtaSystem? _fta;

        public void CreateStpaSystem()
        {
            Console.WriteLine($"CreateStpaSystem");
            _stpa = new StpaSystem();
        }
        public void CreateFtaSystem()
        {
            Console.WriteLine($"CreateFtaSystem");
            _fta = new FtaSystem();
        }

        public bool Save(string path)
        {
            if (_stpa != null)
                return _stpa.SaveStpa(path);
            else if (_fta != null)
                return _fta.SaveFta(path);

            return false;
        }
    }
}
