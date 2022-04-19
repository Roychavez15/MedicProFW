using MaterialSkin.Controls;
using MedicProFW.Win.Data;
using MedicProFW.Win.Data.Entities;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicProFW.Win
{
    public partial class frmServicios : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmServicios()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            CargaServicios();
        }
        private void CargaServicios()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var servicios = db.Servicios
                    .OrderBy(a => a.Codigo);
                sfDataGrid1.DataSource = servicios.ToList();


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

            var record1 = sfDataGrid1.View.Records.GetItemAt(recordIndex);
            lblId.Text = (record1.GetType().GetProperty(mappingName).GetValue(record1, null).ToString());
            txtCodigo.Text = (record1.GetType().GetProperty(mappingName1).GetValue(record1, null).ToString());
            txtDescripcion.Text = (record1.GetType().GetProperty(mappingName2).GetValue(record1, null).ToString());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                var servicios = db.Servicios
                   .FirstOrDefault(c => c.Codigo == txtCodigo.Text);
                if (servicios == null)
                {
                    Servicio servicios1 = new Servicio
                    {
                        Codigo = txtCodigo.Text,
                        Descripcion = txtDescripcion.Text
                    };
                    db.Servicios.Add(servicios1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Servicio Creada con Exito");

                    lblId.Text = "0";
                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";

                    CargaServicios();
                }
                else
                {
                    MessageBox.Show("Este codigo ya existe");
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var servicio = db.Servicios
                   .FirstOrDefault(c => c.Id == id);
                if (servicio != null)
                {
                    servicio.Descripcion = txtDescripcion.Text;
                    db.Entry(servicio).State = EntityState.Modified;
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Servicio Actualizada con Exito");

                    //lblId.Text = "0";
                    //txtCodigo.Text = "";
                    //txtDescripcion.Text = "";

                    CargaServicios();
                }
                else
                {
                    MessageBox.Show("Este codigo ya existe");
                }
            }
        }
    }
}
