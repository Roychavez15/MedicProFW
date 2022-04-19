using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Models
{
    public class PlanillaDetailsViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string TIPO_PROCEDIMIENTO { get; set; }
        public int Cantidad { get; set; }

        public decimal Valor { get; set; }

        public decimal Total { get; set; }
        public string Medico { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
