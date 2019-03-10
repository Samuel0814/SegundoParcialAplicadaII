﻿using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcial.Consultas
{
    public partial class cPrestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Expression<Func<Prestamos, bool>> filtro = x => true;



        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Prestamos> rep = new RepositorioBase<Prestamos>();
            int dato = 0;
            switch (DropDownListFiltro.SelectedIndex)
            {
                case 0://Todo
                    filtro = x => true;
                    break;

                case 1://CuentaId
                    dato = int.Parse(TextBoxBuscar.Text);
                    filtro = (x => x.CuentaId == dato);
                    break;

                case 2://Fecha
                    filtro = (x => x.Fecha.Equals(TextBoxBuscar.Text));
                    break;

                case 3://Capital
                    decimal capital = decimal.Parse(TextBoxBuscar.Text);
                    filtro = (x => x.Capital == capital);
                    break;

                case 4://Interes Anual
                    decimal interes = decimal.Parse(TextBoxBuscar.Text);
                    filtro = (x => x.InteresAnual == interes);
                    break;

                case 5://Tiempo Meses
                    int tiempo = int.Parse(TextBoxBuscar.Text);
                    filtro = (x => x.TiempoMeses == tiempo);
                    break;
            }
            PrestamoGridView.DataSource = rep.GetList(filtro);
            PrestamoGridView.DataBind();
        }

        protected void PrestamoGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RepositorioBase<Prestamos> rb = new RepositorioBase<Prestamos>();
            PrestamoGridView.DataSource = rb.GetList(filtro);
            PrestamoGridView.PageIndex = e.NewPageIndex;
            PrestamoGridView.DataBind();
        }

        protected void PrestamoGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}