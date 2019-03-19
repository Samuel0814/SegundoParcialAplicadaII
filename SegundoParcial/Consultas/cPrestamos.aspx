﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cPrestamos.aspx.cs" Inherits="SegundoParcial.Consultas.cPrestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div class="form-group">
            <div class="row justify-content-center">
                <div class="col-md-2">
                    <label for="DropDownListFiltro">Filtro:</label>
                    <asp:DropDownList ID="DropDownListFiltro" CssClass="form-control" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        <asp:ListItem>Capital</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-4">
                    <label for="TextBoxBuscar">Buscar:</label>
                    <asp:TextBox ID="TextBoxBuscar" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-1 p-0">
                    <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-secondary mt-4" runat="server" OnClick="BuscarLinkButton_Click" OnPageIndexChanging="CuentaGridView_PageIndexChanging">
                        <span class="fas fa-search"></span>
                        Buscar
                    </asp:LinkButton>
                </div>
            </div>

            <div class="row justify-content-center mt-3">
                <div class="col-lg-11">
                    <asp:GridView ID="PrestamoGridView" runat="server" AllowPaging="true" PageSize="7" CssClass="table table-striped table-hover table-responsive-lg" AutoGenerateColumns="False" OnSelectedIndexChanged="PrestamoGridView_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="CuentaId" HeaderText="CuentaId" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField DataField="Capital" HeaderText="Capital" />
                            <asp:BoundField DataField="InteresAnual" HeaderText="Interes Anual" />
                            <asp:BoundField DataField="TiempoMeses" HeaderText="Tiempo Meses" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>