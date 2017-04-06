using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public class Cinturon
    {
        public string NumSerie { get; set; }
        public int Metraje { get; set; }

        public Cinturon()
        {

        }

        public Cinturon(string numserie, int metraje)
        {
            NumSerie = numserie;
            Metraje = metraje;
        }

    }
}
