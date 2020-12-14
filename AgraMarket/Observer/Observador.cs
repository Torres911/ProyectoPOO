using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /*
    class Observador : IObserver{

        private string nombre;
        private Sujeto sujeto;

        public Observador(string pNombre, Sujeto pSujeto){
            
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribir(this);
        }

        // es el metodo para el modelo de push
        public void Update(string mensaje){
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0}-{1}", nombre, mensaje);
        }

        //para el caso del pull
        public void UpdatePull(){ // el sujeto nos dice con UpdatePull que hubo un cambio de estado
                                    //luego se decide o no si se lleva acabo la lectura de ese estado dependiendo de lo que se necesite se aplica la logica
            int n = sujeto.N; //obtenemos al sujeto
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pull, {0}-{1}", nombre, n);
        }
    }
    */
}