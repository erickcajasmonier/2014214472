using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472
{
    class Ensambladora
    {
        Random r = new Random();
        List<Carro> _Carro;
        
      
        public Ensambladora(){
            _Carro = new List<Carro>();
           
        }
        
        public void Agregar(Carro carro){
            _Carro.Add(carro);
        }
        public void Eliminar(Carro carro){
            _Carro.Remove(carro);
        }

 
        public void IniciarPersonalizacion(string num ){
        
            if(num[0]=='1'){
               
                Asiento serie_asiento = new Asiento("5");

                Carro _numChasis = _Carro.Find(t => t.NumSerieChasis == num);
                Console.WriteLine("Personalizacion iniciada:"+"\n Numero de Chasis: {0}"+"\n El tipo de Carro es: {1} "+"\n"+" El numero de asientos es: {2}"+"\n", num, TipoCarro.Automovil,serie_asiento.NumSerie);
            }
            else{
                Asiento serie_asiento = new Asiento("10");
                Carro _numChasis = _Carro.Find(t => t.NumSerieChasis == num);
                Console.WriteLine("Personalizacion iniciada:" + "\n Numero de Chasis: {0}" + "\n El tipo de Carro es: {1} " + "\n" + " El numero de asientos es: {2}"+"\n ", num, TipoCarro.Bus, serie_asiento.NumSerie);
            }
        }
        public void FinalizarPersonalizacion(string num){

            int tauto = generartipoAuto();
            int tbus = generartipoBus();

            if (num[0] == '1')
            {
                Asiento serie_asiento = new Asiento("5");
                Carro _numChasis = _Carro.Find(t => t.NumSerieChasis == num);
                Console.WriteLine("Personalizacion Finalizada:" + "\n Numero de Chasis: {0}" + "\n El tipo de Carro es: {1} " + "\n" + " El numero de asientos es: {2}"+"\n"+ "El tipo de auto es: {3}"+"\n", num, TipoCarro.Automovil, serie_asiento.NumSerie,(TipoAuto)tauto);
            }
            else
            {
                Asiento serie_asiento = new Asiento("10");
                Carro _numChasis = _Carro.Find(t => t.NumSerieChasis == num);
                Console.WriteLine("Personalizacion Finalizada:" + "\n Numero de Chasis: {0}" + "\n El tipo de Carro es: {1} " + "\n" + " El numero de asientos es: {2}" + "\n"+ "El tipo de bus es: {3}" + "\n", num, TipoCarro.Bus, serie_asiento.NumSerie,(TipoBus)tbus);
            }
        }
        public void EnsamblarCarro(TipoCarro tipocarro, TipoAuto tipoauto, TipoBus tipobus){
  
        }

        public int generartipoAuto()
        {
            return r.Next(0, 5);
        }

        public int generartipoBus()
        {
            return r.Next(0, 3);
        }

    }
}
