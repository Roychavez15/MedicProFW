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
    public partial class frmDiagnosticos : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmDiagnosticos()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmDiagnosticos_Load(object sender, EventArgs e)
        {
            CargaDignosticos();
        }
        private void CargaDignosticos()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var diagnostico = db.Diagnosticos
                    .OrderBy(a => a.Codigo);
                sfDataGrid1.DataSource = diagnostico.ToList();


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
                var diagnostico = db.Diagnosticos
                   .FirstOrDefault(c => c.Codigo == txtCodigo.Text);
                if (diagnostico == null)
                {
                    Diagnostico diagnostico1 = new Diagnostico
                    {
                        Codigo = txtCodigo.Text,
                        Descripcion = txtDescripcion.Text
                    };
                    db.Diagnosticos.Add(diagnostico1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Diagnostico Creada con Exito");

                    lblId.Text = "0";
                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";

                    CargaDignosticos();
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
                var diagnostico = db.Diagnosticos
                   .FirstOrDefault(c => c.Id == id);
                if (diagnostico != null)
                {
                    diagnostico.Descripcion = txtDescripcion.Text;
                    db.Entry(diagnostico).State = EntityState.Modified;
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Diagnostico Actualizada con Exito");

                    //lblId.Text = "0";
                    //txtCodigo.Text = "";
                    //txtDescripcion.Text = "";

                    CargaDignosticos();
                }
                else
                {
                    MessageBox.Show("Este codigo ya existe");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
