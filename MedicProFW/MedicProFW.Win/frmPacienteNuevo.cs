using MaterialSkin.Controls;
using MedicProFW.Win.Data;
using MedicProFW.Win.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicProFW.Win
{
    public partial class frmPacienteNuevo : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmPacienteNuevo()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void frmPacienteNuevo_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if(txtCedula.Text=="")
            {
                MaterialMessageBox.Show("Debes Ingresar una cedula");
                return;
            }
            if (txtNombres.Text == "")
            {
                MaterialMessageBox.Show("Debes Ingresar un NOMBRE");
                return;
            }
            if (txtApellidos.Text == "")
            {
                MaterialMessageBox.Show("Debes Ingresar un APELLIDO");
                return;
            }

            if (cmbGenero.Text == "--Seleccionar--")
            {
                MaterialMessageBox.Show("Debes seleccionar un GENERO");
                return;
            }
            if (cmbEstadoCivil.Text == "--Seleccionar--")
            {
                MaterialMessageBox.Show("Debes seleccionar el ESTADO CIVIL");
                return;
            }
            using (DataContext db = new DataContext())
            {
                var paciente = db.Pacientes
                            .FirstOrDefault(c => c.Cedula == txtCedula.Text);
                if (paciente == null)
                {
                    Paciente miPaciente = new Paciente
                    {
                        Cedula = txtCedula.Text,
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Genero = cmbGenero.Text,
                        EstadoCivil = cmbEstadoCivil.Text,
                        FechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.Value),
                        Address = txtDireccion.Text,
                        HomePhone = txtTelefono.Text,
                        CellularPhone = txtCelular.Text,
                        Email = txtCorreo.Text
                    };

                    var guarda = db.Pacientes.Add(miPaciente);
                    db.SaveChanges();

                    MaterialMessageBox.Show("PACIENTE CREADO");
                    txtCedula.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtCelular.Text = "";
                    txtCorreo.Text = "";
                    cmbEstadoCivil.SelectedIndex = 0;
                    cmbGenero.SelectedIndex = 0;
                }
                else
                {
                    MaterialMessageBox.Show("Este paciente ya se encuentra registrado");
                }
            }
        }
    }
}
