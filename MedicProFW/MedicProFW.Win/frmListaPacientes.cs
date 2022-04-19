using MaterialSkin.Controls;
using MedicProFW.Win.Data;
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
    public partial class frmListaPacientes : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmListaPacientes()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmListaPacientes_Load(object sender, EventArgs e)
        {
            CargaPacientes();
        }
        private void CargaPacientes()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var pacientes = db.Pacientes
                    .OrderBy(a => a.Apellidos);
                sfDataGrid1.DataSource = pacientes.ToList();

 
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
            txtNombres.Text = (record1.GetType().GetProperty(mappingName2).GetValue(record1, null).ToString());
        }
    }
}
