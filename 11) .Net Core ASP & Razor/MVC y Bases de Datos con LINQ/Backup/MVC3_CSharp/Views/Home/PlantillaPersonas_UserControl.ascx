<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
 
     <% foreach (MVC3_CSharp.Models.Personas per in (IEnumerable)ViewData.Model) {  %>
            <tr>
                <td> <%= per.Cedula    %> </td>
                <td> <%= per.Nombre    %> </td>
                <td> <%= per.Telefono  %> </td>
                <td> <%= per.Direccion %> </td>
                <td> <%= per.Correo    %> </td>
            </tr>
        <% } %>
