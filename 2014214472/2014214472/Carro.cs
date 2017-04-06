using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public abstract class Carro
    {
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        private Volante _Volante;
        private Parabrisas _Parabrisas;
        private Llanta _Llanta;
        private Asiento _Asiento;
        private Bus _Bus;

        public Carro()
        {

        }

        public Carro(string numseriemotor, string numseriechasis,Volante volan,
            Parabrisas parabri, Llanta llant, Asiento asien, Bus bu)
        {
            NumSerieMotor = numseriemotor;
            NumSerieChasis = numseriechasis;
            _Volante = volan;
            _Parabrisas = parabri;
            _Llanta = llant;
            _Asiento = asien;
            _Bus = bu;
        }


    }
}
