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
            var numchasis2 = "123124312";
            var numchasis3 = "133232232";
            var numchasis4 = "123122222";
            var numchasis5 = "546545645";
            var numchasis6 = "568790897";

            
            var ensambladora = new Ensambladora();

            //central.Agregar(carro);
            //central.Agregar(carro);


            ensambladora.IniciarPersonalizacion(numchasis1);
            ensambladora.FinalizarPersonalizacion(numchasis1);

            ensambladora.IniciarPersonalizacion(numchasis2);
            ensambladora.FinalizarPersonalizacion(numchasis2);

            ensambladora.IniciarPersonalizacion(numchasis3);
            ensambladora.FinalizarPersonalizacion(numchasis3);

            ensambladora.IniciarPersonalizacion(numchasis4);
            ensambladora.FinalizarPersonalizacion(numchasis4);

            ensambladora.IniciarPersonalizacion(numchasis5);
            ensambladora.FinalizarPersonalizacion(numchasis5);

            ensambladora.IniciarPersonalizacion(numchasis6);
            ensambladora.FinalizarPersonalizacion(numchasis6);

            Console.ReadKey();

        }

    }
}
