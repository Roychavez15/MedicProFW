using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Data.Entities
{
    public class Tarifario
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public string TIPO_PROCEDIMIENTO { get; set; }
        public string Estado { get; set; }
    }
}
