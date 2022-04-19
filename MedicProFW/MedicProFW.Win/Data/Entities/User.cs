using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Cédula")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Cedula { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }

        [Display(Name = "Fotografía")]
        public string ImageUrl { get; set; }

        public bool isActive { get; set; }

        public string Rol { get; set; }

        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
