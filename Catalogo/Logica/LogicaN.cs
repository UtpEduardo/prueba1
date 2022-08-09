using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatosLP;
using AccesoADatos;

namespace Logica
{
    public class LogicaN
    {
        private ClassDAL obj = new ClassDAL();

        public string AgregarFinal(NodoDoble nuevo)
        {
            return obj.AgregarAlFinal(nuevo);
        }

        public string AgregarInicio(NodoDoble nuevo)
        {
            return obj.AgregarAlInicio(nuevo);
        }

        public string[] MostrarAsendentemente()
        {
            return obj.MostrarAsendente();
        }

        public string[] MostrarDesendente()
        {
            return obj.MostrarDesendente();
        }

        public string Buscar(string mark, string cate)
        {
            string resBusqueda = "";
            NodoDoble piedrita = null;
            piedrita = obj.BucarProducto(mark, cate);

            if (piedrita == null)
            {
                resBusqueda = "No se encontro nada";

            }
            else
            {
                resBusqueda = "Resutado de busqueda: \n" + piedrita.info.MostrarDatos();
            }

            return resBusqueda;
        }

        public string Eliminar(string marje, string model)
        {
            return obj.EliminarDato(marje, model);
        }

        public string ColocarIMG(string mark, string cata, Stack<string> img)
        {
            return obj.AgregarImg(mark,cata,img);
        }

        public string[] MostraImg(int elemento)
        {
            return obj.MostrarIMG(elemento);
        }

        public Entidades[] MostrarDibujo()
        {
            return obj.MostraGDI();
        }
    }
}
