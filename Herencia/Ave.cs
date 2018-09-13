using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Ave : Animal //Esto hace la herencia
    {
        public string ponerHuevo()
        {
            return Nombre + " puso un huevo";
        }

        override public string desplazar()
        {
            return Nombre + " está volando";
        }

    }

}
