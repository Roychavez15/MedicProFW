using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Models
{
    public class PlanillasViewModel
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Paciente { get; set; }
        public string Seguro { get; set; }
        public string CIE { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public string Estado { get; set; }
        public Decimal Valor { get; set; }


    }
}
