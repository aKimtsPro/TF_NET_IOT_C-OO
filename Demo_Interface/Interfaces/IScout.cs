using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interfaces
{
    public interface IScout : ILouveteau
    {
        void FaireUnFeu();
        void PreparerLeRepas();
    }
}
