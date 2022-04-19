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
    public partial class frmSeguros : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmSeguros()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmSeguros_Load(object sender, EventArgs e)
        {
            CargaSeguros();
        }
        private void CargaSeguros()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var seguros = db.Seguros
                    .OrderBy(a => a.Codigo);
                sfDataGrid1.DataSource = seguros.ToList();


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
                var seguro = db.Seguros
                   .FirstOrDefault(c => c.Codigo == txtCodigo.Text);
                if (seguro == null)
                {
                    Seguro seguro1 = new Seguro
                    {
                        Codigo = txtCodigo.Text,
                        Descripcion = txtDescripcion.Text
                    };
                    db.Seguros.Add(seguro1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Seguro Creada con Exito");

                    lblId.Text = "0";
                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";

                    CargaSeguros();
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
                var seguro = db.Seguros
                   .FirstOrDefault(c => c.Id == id);
                if (seguro != null)
                {
                    seguro.Descripcion = txtDescripcion.Text;
                    db.Entry(seguro).State = EntityState.Modified;
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Seguro Actualizada con Exito");

                    //lblId.Text = "0";
                    //txtCodigo.Text = "";
                    //txtDescripcion.Text = "";

                    CargaSeguros();
                }
                else
                {
                    MessageBox.Show("Este codigo ya existe");
                }
            }
        }
    }
}
