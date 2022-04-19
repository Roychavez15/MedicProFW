using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Data.Entities
{
    public class Paciente
    {
        public int Id { get; set; }

        [Display(Name = "Cédula")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Cedula { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Apellidos { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Pais de Nacimiento")]
        public string Pais { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Provincia de Nacimiento")]
        public string Provincia { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Ciudad de Nacimiento")]
        public string Ciudad { get; set; }


        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Telefono Convecional")]
        public string HomePhone { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Telefono Celular")]
        public string CellularPhone { get; set; }

        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        public string TipoBeneficiario { get; set; }



        [Display(Name = "Afiliado")]
        public string FullName => $"{Nombres} {Apellidos}";


        public int edad
        {
            get
            {
                DateTime now = DateTime.Today;
                int edad = DateTime.Today.Year - FechaNacimiento.Year;

                if (DateTime.Today < FechaNacimiento.AddYears(edad))
                    return --edad;
                else
                    return edad;
            }
        }

    }
}
