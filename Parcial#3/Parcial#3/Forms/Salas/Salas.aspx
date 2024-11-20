<%@ Page Title="Gestión de Salas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Salas.aspx.cs" Inherits="TeatrosWeb.Forms.Salas.Salas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
            <h2>Agregar Nueva Sala</h2>
            
            <!-- Formulario para nueva sala -->
            <div class="form-group">
                <label>Nombre de la Sala:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Dirección:</label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
                CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
        </div>

        <div class="col-md-12">
            <h3>Salas Registradas</h3>
            <asp:GridView ID="gvSalas" runat="server" CssClass="table table-striped" 
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="SalaID" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>