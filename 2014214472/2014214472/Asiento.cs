using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public class Asiento
    {
        public string NumSerie { get; set; }
        private Cinturon _Cinturon;

        public Asiento()
        {

        }
        public Asiento(string numserie, Cinturon cintu)
        {
            NumSerie = numserie;
            _Cinturon = cintu;
        }

    }
}
