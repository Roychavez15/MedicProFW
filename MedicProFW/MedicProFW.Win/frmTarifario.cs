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
    public partial class frmTarifario : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmTarifario()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmTarifario_Load(object sender, EventArgs e)
        {
            CargaTarifario();
        }
        private void CargaTarifario()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var tarifarios = db.Tarifarios
                    .OrderBy(a => a.Codigo);
                sfDataGrid1.DataSource = tarifarios.ToList();


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
            var mappingName4 = sfDataGrid1.Columns[4].MappingName;
            var mappingName5 = sfDataGrid1.Columns[5].MappingName;

            var record1 = sfDataGrid1.View.Records.GetItemAt(recordIndex);
            lblId.Text = (record1.GetType().GetProperty(mappingName).GetValue(record1, null).ToString());
            txtCodigo.Text = (record1.GetType().GetProperty(mappingName1).GetValue(record1, null).ToString());
            txtNombre.Text = (record1.GetType().GetProperty(mappingName2).GetValue(record1, null).ToString());            
            txtValor.Text = (record1.GetType().GetProperty(mappingName3).GetValue(record1, null).ToString()); ;
            try
            {
                cmbEstado.Text = (record1.GetType().GetProperty(mappingName4).GetValue(record1, null).ToString()); ;
            }
            catch { }
            var estado = (record1.GetType().GetProperty(mappingName5).GetValue(record1, null).ToString()); ;
            if(estado.Trim()=="ACTIVO")
            {
                chkEstado.Checked = true;
            }
            else
            {
                chkEstado.Checked = false;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var estado = "DESACTIVADO";
            if(chkEstado.Checked)
            {
                estado = "ACTIVO";
            }
            using (DataContext db = new DataContext())
            {
                var tarifario = db.Tarifarios
                   .FirstOrDefault(c => c.Codigo == txtCodigo.Text);
                if (tarifario == null)
                {
                    Tarifario tarifario1 = new Tarifario
                    {
                        Codigo = txtCodigo.Text,
                        Nombre = txtNombre.Text,
                        Valor = Convert.ToDecimal(txtValor.Text),
                        TIPO_PROCEDIMIENTO = cmbEstado.Text,
                        Estado= estado
                    };
                    db.Tarifarios.Add(tarifario1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Tarifa Creada con Exito");

                    lblId.Text = "0";
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtValor.Text = "0";
                    cmbEstado.Text = "--Seleccionar--";
                    chkEstado.Checked = false;

                    CargaTarifario();
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
                var tarifario = db.Tarifarios
                   .FirstOrDefault(c => c.Id == id);
                if (tarifario != null)
                {
                    tarifario.Nombre = txtNombre.Text;
                    tarifario.Valor = Convert.ToDecimal(txtValor.Text.Substring(1));
                    tarifario.TIPO_PROCEDIMIENTO = cmbEstado.Text;
                    if(chkEstado.Checked)
                    {
                        tarifario.Estado = "ACTIVO";
                    }
                    else
                    {
                        tarifario.Estado = "DESACTIVADO";
                    }
                    db.Entry(tarifario).State = EntityState.Modified;
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Tarifa Actualizada con Exito");

                    //lblId.Text = "0";
                    //txtCodigo.Text = "";
                    //txtDescripcion.Text = "";

                    CargaTarifario();
                }
                else
                {
                    MessageBox.Show("Este codigo ya existe");
                }
            }
        }
    }
}
