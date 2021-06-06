<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Carrito_de_Compras.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="contenedor">
         <h1>Nuestros Productos</h1>
     
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

