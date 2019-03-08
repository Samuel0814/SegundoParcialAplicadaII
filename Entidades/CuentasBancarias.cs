﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentasBancarias
    {
        [Key]
        public int CuentaID { get; set; }

        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }

        public CuentasBancarias(int cuentaId, DateTime fecha, string nombre)
        {
            CuentaID = cuentaId;
            Fecha = fecha;
            Nombre = nombre;
        }

        public CuentasBancarias()
        {
            CuentaID = 0;
            Fecha = DateTime.Now;
            Nombre = String.Empty;
            Balance = 0;
        }
    }
}
