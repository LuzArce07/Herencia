using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Pez : Animal //Esto hace la herencia
    {
        
        override public string desplazar()
        {
            return Nombre + " está nadando";
        }

    }

}
