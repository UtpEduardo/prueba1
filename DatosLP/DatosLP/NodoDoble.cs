using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLP
{
    public class NodoDoble
    {
        public Entidades info = new Entidades();
        public NodoDoble siguiente = null;
        public NodoDoble anterior = null;


        public NodoDoble(Entidades objnw)
        {
            info = objnw;
            siguiente = null;
            anterior = null;
        }

        //public NodoDoble(string marca, string categoria, string img)
        //{
        //    info = new Entidades()
        //    {
        //        marca  = marca,
        //        cartegoria = categoria,
        //        img = img
        //    };
        //    siguiente = null; 
        //    anterior= null;
        //}
    }
}
