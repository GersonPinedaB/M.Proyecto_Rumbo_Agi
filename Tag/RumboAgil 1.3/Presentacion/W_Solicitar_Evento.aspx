<%@ Page Title="" Language="C#" MasterPageFile="~/RA_Sistema.Master" AutoEventWireup="true" CodeBehind="W_Solicitar_Evento.aspx.cs" Inherits="Presentacion.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="panel panel-success">
            <div class="panel-heading">
                Solicitar Evento
            </div>
            <div class="panel-body">
                <form>
                    <div class="form-group">
                        <label>Nombre:</label>
                        <input type="text" class="form-control" id="txtNombre" placeholder="Ingrese Nombre" />
                    </div>
                    <div class="form-group">
                        <label>Descripción:</label>
                        <textarea class="form-control" rows="4" placeholder="Descrioción"></textarea>
                    </div>
                    <div class="form-group">
                        <label>Tipo de Evento:</label>
                        <select class="form-control">
                            <option>One Vale</option>
                            <option>Two Vale</option>
                            <option>Three Vale</option>
                            <option>Four Vale</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label>Lugar:</label>
                        <select class="form-control">
                            <option>One Vale</option>
                            <option>Two Vale</option>
                            <option>Three Vale</option>
                            <option>Four Vale</option>
                        </select>
                    </div>
                    <div>
                        <div class="form-group">
                            <label>Fecha de Inicio:</label>
                            <input type="date" class="form-control" id="txtFechaInicio" />
                        </div>
                        <div class="form-group">
                            <label>Fecha de Fin:</label>
                            <input type="date" class="form-control" id="txtFechaFin" />
                        </div>
                    </div>
                    <div>
                        <div class="form-group">
                            <label>Hora de Inicio:</label>
                            <input type="text" class="form-control" id="txtInicio" />
                        </div>
                        <div class="form-group">
                            <label>Hora de Fin:</label>
                            <input type="text" class="form-control" id="txtFin"/>
                        </div>
                    </div>
                    <button type="submit" class="btn btn-success">Submit</button>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
