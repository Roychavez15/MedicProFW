﻿using MaterialSkin.Controls;
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
    public partial class frmMedicos : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmMedicos()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CargaMedicos();
            CargaDependecias();
        }
        private void CargaMedicos()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var medicos = db.Medicos
                    .OrderBy(a => a.Nombre);
                sfDataGrid1.DataSource = medicos.ToList();


            }
        }
        private void CargaDependecias()
        {
            DataContext db = new DataContext();
            List<Dependencia> customers = (from customer in db.Dependencias
                                           select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new Dependencia
            {
                Codigo = "0",
                Descripcion = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbDependecia.DataSource = customers;
            cmbDependecia.DisplayMember = "Descripcion";
            cmbDependecia.ValueMember = "Descripcion";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Descripcion);
            }

            cmbDependecia.AutoCompleteMode = AutoCompleteMode.None;
            cmbDependecia.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDependecia.AutoCompleteCustomSource = autotext;


            //textBoxExt1.da
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
            txtNombre.Text = (record1.GetType().GetProperty(mappingName1).GetValue(record1, null).ToString());
            cmbDependecia.Text = (record1.GetType().GetProperty(mappingName2).GetValue(record1, null).ToString());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(lblId.Text);
            using (DataContext db = new DataContext())
            {
                var medico = db.Medicos
                   .FirstOrDefault(c => c.Id == Id);
                if (medico == null)
                {
                    Medico medico1 = new Medico
                    {
                        Nombre = txtNombre.Text,
                        Especialidad = cmbDependecia.Text
                    };
                    db.Medicos.Add(medico1);
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Medico Creado con Exito");

                    lblId.Text = "0";
                    txtNombre.Text = "";
                    cmbDependecia.Text = "--Seleccionar--";

                    CargaMedicos();
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
                var medico = db.Medicos
                   .FirstOrDefault(c => c.Id == id);
                if (medico != null)
                {
                    medico.Nombre = txtNombre.Text;
                    medico.Especialidad = cmbDependecia.Text;

                    db.Entry(medico).State = EntityState.Modified;
                    var guardar = db.SaveChanges();
                    MessageBox.Show("Medico Actualizado con Exito");

                    //lblId.Text = "0";
                    //txtCodigo.Text = "";
                    //txtDescripcion.Text = "";

                    CargaMedicos();
                }
                else
                {
                    MessageBox.Show("Este codigo no existe");
                }
            }
        }
    }
}
