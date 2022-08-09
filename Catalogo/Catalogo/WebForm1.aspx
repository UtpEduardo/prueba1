<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Catalogo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/Style1.css" rel="stylesheet" />
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Agrege el Nuevo producto</h1>
            </center>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Marca: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Categoria: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar al final" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" style="margin-bottom: 0px" Text="Agregar al inicio" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar (hacia el final)" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Mostrar (hacia el inicio)" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server"></asp:Label>
        &nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="119px" Width="720px"></asp:ListBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Seleccione el catalago que desee ver las imagenes"></asp:Label>
&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Seleccionar" />
&nbsp;&nbsp;<asp:Label ID="Label12" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server"></asp:Label>
        <br />
        <br />

        <br />
        <br />
        <h3>Agrege una imagen (maximo le permite hasta 4)</h3>
        <br />
        <asp:Label ID="Label13" runat="server" Text="Escriba la marca"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" Width="181px"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label14" runat="server" Text="y categoria "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label15" runat="server" Text="Seleecione la imagen"></asp:Label>
&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Agergar" />
        <br />
        <asp:Label ID="Label16" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label6" runat="server" Text="Escriba la marca y categoria para buscar o para eliminar"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Marca =&gt;"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="167px"></asp:TextBox>
&nbsp;<asp:Label ID="Label9" runat="server" Text="Modelo=&gt; "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Width="195px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Buscar" OnClick="Button3_Click" />
        &nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Eliminar" />
        <br />
        <br />
        <center>
        <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Mostra grafica" />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" />
        </center>
    </form>
</body>
</html>
