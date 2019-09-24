<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="MVC3_CSharp" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Página principal
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista de Personas</h2>

    <table>
        <tr>
            <th>Cedula</th> <th>Nombre</th> <th>Telefono</th> <th>Direccion</th> <th>email</th>
        </tr>

        <%Html.RenderPartial("PlantillaPersonas_UserControl"); %>

    </table>

</asp:Content>
