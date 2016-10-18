<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitarEvento.aspx.cs" Inherits="Presentacion.SolicitarEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body style="height: 33px">
    <form id="form1" runat="server">
        <p>
            Nombre:<asp:TextBox ID="Nombre" runat="server" AutoCompleteType="BusinessPhone"  style="margin-left: 46px"></asp:TextBox>
        </p>
        <p>
            Descripcion :
        </p>
        <p>
            <asp:TextBox ID="Descripcion" runat="server" AutoCompleteType="Enabled" Height="89px" style="margin-left: 0px" Width="244px" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="ddlidevento" runat="server" style="margin-left: 0px" Visible="False">
            </asp:DropDownList>
        </p>
        <p>
            Tipo Evento :
            <asp:DropDownList ID="ddlTipoEvento" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            Lugar :
            <asp:DropDownList ID="ddlLugar" runat="server">
            </asp:DropDownList>
        </p>
        <a>
            Fecha Inicio :&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="FechaInicio" runat="server" style="margin-left: 0px" TextMode="Date"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
        </a>
        <a>
              Fecha Fin :
            <asp:TextBox ID="FechaFin" runat="server" TextMode="Date" style="margin-left: 0px"></asp:TextBox>
        </a>
        <br />
        <br />
        <a>
            Hora Inicio : <asp:TextBox ID="HoraInicio" runat="server" style="margin-left: 7px" TextMode="Time"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Hora Fin :
            <asp:TextBox ID="HoraFin" runat="server" style="margin-left: 7px" TextMode="Time"></asp:TextBox>
        </a>
        <p>
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 173px; height: 29px;" Text="Enviar" />
        </p>
    </form>
</body>
</html>
