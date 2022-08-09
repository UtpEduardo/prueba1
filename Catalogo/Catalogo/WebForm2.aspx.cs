using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Drawing.Imaging;

namespace Catalogo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap imagen1 = new Bitmap(770, 770);

            Graphics hoja = Graphics.FromImage(imagen1);
            DatosLP.Entidades[] cad = null;

            if (Session["arr"] != null)
            {
                cad = (DatosLP.Entidades[])Session["arr"];
                ListaGrafica(hoja, imagen1.Width, imagen1.Height, cad);
            }

            Response.ContentType = "image/jpeg";
            imagen1.Save(Response.OutputStream, ImageFormat.Jpeg);
            Response.End();
        }

        public void ListaGrafica(Graphics lienzo, int dmx, int dmy, DatosLP.Entidades[] cad)
        {
            lienzo.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, dmx, dmy));

            Pen lap2 = new Pen(Color.DodgerBlue, 3);
            int x1 = 0, y1 = 0;

            x1 = 10;
            y1 = 10;

            int C = 0;
            SolidBrush toma = new SolidBrush(Color.Tomato);
            SolidBrush Gree = new SolidBrush(Color.LimeGreen);

            for (C = 1; C <= cad.Length; C++)
            {
                //Cuadro de informacion
                lienzo.DrawRectangle(lap2, new Rectangle(x1, y1, 200, 60));
                //cuadro del nodo
                lienzo.DrawRectangle(lap2, new Rectangle((x1 + 173), y1, 25, 55));
                //punto de enlace
                lienzo.FillEllipse(toma, new Rectangle((x1 + 180), (y1 + 15), 10, 10));
                //enlaceliga o nodo
                lienzo.DrawLine(lap2, (x1 + 183), (y1 + 20), (x1 + 183), (y1 + 100));
                //Escribir en modo grafico existe drawsting
                lienzo.DrawString("Marca: " + cad[C - 1].marca, new Font("Arial", 12), Gree, x1, y1);
                lienzo.DrawString("Categoria: " + cad[C - 1].cartegoria, new Font("Arial", 12), Gree, x1, (y1+20));
                lienzo.DrawString("R: " + cad[C - 1].img, new Font("Arial", 9), Gree, x1, (y1 + 40));
                y1 = y1 + 80;
            }

            if (C % 5 == 0)
            {
                lienzo.DrawLine(lap2, (x1 + 20), (y1 +  150), (x1 + 50), (y1 + 150));
                //Linea larga
                lienzo.DrawLine(lap2, (x1 + 150), (y1 + 50), 10, (y1 + 50));
                //otro mini horizontal
                lienzo.DrawLine(lap2, 10, (y1 + 65), 10, (y1 + 50));
                x1 = 30;
                y1 = y1 + 10 ;

            }
            else
            {
                y1 = y1 + 160;
            }
        }
    }
}