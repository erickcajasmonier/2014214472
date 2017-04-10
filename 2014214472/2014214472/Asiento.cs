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
        private Cinturon Cinturon;
        

        public Asiento()
        {

        }
        public Asiento(string numserie)
        {
            
            NumSerie = numserie;
            Cinturon = new Cinturon(generar_Serie_Cinturon(), generar_Metraje());
        }

        public string generar_Serie_Cinturon()
        {
            Random r = new Random();
            return r.Next(100, 250).ToString();
        }

        public int generar_Metraje()
        {
            Random r = new Random();
            return r.Next(100, 250);
        }

    }
}
