<%@ Page Title="" Language="C#" MasterPageFile="~/RA_Sistema.Master" AutoEventWireup="true" CodeBehind="W_Evaluar_Solicitud.aspx.cs" Inherits="Presentacion.W_Evaluar_Solicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="float:left">
        <div id='calendar'></div>                    
    </div>
    <div class="row" style="float:right; width:500px">
        <div class="panel panel-success">
            <div class="panel-heading">
                Evaluar Evento
            </div>
            <div class="panel-body">
                <form id="formSolicitar" runat="server">
                    <div class="form-group">
                        <label>Evento:</label>
                        <asp:DropDownList ID="ddEventos" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddEventos_SelectedIndexChanged" AutoPostBack="True" >
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Lider:</label>
                        <asp:TextBox CssClass="form-control" id="txtLider" runat="server" ReadOnly="true"/>
                    </div>
                    <div class="form-group">
                        <label>Descripción:</label>
                        <asp:TextBox CssClass="form-control" ID="txtDescripcion" ReadOnly="true" Rows="2" TextMode="MultiLine" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Tipo de Evento:</label>
                        <asp:TextBox CssClass="form-control" ID="txtTipoEvento" ReadOnly="true" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Lugar:</label>
                        <asp:TextBox CssClass="form-control" ID="txtLugar" ReadOnly="true" runat="server" />
                    </div>
                    <div>
                        <div class="form-group">
                            <label>Fecha de Inicio:</label>
                            <asp:TextBox ID="txtFechaInicio" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Fecha de Fin:</label>
                            <asp:TextBox ID="txtFechaFin" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div class="form-group">
                            <label>Hora de Inicio:</label>
                            <asp:TextBox ID="txtHoraInicio" runat="server"  ReadOnly="true" CssClass="form-control" TextMode="Time"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Hora de Fin:</label>
                            <asp:TextBox ID="txtHoraFin" runat="server"  ReadOnly="true" CssClass="form-control" TextMode="Time"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnEnviar" CssClass="btn btn-success" runat="server" OnClick="Aprobar_Click" Text="Aprobar" />
                    <asp:Button ID="btnRechazar" CssClass="btn btn-danger" runat="server" OnClick="Rechazar_Click" Text="Rechazar" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>