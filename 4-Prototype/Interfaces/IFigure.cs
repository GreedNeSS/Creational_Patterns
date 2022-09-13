using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Prototype.Interfaces
{
    public interface IFigure
    {
        IFigure Clone();
        IFigure DeepClone();
        void GetInfo();
    }
}
