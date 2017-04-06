using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    class Ensambladora
    {
        List<Carro> _Carro;

        public Ensambladora()
        {
            _Carro = new List<Carro>();
        }



        public void Agregar(Carro carro)
        {
            _Carro.Add(carro);
        }
        public void Eliminar(Carro carro)
        {
            _Carro.Remove(carro);
        }
        public void IniciarPersonalizacion(string num )
        {
            Carro _numChasis = _Carro.Find(t => t.NumSerieChasis == num);

            Console.WriteLine("Personalizacion iniciada: {0}", num);

        }
        public void FinalizarPersonalizacion(string num)
        {
            Carro _numChasis = _Carro.Find(t => t.NumSerieChasis == num);

            Console.WriteLine("Personalizacion finalizada: {0}", num);
        }
        public void EnsamblarCarro(TipoCarro tipocarro, TipoAuto tipoauto, TipoBus tipobus)
        {
           // if (tipoauto = TipoAuto.Coupe)
           // {
                
           // }
        }

    }
}
