using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model.Interface
{
    public interface INode
    {
        /// <summary>
        /// 식별 ID
        /// </summary>
        /// <returns></returns>
        public string GetId();
        /// <summary>
        /// 자신을 실행
        /// </summary>
        public void Execute();
        /// <summary>
        /// parameter ID와 동일한 경우 실행
        /// </summary>
        /// <param name="id"></param>
        public void Execute(string id);
    }
}
