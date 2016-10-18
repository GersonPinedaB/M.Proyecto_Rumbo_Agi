<%@ Page Title="" Language="C#" MasterPageFile="~/RA_Sistema.Master" AutoEventWireup="true" CodeBehind="W_Solicitar_Evento.aspx.cs" Inherits="Presentacion.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="float:left">
        <div id='calendar'></div>                    
    </div>
    <div class="row" style="float:right; width:500px">
        <div class="panel panel-success">
            <div class="panel-heading">
                Solicitar Evento
            </div>
            <div class="panel-body">
                <form id="formSolicitar" runat="server">
                    <div class="form-group">
                        <label>Nombre:</label>
                        <asp:TextBox CssClass="form-control" id="txtNombre" runat="server" />                        
                    </div>
                    <div class="form-group">
                        <label>Descripción:</label>
                        <asp:TextBox CssClass="form-control" ID="txtDescripcion" Rows="2" TextMode="MultiLine" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Tipo de Evento:</label>
                        <asp:DropDownList ID="ddTipoEvento" CssClass="form-control" runat="server" >
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Lugar:</label>
                        <asp:DropDownList ID="ddLugar" CssClass="form-control" runat="server" >
                        </asp:DropDownList>
                    </div>
                    <div>
                        <div class="form-group">
                            <label>Fecha de Inicio:</label>
                            <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Fecha de Fin:</label>
                            <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div class="form-group">
                            <label>Hora de Inicio:</label>
                            <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" TextMode="Time"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Hora de Fin:</label>
                            <asp:TextBox ID="txtHoraFin" runat="server" CssClass="form-control" TextMode="Time"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnEnviar" CssClass="btn btn-success" runat="server" OnClick="Solicitar_Click" Text="Solicitar" />
                </form>
            </div>
        </div>
    </div>    
</asp:Content>
