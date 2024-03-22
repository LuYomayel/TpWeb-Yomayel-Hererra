 <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito_de_Compras.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="contenedor sombra" >
        <div class="table">
            <h1 class="titulo">Nombre</h1>
            <h1 class="titulo">precio</h1>         
            <h1 class="titulo">Cantidad</h1>
        </div>
        
    <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="table">
                    <p><%#Eval("Producto.Nombre")%></p>
                    <p><%#Eval("Producto.precio")%></p>
                        <asp:TextBox TextMode="Number" runat="server" OnTextChanged="txtCantidad_TextChanged" text='<%#Eval("Cantidad")%>' ID="txtCantidad" min="1"/>
                        <asp:Button Text="Agregar" CssClass="boton__eliminar" AutoPostBack="true" ID="btnAgregar" OnClick="btnAgregar_Click" CommandArgument='<%#Eval("Producto.Id")%>' runat="server" />
                    </p>
                    <p><asp:Button Text="Eliminar" CssClass="boton__eliminar" AutoPostBack="true" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Producto.Id")%>' runat="server" /></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
   
    <p class="derecha">Total: <asp:Label ID="lblTotal" runat="server" OnLoad="lblTotal_Load" /></p>
 
 </div>
</asp:Content>

