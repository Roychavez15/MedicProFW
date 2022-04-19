using MaterialSkin.Controls;
using MedicProFW.Win.Data;
using MedicProFW.Win.Data.Entities;
using Syncfusion.WinForms.DataGrid;
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
    public partial class frmUsuarios : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmUsuarios()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargaUsuarios();
        }
        private void CargaUsuarios()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var usuarios = db.Users
                    .OrderBy(a => a.Usuario);
                sfDataGrid1.DataSource = usuarios.ToList();


            }
        }

        private void sfDataGrid1_CurrentCellActivated(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellActivatedEventArgs e)
        {
            var rowIndex = e.DataRow.RowIndex;
            //Get the column index value
            var columnIndex = e.DataColumn.ColumnIndex;
            //Get the cell value            
            //var celdas = sfDataGrid2.
            var currentCellValue = sfDataGrid1.CurrentCell.CellRenderer.GetControlValue();

            var recordIndex = sfDataGrid1.TableControl.ResolveToRecordIndex(rowIndex);
            var mappingName = sfDataGrid1.Columns[0].MappingName;
            var mappingName1 = sfDataGrid1.Columns[1].MappingName;
            var mappingName2 = sfDataGrid1.Columns[2].MappingName;
            var mappingName3 = sfDataGrid1.Columns[3].MappingName;
            var mappingName4 = sfDataGrid1.Columns[5].MappingName;
            var mappingName5 = sfDataGrid1.Columns[6].MappingName;
            var mappingName6 = sfDataGrid1.Columns[7].MappingName;
            var mappingName7 = sfDataGrid1.Columns[8].MappingName;
            
            var record1 = sfDataGrid1.View.Records.GetItemAt(recordIndex);
            lblId.Text = (record1.GetType().GetProperty(mappingName).GetValue(record1, null).ToString());
            txtCodigo.Text = (record1.GetType().GetProperty(mappingName1).GetValue(record1, null).ToString());
            txtNombre.Text = (record1.GetType().GetProperty(mappingName2).GetValue(record1, null).ToString());
            txtApellido.Text = (record1.GetType().GetProperty(mappingName3).GetValue(record1, null).ToString());
            txtUsuario.Text = (record1.GetType().GetProperty(mappingName6).GetValue(record1, null).ToString());
            txtClave.Text = (record1.GetType().GetProperty(mappingName7).GetValue(record1, null).ToString());
            cmbRol.Text = (record1.GetType().GetProperty(mappingName5).GetValue(record1, null).ToString());
            var activado = (record1.GetType().GetProperty(mappingName4).GetValue(record1, null).ToString());
            if(activado=="True")
            {
                chkActivo.Checked = true;
            }
            else
            {
                chkActivo.Checked = false;
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                var usuario = db.Users
                   .FirstOrDefault(c => c.Usuario == txtUsuario.Text);
                if (usuario == null)
                {
                    User usuario1 = new User
                    {
                        Cedula = txtCodigo.Text,
                        FirstName = txtNombre.Text,
                        LastName = txtApellido.Text,
                        Usuario = txtUsuario.Text,
                        Clave = txtClave.Text,
                        Rol = cmbRol.Text,
                        isActive = chkActivo.Checked
                    };
                    db.Users.Add(usuario1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Usuario Creada con Exito");

                    lblId.Text = "0";
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    chkActivo.Checked = false;
                    CargaUsuarios();
                }
                else
                {
                    MessageBox.Show("Este Usuario ya existe");
                }
            }
        }
    }
}
