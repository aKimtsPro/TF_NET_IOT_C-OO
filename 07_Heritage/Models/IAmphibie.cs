using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal interface IAmphibie : IRouler, INaviguer
    {
        string Mode { get; } // TERRESTRE, AQUATIQUE
        void SwitchMode();
    }
}
