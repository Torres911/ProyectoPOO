using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton{

        private static Singleton instance = null;
        public string mensaje = "";

        protected Singleton(){ //contructor

            mensaje = "Hola mundo";
        } 

        public static Singleton Instance{

            get{
                if (instance == null){
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}


// aqui voy a hacer como deberia de usar se en el program #GRACIAS,CRACK
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton{
    class Program{

        static void Main(string[] args){

            Console.WriteLine(Singleton.Instance.mensaje);

            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
*/