using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Reptil : Animal //Esto hace la herencia
    {
        public string cambiarPiel()
        {
            return Nombre + " cambió de piel";
        }

        override public string desplazar()
        {
            return Nombre + " está caminando";
        } 

    }

}
