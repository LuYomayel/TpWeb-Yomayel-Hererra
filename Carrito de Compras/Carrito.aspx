<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito_de_Compras.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contenedor sombra background" >
   <table class="table">
      
    <tr class="subtitulo">
        <td >Nombre </td>
    
        <td>Precio </td>
         
        <td>Cantidad </td>
       
    </tr>   
        
    <asp:Repeater runat="server" ID="repetidor">

            <ItemTemplate>
             
                <tr>
                    
                    <td><%#Eval("Producto.Nombre")%></td>
                   
                    <td>
                        <asp:Label ID="lblSubtotal" runat="server" Text='<%#Eval("Subtotal")%>' />
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged" text='<%#Eval("Cantidad")%>'/>
                    </td>
                    <td>
                        <asp:Button Text="Eliminar" CssClass="boton__eliminar" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Producto.Id")%>' runat="server" />
                     
                    </td> 
                
                </tr>
                
                
            </ItemTemplate>
        </asp:Repeater>
    </table>
 </div>
</asp:Content>

