using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DatosLP;
using Logica;

namespace Catalogo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        LogicaN LN = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LN= new LogicaN();
            if (Session["LN"] != null)
            {
                LN = (LogicaN)Session["LN"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            Label4.Text = LN.AgregarFinal(new NodoDoble(new Entidades()
            {
                marca = TextBox1.Text,
                cartegoria = TextBox2.Text                
            }));

            TextBox1.Text = "";
            TextBox2.Text = "";

            Session["LN"] = LN;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] a = null;
            a = LN.MostrarAsendentemente();
            ListBox1.Items.Clear();
            foreach(string z in a)
            {
                ListBox1.Items.Add(z);
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label10.Text = LN.Buscar(TextBox3.Text,TextBox4.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label10.Text = LN.Eliminar(TextBox3.Text, TextBox4.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string[] cartegoria = null;
            string msj = "";
            if (ListBox1.SelectedItem != null)
            {
                int idice = ListBox1.SelectedIndex;                
                cartegoria = LN.MostraImg(idice);
                Label17.Text = cartegoria[idice];
                
            }
            else
            {
                msj = "no se selecciono nada";
                Label17.Text = msj;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {            
            Stack<string> RutaD4img=new Stack<string>(4);
            int tamaño = FileUpload1.PostedFile.ContentLength;
            
            if (FileUpload1.HasFiles)
            {
                string nomfile = FileUpload1.FileName;
                string Ruta = "Imagenes/" + nomfile;
                
                
                if(tamaño> 5242880)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(),"Arlet1","arlet('File is too gig')",true);
                    Label16.Text = "El tamaño del archivo es demasiado grande";
                }
                else
                {
                    if (FileUpload1.PostedFiles.Count <= 4)
                    {
                        RutaD4img.Push(Ruta);
                        FileUpload1.SaveAs(Server.MapPath(Ruta));
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Arlet1", "arlet('Save')", true);
                        Label16.Text = LN.ColocarIMG(TextBox5.Text,TextBox6.Text, RutaD4img);                        
                    }
                    else
                    {
                        Label16.Text = "Maximo se pueden almacenar 4 imagenes";
                    }
                }
            }
            else
            {
                Label16.Text = "No hay ningun Archivo";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label4.Text = LN.AgregarInicio(new NodoDoble(new Entidades()
            {
                marca = TextBox1.Text,
                cartegoria = TextBox2.Text
            }));

            TextBox1.Text = "";
            TextBox2.Text = "";

            Session["LN"] = LN;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string[] a = null;
            a = LN.MostrarDesendente();
            ListBox1.Items.Clear();
            foreach (string z in a)
            {
                ListBox1.Items.Add(z);
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            DatosLP.Entidades[] arr = null;
            arr = LN.MostrarDibujo();
            Session["arr"]=arr;
            Image1.ImageUrl = "WebForm2.aspx";
        }
    }
}