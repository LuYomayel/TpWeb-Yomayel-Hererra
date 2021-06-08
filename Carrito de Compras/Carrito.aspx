<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito_de_Compras.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contenedor sombra" >
        <div class="table">
            <h1 class="titulo">Nombre</h1>
            <h1 class="titulo">Descripcion</h1>
            <h1 class="titulo">Precio</h1>
            <h1 class="titulo">Cantidad</h1>
        </div>
     
        
    <asp:Repeater runat="server" ID="repetidor">

            <ItemTemplate>
                <div class="table">
                    <p><%#Eval("Producto.Nombre")%></p>
                    <p><%#Eval("Producto.Descripcion")%></p>
                    <p><asp:Label ID="Label1" runat="server" Text='<%#Eval("Subtotal")%>' /></p>
                    <p><asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged"  text='<%#Eval("Cantidad")%>'/></p>
                    <p><asp:Button Text="Eliminar" CssClass="boton__eliminar" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Producto.Id")%>' runat="server" /></p>
                </div>
                <tr>
                    
                    <td></td>
                   
                    <td>
                        
                    </td>
                    <td>
                        
                    </td>
                    <td>
                        
                     
                    </td> 
                
                </tr>
                
                
            </ItemTemplate>
        </asp:Repeater>
    
 </div>
</asp:Content>

