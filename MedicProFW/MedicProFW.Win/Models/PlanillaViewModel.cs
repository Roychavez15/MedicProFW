using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Models
{
    public class PlanillaViewModel
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }

        public string Diagnostico1 { get; set; }
        public string Diagnostico2 { get; set; }
        public string Diagnostico3 { get; set; }
        public string Diagnostico4 { get; set; }
        public string CIE1 { get; set; }
        public string CIE2 { get; set; }
        public string CIE3 { get; set; }
        public string CIE4 { get; set; }
        public string DiagTipo1 { get; set; }
        public string DiagTipo2 { get; set; }
        public string DiagTipo3 { get; set; }
        public string DiagTipo4 { get; set; }
        public string CodigoDerivacion { get; set; }
        public string Secuencial { get; set; }
        public string Dependencia { get; set; }
        public string Contigencia { get; set; }
        public string Habitacion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string User { get; set; }

        public string TipoSeguro { get; set; }
        public string TipoBeneficiario { get; set; }
        public string CedulaTitular { get; set; }
        public string NombresTitular { get; set; }
        public string Parentezco { get; set; }
    }
}
