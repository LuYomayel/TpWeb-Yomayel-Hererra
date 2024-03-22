<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Carrito_de_Compras.Detalle" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="contenedor sombra">
     
        <div class="columnas ">
            
                <div class="img">
                    <img src="srcImg" class="card-img-top" ID="imgseleccionado" runat="server" />
                </div>
                <div class="columna2 centrado">
                    <p class="nombre-producto"> <asp:Label Text="lala" ID="lblNombre" runat="server" /></p>
                    <div class="columnas">
                            <p>Marca: <asp:Label Text="lala" ID="lblMarca" runat="server" /></p>
                            <p>Categoria: <asp:Label Text="lala" ID="lblCategoria" runat="server" /></p>
                            <p class="grid-column1">Precio: $<asp:Label Text="lala" ID="lblPrecio" runat="server" /></p>
                            <p class="grid-column1">Descripcion: <asp:Label Text="lala" ID="lblDescripcion" runat="server" /></p>
                            <a href="Carrito.aspx?id=<%  = hola %>" class="boton-ancho">Agregar al carrito</a>
                    </div>
                    
                    
                </div>
            
        </div>
    </div>
</asp:Content>