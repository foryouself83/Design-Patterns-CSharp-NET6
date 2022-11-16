using AbstactFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory.Model.Factory
{
    /// <summary>
    /// 추상화 클래스를 생성하는 추상화 클래스
    /// </summary>
    internal abstract class AbstractFactoryNode
    {
        /// <summary>
        /// 추상화 클래스를 생성
        /// </summary>
        /// <returns></returns>
        public abstract CutSetCalModel CreateCutSetCalAlgorithm();

        /// <summary>
        /// 추상화 클래스를 생성
        /// </summary>
        /// <returns></returns>
        public abstract LogicalExpressionModel CreateLogicalExpressionAlgorithm();
    }
}
