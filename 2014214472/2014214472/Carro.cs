using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public abstract class Carro
    {

        private Volante Volante;
        private Parabrisas Parabrisas;
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        
        public int _Llanta { get; set; }
        public int _Asiento { get; set; }

        private Bus _Bus;



        public Carro()
        {

        }

        public Carro(string numseriemotor, string numseriechasis,string volante,
            Parabrisas parabrisas, int llanta, int asiento, Bus bus)
        {
            NumSerieMotor = numseriemotor;
            NumSerieChasis = numseriechasis;
            Volante = new Volante(volante);
            Parabrisas = parabrisas;
            _Llanta = llanta;
            _Asiento = asiento;
            _Bus = bus;
    }

        public virtual void Numero_Llantas(TipoCarro tipocarro)
        {
        }


    }
}
