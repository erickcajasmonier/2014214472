using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    class Program
    {
        static void Main(string[] args)
        {
            var numchasis1 = "124124125";
            var numchasis2 = "1231243";
            var numchasis3 = "64767854";
            var numchasis4 = "3426487";
            var numchasis5 = "1265473";
            var numchasis6 = "568790897";


            var central = new Ensambladora();

            //central.Agregar( carro);
            //central.Agregar(carro);


            central.IniciarPersonalizacion(numchasis1);
            central.FinalizarPersonalizacion(numchasis1);

            central.IniciarPersonalizacion(numchasis2);
            central.FinalizarPersonalizacion(numchasis2);

            central.IniciarPersonalizacion(numchasis3);
            central.FinalizarPersonalizacion(numchasis3);

            central.IniciarPersonalizacion(numchasis4);
            central.FinalizarPersonalizacion(numchasis4);

            central.IniciarPersonalizacion(numchasis5);
            central.FinalizarPersonalizacion(numchasis5);

            central.IniciarPersonalizacion(numchasis6);
            central.FinalizarPersonalizacion(numchasis6);

        }

    }
}
