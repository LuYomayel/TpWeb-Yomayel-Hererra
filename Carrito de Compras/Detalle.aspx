<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Carrito_de_Compras.Detalle" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="contenedor">
     
    <div class="grid">

    <div class="card" style="width: 18rem;">
        <div class="card-header">
            <div class="producto__informacion">

              
                    <form Style="align-content:center";class="formulario">
                         <p Style="color:blue"> <asp:Label Text="Articulo Seleccionado"   runat="server" /></p>
                         <img src="dfdf" class="card-img-top" ID="imgseleccionado" runat="server" />
                         <p> <asp:Label Text="lala" ID="lblseleccionado" runat="server" /></p>
                         <p> <asp:Label Text="lala" ID="lblseleccionado1" runat="server" /></p>
                         <p> <asp:Label Text="lala" ID="lblseleccionado2" runat="server" /></p>
                         <p> <asp:Label Text="lala" ID="lblseleccionado3" runat="server" /></p>
                         <p> <asp:Label Text="lala" ID="lblseleccionado4" runat="server" /></p>
                         <p> <asp:Label Text="lala" ID="lblseleccionado5" runat="server" /></p>
    
                    </form>
                

            </div>

        </div>

     </div>
         </div>
    </div>
</asp:Content>