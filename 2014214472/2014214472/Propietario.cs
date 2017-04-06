using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public class Propietario
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaConducir { get; set; }

        public Propietario()
        {

        }

        public Propietario(string dni, string nombre, string apellido, string licenciaconducir)
        {
            DNI = dni;
            Nombre = nombre;
            Apellidos = apellido;
            LicenciaConducir = licenciaconducir;
        }

    }
}
