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
        public void IniciarPersonalizacion()
        {
           // Carro _numChasis= _numChasis
        }
        public void FinalizarPersonalizacion()
        {

        }
        public void EnsamblarCarro()
        {

        }
    }
}
