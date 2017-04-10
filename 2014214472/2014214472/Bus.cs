using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    public class Bus:Carro
    {
        public TipoBus TipoBus { get; set; }
        public Bus():base()
        {
            TipoBus = TipoBus.NoDefinido;
        }

        public Bus(TipoCarro tipoCarro, TipoBus tipoBus):base(){

            TipoBus = tipoBus;
        }
    


    }
}
