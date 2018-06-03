<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AutoPostBackCombo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          CONTACTOS:  <asp:DropDownList ID="cmbContactos" runat="server" AutoPostBack="true" Width="265px"></asp:DropDownList>
        </div>
        <br />
        <div>
            EQUIPOS: <asp:DropDownList ID="cmbEquipos" runat="server" style="margin-left: 27px" Width="270px"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
<%--AutoPostBack="true" , es muy importante porque hace que cargue el primer combo, y cuando
    carga, hace que cargue el segundo com6bo--%>