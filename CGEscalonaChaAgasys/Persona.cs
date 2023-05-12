using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonaChaAgasys
{
     class Persona
    {
        public string nombre = "Gabriela";
        public int edad;
        public bool ComprobarEdad(int valoredad)
        {

            edad = valoredad;
            if (edad > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
