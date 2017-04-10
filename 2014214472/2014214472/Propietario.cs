using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public class Propietario
    {
        private string DNI { get; set; }
        private string Nombre { get; set; }
        private string Apellidos { get; set; }
        private string LicenciaConducir { get; set; }

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
