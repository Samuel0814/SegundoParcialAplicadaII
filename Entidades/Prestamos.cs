﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Prestamos
    {
        [Key]
        public int PrestamosID { get; set; }
        public DateTime Fecha { get; set; }
        public int CuentaId { get; set; }
        public decimal Capital { get; set; }
        public decimal InteresAnual { get; set; }
        public int TiempoMeses { get; set; }
        public decimal CapitaTotal { get; set; }
        public decimal InteresTotal { get; set; }
        public decimal Total { get; set; }

        public virtual List<PrestamosDetalle> Detalle { get; set; }

        public Prestamos(int prestamosId, DateTime fecha, int cuentaId, decimal capital, decimal interesAnual, int tiempoMeses, decimal capitaTotal, decimal interesTotal, decimal total, List<PrestamosDetalle> detalle)
        {
            PrestamosID = prestamosId;
            Fecha = fecha;
            CuentaId = cuentaId;
            Capital = capital;
            InteresAnual = interesAnual;
            TiempoMeses = tiempoMeses;
            CapitaTotal = capitaTotal;
            InteresTotal = interesTotal;
            Total = total;
            Detalle = detalle;
        }

        public Prestamos()
        {
            this.PrestamosID = 0;
            this.Fecha = DateTime.Now;
            this.CuentaId = 0;
            this.Capital = 0;
            this.InteresAnual = 0;
            this.TiempoMeses = 0;
            CapitaTotal = 0;
            InteresTotal = 0;
            Total = 0;
            Detalle = new List<PrestamosDetalle>();
        }
    }
}
