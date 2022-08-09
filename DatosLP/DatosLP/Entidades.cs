using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLP
{
    public class Entidades
    {
        public string marca { set; get; }
        public string cartegoria { set; get; }
        public Stack<string> img { set; get; }

        public string MostrarDatos()
        {
            return "Marca: " + this.marca +
                " //Categoria: " + this.cartegoria;
        }

        public string MostrarConIMG()
        {
            return this.img.ToString();
        }

        public string Mostrar2()
        {
            return this.marca + "\n" + this.cartegoria;
        }
    }
}
