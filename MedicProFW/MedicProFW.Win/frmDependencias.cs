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
    public partial class frmDependencias : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmDependencias()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmDependencias_Load(object sender, EventArgs e)
        {
            CargaDependencs();
        }
        private void CargaDependencs()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var dependencias = db.Dependencias
                    .OrderBy(a => a.Codigo);
                sfDataGrid1.DataSource = dependencias.ToList();


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
                var dependencia = db.Dependencias
                   .FirstOrDefault(c => c.Codigo == txtCodigo.Text);
                if (dependencia == null)
                {
                    Dependencia dependencia1 = new Dependencia
                    {
                        Codigo= txtCodigo.Text,
                        Descripcion = txtDescripcion.Text
                    };
                    db.Dependencias.Add(dependencia1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Dependencia Creada con Exito");

                    lblId.Text = "0";
                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";

                    CargaDependencs();
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
                var dependencia = db.Dependencias
                   .FirstOrDefault(c => c.Id == id);
                if (dependencia != null)
                {
                    dependencia.Descripcion = txtDescripcion.Text;
                    db.Entry(dependencia).State = EntityState.Modified;
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Dependencia Actualizada con Exito");

                    //lblId.Text = "0";
                    //txtCodigo.Text = "";
                    //txtDescripcion.Text = "";

                    CargaDependencs();
                }
                else
                {
                    MessageBox.Show("Este codigo no existe");
                }
            }
        }
    }
}
