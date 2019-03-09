using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class PrestamosDetalle
    {
        [Key]
        public int PrestamoDetalleID { get; set; }
        public int PrestamoId { get; set; }
        public int NumCuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Valor { get; set; }
        public decimal Balance { get; set; }

        public PrestamosDetalle()
        {
            PrestamoDetalleID = 0;
            NumCuota = 0;
            PrestamoId = 0;
            Valor = 0;
            Capital = 0;
            Interes = 0;
            Balance = 0;
        }

        public PrestamosDetalle(int prestamoDetalleId, int numCuota, int PrestamoId, decimal Pago, decimal Capital, decimal Interes, decimal SaldoDeuda)
        {
            this.PrestamoDetalleID = prestamoDetalleId;
            this.NumCuota = numCuota;
            this.PrestamoId = PrestamoId;
            this.Valor = Pago;
            this.Capital = Capital;
            this.Interes = Interes;
            this.Balance = SaldoDeuda;
        }
    }
}
