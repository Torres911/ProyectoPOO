using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Sujeto{

        private List<IObserver> observadores = new List<IObserver>(); // aqui se guardaran las personas a quienes se le enviara la informacion
        private string mensaje;
        private Random rnd = new Random();
        private int n;

        public int N{get => n; set => n = value;}

        public void Suscribir(IObserver suscrito){ //añade un objeto en la lista y para poder resivir las notificaciones

            observadores.Add(suscrito);
        }
        
        public void Desuscribir(IObserver suscrito){ //elimina un objeto de la lista en caso de que sea necesario

            //si se implementa es mejor implementar un codigo de seguridad
            observadores.Remove(suscrito);
        }

        private void Notificar(){ // sirve para indicar a todos los de la lista que ha habido un cambio
            
            foreach(IObserver o in observadores){ //aqui literal informa a todos los objetos de la lista
                o.Update(mensaje);
                //o.UpdatePull();
            }
        }

        public void Trabajo(){ // simula el trabajo que esta haciendo el patron y que haga una notificacion si hay un cambio estado que interese

            n = rnd.Next(10);

            if(n%2 == 0){

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Nuevo estado valido ---");
                mensaje = string.Format("El nuevo valor es {0}", n);
                Notificar();
            }
        }
    }
}