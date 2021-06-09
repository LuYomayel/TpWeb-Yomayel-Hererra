<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Carrito_de_Compras.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="contenedor">
         <h1>Nuestros Productos</h1>
     <asp:Label ID="Label1" runat="server" Text="Busque por el nombre: "></asp:Label>
        <asp:TextBox ID="TxtFiltro" runat="server"></asp:TextBox>
        <asp:Button ID="BtnBuscar" runat="server" Onclick="BtnBuscar_Click" Text="Buscar" />
    <div class="grid">
        
       <% foreach (Dominio.Producto item in lista)
            {   %>
        <div class="producto">
            <img src="<% = item.UrlImagen %>" class="producto__imagen" alt="..." />
            <div class="producto__informacion">
                <p class="producto__nombre"><% = item.Nombre %> </p>
                <p class="producto__precio">$<% = item.Precio %> </p>
                <div class="columnas">
                    <a href="Carrito.aspx?id=<% = item.Id %>" class="boton">Agregar al carrito</a>
                    <a href="Detalle.aspx?id=<% = item.Id %>" class="boton">Ver detalle</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>
        </div>
</asp:Content>

