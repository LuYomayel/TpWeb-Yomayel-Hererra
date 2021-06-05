<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito_de_Compras.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table class="table">
        <tr>
            <td>Nombre</td>
            <td>Acción</td>
            <td>Cantidad</td>
        </tr>
    <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Nombre")%></td>
                    <td>
                        
                        <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Id")%>' runat="server" />
                    </td>
                    <td>
                        <%--<asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged" />--%>
                    </td>
                    
                </tr>

            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>

