using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions.Exceptions
{
    public class PasEncoreEnPlace : Exception
    {
        public PasEncoreEnPlace(string message) : base(message)
        {
            
        }
    }
}
