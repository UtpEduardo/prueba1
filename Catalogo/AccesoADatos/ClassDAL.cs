using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatosLP;

namespace AccesoADatos
{
    public class ClassDAL
    {
        NodoDoble ancla = null;
        private int cuentanodo = 0;
        Stack<string> img = new Stack<string>();

        public string AgregarAlFinal(NodoDoble nuevo)
        {
            string msj = "";
            NodoDoble fin = null;

            if (ancla == null)
            {
                ancla = nuevo;
                msj = "Se agrego correctamente el ancla";
            }
            else
            {
                fin= ancla;
                while(fin.siguiente != null)
                {
                    fin = fin.siguiente;                    
                }
                fin.siguiente = nuevo;
                //nuevo.siguiente=fin;            
                msj = "Se agrego correctamente el SALTO";
            }
            cuentanodo++;
            return msj;
        }

        public string AgregarAlInicio(NodoDoble nuevoI)
        {
            string msj = "";
            NodoDoble inicio = null;

            if (ancla!=null)
            {
                inicio = ancla;
                while (inicio.anterior != null)
                {
                    inicio = inicio.anterior;
                }
                inicio.anterior = nuevoI;
                msj = "se agrego al inicio";
            }
            else
            {
                msj = "No se agrego nada";
            }
            cuentanodo++;
            return msj;
        }

        //public string MostrarAsendente()
        //{
        //    string resultado = "";
        //    NodoDoble t = null;
        //    t = ancla;

        //    while (t != null)
        //    {
        //        resultado = t.info.MostrarDatos();
        //        cuentanodo++;
        //        t = t.siguiente;
        //    }

        //    return resultado;
        //}

        public string[] MostrarAsendente()
        {
            string[] resultado = new string[cuentanodo];
            NodoDoble t = null;
            int x = 0;
            t = ancla;

            while (t != null)
            {
                resultado[x] = t.info.MostrarDatos();
                x++;
                t = t.siguiente;
            }

            return resultado;
        }

        public string[] MostrarDesendente()
        {
            string[] resultado = new string[cuentanodo];
            NodoDoble t = null;
            int x = 0;
            t = ancla;

            while (t != null)
            {
                resultado[x] = t.info.MostrarDatos();
                x++;
                t = t.anterior;
            }

            return resultado;
        }

        public NodoDoble BucarProducto(string matk, string cate)
        {
            NodoDoble r1 = null;
            NodoDoble piedrita = null;
            r1 = ancla;
            while(r1 != null)
            {
                if(r1.info.marca==matk && r1.info.cartegoria == cate)
                {
                    piedrita = r1;
                }
                r1 = r1.siguiente;
            }
            return piedrita;

        }
        public NodoDoble AnterioBuscarE(string mark, string mod)
        {
            NodoDoble r1 = null;
            NodoDoble piedra = null;
           // NodoDoble anteEncontrado = null;

            r1 = ancla;
            r1.anterior = r1;

            while (r1 != null)
            {
                if(r1.info.marca==mark && r1.info.cartegoria == mod)
                {
                    piedra = r1;
                }
                r1.anterior = r1;
                r1 = r1.siguiente;
            }
            return piedra;
        }

        public string EliminarDato(string mar,string model)
        {
            NodoDoble encontrado = null;
            NodoDoble anteriorE = null;

            string sal = "";
            encontrado = BucarProducto(mar,model);

            if (encontrado != null)
            {
                if (encontrado == ancla)
                {
                    ancla = encontrado.siguiente;
                    encontrado.siguiente = null;
                }
                else
                {
                    anteriorE = AnterioBuscarE(mar, model);
                    anteriorE.siguiente = encontrado.siguiente;
                    encontrado.siguiente = null;
                    encontrado = null;
                    sal = "Elimado correctamente";
                }
                cuentanodo--;
            }
            else
            {
                sal = "No se encontro nada y no se elimino nada";
            }
            return sal;
        }

        public string AgregarImg(string mark, string cate, Stack<string> img)
        {
            string msj = "";

            NodoDoble actual = null;
            NodoDoble aModificar = null;

            actual = ancla;
            aModificar=BucarProducto(mark,cate);

            while(actual != null)
            {
                if (aModificar.info.img == null)
                {
                    actual.info.img = img;
                    msj = "Se coloco la imagen";
                }
                else
                {
                    msj = "Se agregaron las demas imagenes";
                }
                actual = actual.anterior;
            }

            return msj;
        }

        public string[] MostrarIMG(int elemeto)
        {
            string salida = "";
            string[] posicion = new string[cuentanodo];
            NodoDoble t = null;
            int x =0;
            x = elemeto;
            t = ancla;

            if (t.info.img == null)
            {
                posicion[x] = "No contiene ninguna imagen";
            }
            else
            {
                if (t.info.img==null)
                {
                    posicion[x] = "No contiene ninguna imagen";
                }
                else
                {
                    foreach(string img in t.info.img)
                    {
                        posicion[x] = "<img src='" + t.info.img + "' width='100px'>";
                    }                        
                }
                
            }

            return posicion;
        }

        public Entidades[] MostraGDI()
        {
            Entidades[] div = new Entidades[cuentanodo];
            NodoDoble r1 = null;
            int c = 0;
            r1 = ancla;

            while (r1 != null)
            {
                div[c] = r1.info;
                c++;
                r1 = r1.siguiente;
            }
            return div;
        }
    }
}
