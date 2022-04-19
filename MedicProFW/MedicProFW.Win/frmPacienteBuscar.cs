using CrystalDecisions.Windows.Forms;
using MaterialSkin.Controls;
using MedicProFW.Win.Data;
using MedicProFW.Win.Data.DataReports;
using MedicProFW.Win.Data.Entities;
using MedicProFW.Win.Helpers;
using MedicProFW.Win.Models;
using MedicProFW.Win.Reportes;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
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
    public partial class frmPacienteBuscar : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmPacienteBuscar()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            //this.sfDataGrid1.AllowDeleting = true;

        }

        private void frmPacienteBuscar_Load(object sender, EventArgs e)
        {
            CargaDependecias();
            CargaDiagnosticos();
            CargaContingencias();
            CargaTipos();
            CargaHab();
            CargaTarifario();
            CargaEstados();
            CargaTipoSeguro();
            CargaMedicos();
            //materialTabControl1.TabPages[1].Parent.Enabled = false;
            //materialTabControl1.TabPages[2].Parent.Enabled = false;

            this.sfDataGrid1.SelectionMode = GridSelectionMode.Single;
            this.sfDataGrid2.SelectionMode = GridSelectionMode.Single;
        }
        private void CargaMedicos()
        {
            DataContext db = new DataContext();
            List<Medico> customers = (from customer in db.Medicos
                                           select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new Medico
            {
                Id = 0,
                Nombre = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbMedico.DataSource = customers;
            cmbMedico.DisplayMember = "Nombre";
            cmbMedico.ValueMember = "Nombre";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Nombre);
            }

            cmbMedico.AutoCompleteMode = AutoCompleteMode.None;
            cmbMedico.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedico.AutoCompleteCustomSource = autotext;


            //textBoxExt1.da
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
        private void CargaContingencias()
        {
            DataContext db = new DataContext();
            List<Enfermedad> customers = (from customer in db.Enfermedades
                                           select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new Enfermedad
            {
                Codigo = "0",
                Descripcion = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbContingencia.DataSource = customers;
            cmbContingencia.DisplayMember = "Descripcion";
            cmbContingencia.ValueMember = "Descripcion";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Descripcion);
            }

            cmbContingencia.AutoCompleteMode = AutoCompleteMode.None;
            cmbContingencia.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbContingencia.AutoCompleteCustomSource = autotext;


            //textBoxExt1.da
        }
        private void CargaTipos()
        {
            DataContext db = new DataContext();
            List<Servicio> customers = (from customer in db.Servicios
                                          select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new Servicio
            {
                Codigo = "0",
                Descripcion = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbTipo.DataSource = customers;
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "Descripcion";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Descripcion);
            }

            cmbTipo.AutoCompleteMode = AutoCompleteMode.None;
            cmbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipo.AutoCompleteCustomSource = autotext;


            //textBoxExt1.da
        }
        private void CargaHab()
        {
            DataContext db = new DataContext();
            List<Habitacion> customers = (from customer in db.Habitaciones
                                        select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new Habitacion
            {
                Codigo = "0",
                Descripcion = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbHabitacion.DataSource = customers;
            cmbHabitacion.DisplayMember = "Descripcion";
            cmbHabitacion.ValueMember = "Descripcion";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Descripcion);
            }

            cmbHabitacion.AutoCompleteMode = AutoCompleteMode.None;
            cmbHabitacion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbHabitacion.AutoCompleteCustomSource = autotext;


            //textBoxExt1.da
        }
        private void CargaTarifario()
        {
            DataContext db = new DataContext();
            List<Tarifario> customers = (from customer in db.Tarifarios
                                         select customer).ToList();

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Codigo + "-" + item.Nombre + " ["+item.Valor+"]");
            }
            //textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //textBox1.AutoCompleteCustomSource = autotext;
            autoComplete2.DataSource = autotext;


        }
        private void CargaTipoSeguro()
        {
            DataContext db = new DataContext();
            List<Seguro> customers = (from customer in db.Seguros
                                         select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new Seguro
            {
                Codigo = "0",
                Descripcion = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbTipoSeguro.DataSource = customers;
            cmbTipoSeguro.DisplayMember = "Descripcion";
            cmbTipoSeguro.ValueMember = "Descripcion";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Descripcion);
            }

            cmbTipoSeguro.AutoCompleteMode = AutoCompleteMode.None;
            cmbTipoSeguro.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoSeguro.AutoCompleteCustomSource = autotext;


        }
        private void CargaDiagnosticos()
        {
            DataContext db = new DataContext();
            List<Diagnostico> customers = (from customer in db.Diagnosticos
                                           select customer).ToList();

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach(var item in customers)
            {
                autotext.Add(item.Codigo + "-" + item.Descripcion);
            }
            //textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //textBox1.AutoCompleteCustomSource = autotext;
            autoComplete1.DataSource = autotext;
            

        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            lblIdItem.Text = "0";
            sfDataGrid1.DataSource = null;
            sfDataGrid2.DataSource = null;
            btnEliminarItem.Enabled = true;
            btnPlanillar.Enabled = true;
            btnEliminarTodos.Enabled = true;

            //materialTabControl1.TabPages[0].Parent.Visible = true;
            //materialTabControl1.TabPages[1].Parent.Visible = true;
            //materialTabControl1.TabPages[2].Parent.Visible = false;

            dtFechaInicio.Value = DateTime.Now;
            dtFechaFin.Value = DateTime.Now;
            txtDiag1.Text = "";
            cmbD1.Text = "DEF";

            txtDiag2.Text = "";
            cmbD2.Text = "DEF";

            txtDiag3.Text = "";
            cmbD3.Text = "DEF";
            txtDiag4.Text = "";
            cmbD4.Text = "DEF";

            txtCodigoDerivacion.Text = "";
            txtSecuencial.Text = "";

            cmbContingencia.Text = "--Seleccionar--";
            cmbDependecia.Text = "--Seleccionar--";
            cmbHabitacion.Text = "--Seleccionar--";
            cmbTipo.Text = "--Seleccionar--";
            cmbTipoSeguro.Text = "--Seleccionar--";
            cmbParentesco.Text = "--Seleccionar--";

            btnGuardar.Text = "GUARDAR";

            using (DataContext db = new DataContext())
            {
                var paciente = db.Pacientes
                            .FirstOrDefault(c => c.Cedula == txtCedula.Text);
                if (paciente != null)
                {
                    txtCedula.Enabled = false;
                    txtNombres.Text = paciente.Nombres;
                    txtApellidos.Text = paciente.Apellidos;
                    dtFechaNacimiento.Value = paciente.FechaNacimiento;
                    //cmbBeneficiario.Text = paciente.TipoBeneficiario;
                    cmbGenero.Text = paciente.Genero;
                    cmbEstadoCivil.Text = paciente.EstadoCivil;
                    txtDireccion.Text = paciente.Address;
                    txtTelefono.Text = paciente.HomePhone;
                    txtCelular.Text = paciente.CellularPhone;
                    //materialTabControl1.TabPages[1].Parent.Visible = true;
                    //materialTabControl1.TabPages[2].Parent.Visible = false;
                    CargaPlanillas();
                }
                else
                {
                    MaterialMessageBox.Show("No existe Paciente con esta CEDULA");
                }
            }
        }

        private void CargaEstados()
        {
            DataContext db = new DataContext();
            List<EstadoPlanilla> customers = (from customer in db.EstadoPlanillas
                                          select customer).ToList();

            //Insert the Default Item to List.
            customers.Insert(0, new EstadoPlanilla
            {
                Id = 0,
                Estado = "--Seleccionar--"
            });

            //Assign Entity as DataSource.
            cmbEstado.DataSource = customers;
            cmbEstado.DisplayMember = "Estado";
            cmbEstado.ValueMember = "Estado";

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            foreach (var item in customers)
            {
                autotext.Add(item.Estado);
            }

            cmbEstado.AutoCompleteMode = AutoCompleteMode.None;
            cmbEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEstado.AutoCompleteCustomSource = autotext;


            //textBoxExt1.da
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var diagnostico1 = "";
            var diagnostico2 = "";
            var diagnostico3 = "";
            var diagnostico4 = "";

            var cie10_1 = "";
            var cie10_2 = "";
            var cie10_3 = "";
            var cie10_4 = "";

            var tipoDiag1 = "";
            var tipoDiag2 = "";
            var tipoDiag3 = "";
            var tipoDiag4 = "";

            var tiposeguro = "";
            var tipobeneficiario = "";
            var cedulatitular = "";
            var nombrestitular = "";
            var parentesco = "";

            using (DataContext db = new DataContext())
            {
                var usuario = db.Users
                   .FirstOrDefault(c => c.Usuario == Global.UserLogin);
                if (usuario == null)
                {
                    return;
                }

                var paciente = db.Pacientes
                            .FirstOrDefault(c => c.Cedula == txtCedula.Text);
                if (paciente == null)
                {
                    return;
                }

                if (!string.IsNullOrEmpty(txtDiag1.Text))
                {
                    var diag = txtDiag1.Text.Split('-');

                    diagnostico1 = diag[1].Trim();
                    cie10_1 = diag[0].Trim();
                    tipoDiag1 = cmbD1.Text;
                }
                if (!string.IsNullOrEmpty(txtDiag2.Text))
                {
                    var diag = txtDiag2.Text.Split('-');

                    diagnostico2 = diag[1].Trim();
                    cie10_2 = diag[0].Trim();
                    tipoDiag2 = cmbD2.Text;
                }
                if (!string.IsNullOrEmpty(txtDiag3.Text))
                {
                    var diag = txtDiag3.Text.Split('-');

                    diagnostico3 = diag[1].Trim();
                    cie10_3 = diag[0].Trim();
                    tipoDiag3 = cmbD3.Text;
                }
                if (!string.IsNullOrEmpty(txtDiag4.Text))
                {
                    var diag = txtDiag4.Text.Split('-');

                    diagnostico4 = diag[1].Trim();
                    cie10_4 = diag[0].Trim();
                    tipoDiag4 = cmbD4.Text;
                }

                var dependencia = db.Dependencias
                    .FirstOrDefault(c => c.Descripcion == cmbDependecia.Text);
                if (dependencia == null)
                {
                    return;
                }
                var contingencia = db.Enfermedades
                    .FirstOrDefault(c => c.Descripcion == cmbContingencia.Text);
                if (contingencia == null)
                {
                    return;
                }

                var habitacion = db.Habitaciones
                    .FirstOrDefault(c => c.Descripcion == cmbHabitacion.Text);
                if (habitacion == null)
                {
                    return;
                }

                var tipo = db.Servicios
                    .FirstOrDefault(c => c.Descripcion == cmbTipo.Text);
                if (tipo == null)
                {
                    return;
                }

                var estado = "";
                if(cmbEstado.Text!="--Seleccionar--")
                {
                    estado = cmbEstado.Text;
                }
                if (cmbBeneficiario.Text != "--Seleccionar--")
                {
                    tipobeneficiario = cmbBeneficiario.Text;
                }
                if (cmbTipoSeguro.Text != "--Seleccionar--")
                {
                    tiposeguro = cmbTipoSeguro.Text;
                }
                if (cmbBeneficiario.Text != "DEPENDIENTE")
                {
                    cedulatitular = txtCedulaTitular.Text;
                    nombrestitular = txtNombresTitular.Text;
                    if(cmbParentesco.Text!="--Seleccionar--")
                    {
                        parentesco = cmbParentesco.Text;
                    }                    
                }

                if (btnGuardar.Text == "GUARDAR")
                {

                    Planilla planilla = new Planilla
                    {
                        Paciente = paciente,
                        Fecha_Inicio = dtFechaInicio.Value,
                        Fecha_Fin = dtFechaFin.Value,
                        Diagnostico1 = diagnostico1,
                        Diagnostico2 = diagnostico2,
                        Diagnostico3 = diagnostico3,
                        Diagnostico4 = diagnostico4,
                        CIE1 = cie10_1,
                        CIE2 = cie10_2,
                        CIE3 = cie10_3,
                        CIE4 = cie10_4,
                        DiagTipo1 = tipoDiag1,
                        DiagTipo2 = tipoDiag2,
                        DiagTipo3 = tipoDiag3,
                        DiagTipo4 = tipoDiag4,
                        CodigoDerivacion = txtCodigoDerivacion.Text,
                        Secuencial = txtSecuencial.Text,
                        Dependencia = dependencia,
                        Contigencia = contingencia,
                        Habitacion = habitacion,
                        Tipo = tipo,
                        User = usuario,
                        Fecha = DateTime.Now,
                        Estado = estado,
                        TipoSeguro = tiposeguro,
                        TipoBeneficiario = tipobeneficiario,
                        CedulaTitular = txtCedulaTitular.Text,
                        NombresTitular = txtCedulaTitular.Text,
                        Parentezco = cmbParentesco.Text
                    };

                    db.Planillas.Add(planilla);
                    var guardar = db.SaveChanges();
                    label1.Text = planilla.Id.ToString();
                    if (label1.Text != "0")
                    {
                        btnGuardar.Text = "ACTUALIZAR";
                        //materialTabControl1.TabPages[2].Parent.Enabled = true;
                        MessageBox.Show("Planilla Guardada con exito Nº " + planilla.Id.ToString());
                    }
                }
                else //ACTUALLIZA
                {
                    int id = Convert.ToInt32(label1.Text);
                    var planilla1 = db.Planillas
                        .FirstOrDefault(c => c.Id == id);
                    if (planilla1 == null)
                    {
                        MessageBox.Show("PLANILLA NO EXISTE");
                        return;
                    }
                    planilla1.Id = id;
                    planilla1.Paciente = paciente;
                    planilla1.Fecha_Inicio = dtFechaInicio.Value;
                    planilla1.Fecha_Fin = dtFechaFin.Value;
                    planilla1.Diagnostico1 = diagnostico1;
                    planilla1.Diagnostico2 = diagnostico2;
                    planilla1.Diagnostico3 = diagnostico3;
                    planilla1.Diagnostico4 = diagnostico4;
                    planilla1.CIE1 = cie10_1;
                    planilla1.CIE2 = cie10_2;
                    planilla1.CIE3 = cie10_3;
                    planilla1.CIE4 = cie10_4;
                    planilla1.DiagTipo1 = tipoDiag1;
                    planilla1.DiagTipo2 = tipoDiag2;
                    planilla1.DiagTipo3 = tipoDiag3;
                    planilla1.DiagTipo4 = tipoDiag4;
                    planilla1.CodigoDerivacion = txtCodigoDerivacion.Text;
                    planilla1.Secuencial = txtSecuencial.Text;
                    planilla1.Dependencia = dependencia;
                    planilla1.Contigencia = contingencia;
                    planilla1.Habitacion = habitacion;
                    planilla1.Tipo = tipo;
                    planilla1.User = usuario;
                    planilla1.Fecha = DateTime.Now;
                    planilla1.Estado = estado;
                    planilla1.TipoSeguro = tiposeguro;
                    planilla1.TipoBeneficiario = tipobeneficiario;
                    planilla1.CedulaTitular = cedulatitular;
                    planilla1.NombresTitular = nombrestitular;
                    planilla1.Parentezco = parentesco;

                    //db.Planillas.Add(planilla1);
                    db.Entry(planilla1).State = EntityState.Modified;
                    
                    var guardar = db.SaveChanges();

                    MessageBox.Show("Planilla Actualizada con exito Nº " + planilla1.Id.ToString());

                    if (VerificaEstadoPlanilla(estado) == "SI")
                    {
                        btnEliminarItem.Enabled = false;
                        btnPlanillar.Enabled = false;
                        btnEliminarTodos.Enabled = false;
                    }
                    else
                    {
                        btnEliminarItem.Enabled = true;
                        btnPlanillar.Enabled = true;
                        btnEliminarTodos.Enabled = true;
                    }

                }
                CargaPlanillas();
            }
        }

        private void btnLimpia2_Click(object sender, EventArgs e)
        {
            txtDiag2.Text = "";
        }

        private void btnLimpia3_Click(object sender, EventArgs e)
        {
            txtDiag3.Text = "";
        }

        private void btnLimpia4_Click(object sender, EventArgs e)
        {
            txtDiag4.Text = "";
        }

        private void CargaPlanillas()
        {
            using (DataContext db = new DataContext())
            {
                var planillas = db.Planillas


                   .Where(p => p.Paciente.Cedula == txtCedula.Text)
                   .Include(c => c.Contigencia)
                   .Include(d => d.Dependencia)
                   .Include(t => t.Tipo)
                   .Include(u => u.User);

                var planillaViewModel = planillas.Select(p => new PlanillaViewModel
                {
                    Id = p.Id,                    
                    Estado = p.Estado,
                    Fecha_Inicio = p.Fecha_Inicio,
                    Fecha_Fin = p.Fecha_Fin,
                    Diagnostico1 = p.Diagnostico1,
                    Diagnostico2 = p.Diagnostico2,
                    Diagnostico3 = p.Diagnostico3,
                    Diagnostico4 = p.Diagnostico4,
                    CIE1 = p.CIE1,
                    CIE2 = p.CIE2,
                    CIE3 = p.CIE3,
                    CIE4 = p.CIE4,
                    DiagTipo1 = p.DiagTipo1,
                    DiagTipo2 = p.DiagTipo2,
                    DiagTipo3 = p.DiagTipo3,
                    DiagTipo4 = p.DiagTipo4,
                    CodigoDerivacion = p.CodigoDerivacion,
                    Secuencial = p.Secuencial,
                    Dependencia = p.Dependencia.Descripcion,
                    Contigencia = p.Contigencia.Descripcion,
                    Habitacion = p.Habitacion.Descripcion,
                    Tipo = p.Tipo.Descripcion,
                    Fecha = p.Fecha,
                    User = p.User.Usuario,
                    TipoBeneficiario = p.TipoBeneficiario,
                    TipoSeguro = p.TipoSeguro,
                    CedulaTitular = p.CedulaTitular,
                    NombresTitular = p.NombresTitular,
                    Parentezco = p.Parentezco
                });

                sfDataGrid2.DataSource = planillaViewModel.ToList();
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(label1.Text);
            using (DataContext db = new DataContext())
            {


                try
                {
                    var usuario = db.Users
                        .FirstOrDefault(c => c.Usuario == Global.UserLogin);
                    if (usuario == null)
                    {
                        return;
                    }

                    var planilla = db.Planillas
                        .FirstOrDefault(c => c.Id == id);
                    if (planilla == null)
                    {
                        return;
                    }

                    var cod = txtProducto.Text.Split('-');
                    var codigo = cod[0].ToString();

                    var tarifa = db.Tarifarios
                        .FirstOrDefault(c => c.Codigo == codigo);
                    if (tarifa == null)
                    {
                        return;
                    }
                    var medico = "";
                    if(cmbMedico.Text!="--Seleccionar--")
                    {
                        medico = cmbMedico.Text;
                    }
                    var planillaDetail = new PlanillaDetail
                    {
                        Planilla = planilla,
                        Codigo = tarifa.Codigo,
                        Nombre = tarifa.Nombre,
                        Valor = tarifa.Valor,
                        TIPO_PROCEDIMIENTO = tarifa.TIPO_PROCEDIMIENTO,
                        Cantidad = Convert.ToInt32(txtCantidad.Text),
                        Medico = medico,
                        Fecha = dtFechaTarifario.Value,
                        Observacion = txtObservacion.Text,
                        User = usuario
                    };
                    db.PlanillaDetails.Add(planillaDetail);
                    var guardar = db.SaveChanges();

                    txtProducto.Text = "";
                    cmbMedico.Text = "--Seleccionar--";
                    txtCantidad.Text = "1";
                    txtObservacion.Text = "";
                    dtFechaTarifario.Value = DateTime.Now;

                    CargaPlanillaDetalle();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void CargaPlanilla(int id)
        {
            using (DataContext db = new DataContext())
            {
                var planilla = db.Planillas
                    .Include(c => c.Contigencia)
                    .Include(d => d.Dependencia)
                    .Include(h => h.Habitacion)
                    .Include(t => t.Tipo)
                    .FirstOrDefault(c => c.Id == id);
                    
                if (planilla == null)
                {
                    MessageBox.Show("NO EXISTE PLANILLA");
                    return;
                }
                dtFechaInicio.Value = planilla.Fecha_Inicio;
                dtFechaFin.Value = planilla.Fecha_Fin;
                txtDiag1.Text = planilla.CIE1.Trim() + " - " + planilla.Diagnostico1.Trim();
                cmbD1.Text = planilla.DiagTipo1;
                if(!string.IsNullOrEmpty(planilla.CIE2))
                {
                    txtDiag2.Text = planilla.CIE2.Trim() + " - " + planilla.Diagnostico2.Trim();
                    cmbD2.Text = planilla.DiagTipo2;
                }
                if (!string.IsNullOrEmpty(planilla.CIE3))
                {
                    txtDiag3.Text = planilla.CIE3.Trim() + " - " + planilla.Diagnostico3.Trim();
                    cmbD3.Text = planilla.DiagTipo3;
                }
                if (!string.IsNullOrEmpty(planilla.CIE4))
                {
                    txtDiag4.Text = planilla.CIE4.Trim() + " - " + planilla.Diagnostico4.Trim();
                    cmbD4.Text = planilla.DiagTipo4;
                }
                if (!string.IsNullOrEmpty(planilla.TipoBeneficiario))
                {
                    cmbBeneficiario.Text = planilla.TipoBeneficiario;
                }
                if (!string.IsNullOrEmpty(planilla.TipoSeguro))
                {
                    cmbTipoSeguro.Text = planilla.TipoSeguro;
                }
                if (!string.IsNullOrEmpty(planilla.Parentezco))
                {
                    cmbParentesco.Text = planilla.Parentezco;
                }

                txtCodigoDerivacion.Text = planilla.CodigoDerivacion;
                txtSecuencial.Text = planilla.Secuencial;

                cmbContingencia.Text = planilla.Contigencia.Descripcion;
                cmbDependecia.Text = planilla.Dependencia.Descripcion;
                cmbHabitacion.Text = planilla.Habitacion.Descripcion;
                cmbTipo.Text = planilla.Tipo.Descripcion;
                cmbEstado.Text = planilla.Estado;
                txtCedulaTitular.Text = planilla.CedulaTitular;
                txtNombresTitular.Text = planilla.NombresTitular;

                if (VerificaEstadoPlanilla(planilla.Estado)=="SI")
                {
                    btnEliminarItem.Enabled = false;
                    btnPlanillar.Enabled = false;
                    btnEliminarTodos.Enabled = false;
                }
                else
                {
                    btnEliminarItem.Enabled = true;
                    btnPlanillar.Enabled = true;
                    btnEliminarTodos.Enabled = true;
                }
            }
        }
        private void CargaPlanillaDetalle()
        {

            sfDataGrid1.DataSource = null;
            sfDataGrid1.TableSummaryRows.Clear();
            sfDataGrid1.AllowFiltering = true;


            int Id = Convert.ToInt32(label1.Text);
            using (DataContext db = new DataContext())
            {
                var planillas = db.PlanillaDetails


                   .Where(p => p.Planilla.Id == Id)
                   .Include(c => c.Planilla)
                   .Include(u => u.User);

                var planillaDetailsViewModel = planillas.Select(p => new PlanillaDetailsViewModel
                {
                    Id = p.Id,
                    Codigo = p.Codigo,
                    Producto = p.Nombre,
                    TIPO_PROCEDIMIENTO = p.TIPO_PROCEDIMIENTO,
                    Cantidad = p.Cantidad,
                    Valor = p.Valor,                    
                    Total = p.Cantidad * p.Valor,
                    Medico = p.Medico,
                    Observacion = p.Observacion,
                    Fecha = p.Fecha,
                    Usuario = p.User.Usuario
                });

                sfDataGrid1.DataSource = planillaDetailsViewModel.ToList();

                //this.sfDataGrid1.ShowGroupDropArea = true;
                //this.sfDataGrid1.AllowGrouping = true;

                //GroupColumnDescription groupColumnDescription = new GroupColumnDescription();
                //groupColumnDescription.ColumnName = "Id";
                //this.sfDataGrid1.GroupColumnDescriptions.Add(groupColumnDescription);

                GridTableSummaryRow tableSummaryRow = new GridTableSummaryRow();
                tableSummaryRow.Name = "TableSummary";

                tableSummaryRow.ShowSummaryInRow = false;

                tableSummaryRow.Title = "Planilla Total: {Total}";
                tableSummaryRow.Position = VerticalPosition.Bottom;

                GridSummaryColumn summaryColumn = new GridSummaryColumn();
                summaryColumn.Name = Name = "Column1";
                summaryColumn.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate;
                summaryColumn.Format = "{Sum:c}";
                summaryColumn.MappingName = "Total";

                tableSummaryRow.SummaryColumns.Add(summaryColumn);

                this.sfDataGrid1.TableSummaryRows.Add(tableSummaryRow);
            }
        }

        private void sfDataGrid2_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            
        }

        private void sfDataGrid2_Click(object sender, EventArgs e)
        {
            
        }

        private void sfDataGrid2_CurrentCellActivated(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellActivatedEventArgs e)
        {
            // Get the row index value        
            var rowIndex = e.DataRow.RowIndex;
            //Get the column index value
            var columnIndex = e.DataColumn.ColumnIndex;
            //Get the cell value            
            //var celdas = sfDataGrid2.
            var currentCellValue = sfDataGrid2.CurrentCell.CellRenderer.GetControlValue();

            var recordIndex = sfDataGrid2.TableControl.ResolveToRecordIndex(rowIndex);
            var mappingName = sfDataGrid2.Columns[0].MappingName;

            var record1 = sfDataGrid2.View.Records.GetItemAt(recordIndex);
            label1.Text = (record1.GetType().GetProperty(mappingName).GetValue(record1, null).ToString());
            //materialTabControl1.TabPages[2].Parent.Visible = true;
            btnGuardar.Text = "ACTUALIZAR";
            lblIdItem.Text = "0";
            CargaPlanilla(Convert.ToInt32(label1.Text));
            CargaPlanillaDetalle();
            
            
        }

        private void sfDataGrid1_RecordDeleting(object sender, Syncfusion.WinForms.DataGrid.Events.RecordDeletingEventArgs e)
        {
            //MessageBox.Show("borrando");
        }

        private void sfDataGrid1_RecordDeleted(object sender, Syncfusion.WinForms.DataGrid.Events.RecordDeletedEventArgs e)
        {
            //MessageBox.Show(e.SelectedIndex);
        }

        private void sfDataGrid1_CurrentCellActivated(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellActivatedEventArgs e)
        {
            // Get the row index value        
            var rowIndex = e.DataRow.RowIndex;
            //Get the column index value
            var columnIndex = e.DataColumn.ColumnIndex;
            //Get the cell value            
            //var celdas = sfDataGrid2.
            var currentCellValue = sfDataGrid1.CurrentCell.CellRenderer.GetControlValue();

            var recordIndex = sfDataGrid1.TableControl.ResolveToRecordIndex(rowIndex);
            var mappingName = sfDataGrid1.Columns[0].MappingName;

            var record1 = sfDataGrid1.View.Records.GetItemAt(recordIndex);
            lblIdItem.Text = (record1.GetType().GetProperty(mappingName).GetValue(record1, null).ToString());

           
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblIdItem.Text);
            
            if(id!=0)
            {
                using (DataContext db = new DataContext())
                {
                    var items = db.PlanillaDetails
                        .FirstOrDefault(p => p.Id == id);

                    if(items==null)
                    {
                        return;
                    }
                    db.PlanillaDetails.Remove(items);
                    db.SaveChanges();

                    lblIdItem.Text = "0";
                }
            }
            
            CargaPlanillaDetalle();

        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label1.Text);

            if (id != 0)
            {
                using (DataContext db = new DataContext())
                {
                    var items = db.PlanillaDetails
                        .Where(p => p.Planilla.Id == id);

                    if (items == null)
                    {
                        return;
                    }
                    db.PlanillaDetails.RemoveRange(items);
                    db.SaveChanges();

                    lblIdItem.Text = "0";
                }
            }

            CargaPlanillaDetalle();
        }

        private void btnElimnarPlanilla_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label1.Text);

            if (id != 0)
            {

                


                using (DataContext db = new DataContext())
                {
                    var planilla = db.Planillas
                        .FirstOrDefault(p => p.Id == id);

                    if (planilla == null)
                    {
                        return;
                    }

                    if (VerificaEstadoPlanilla(planilla.Estado)=="SI")
                    {
                        MessageBox.Show("NO SE PUEDE ELIMINAR ESTA PLANILLA");
                        return;
                    }

                    var items = db.PlanillaDetails
                    .Where(p => p.Planilla.Id == id);

                    if (items == null)
                    {
                        return;
                    }
                    db.PlanillaDetails.RemoveRange(items);
                    db.SaveChanges();


                    db.Planillas.Remove(planilla);
                    db.SaveChanges();



                    label1.Text = "0";
                    lblIdItem.Text = "0";
                    sfDataGrid1.DataSource = null;
                    sfDataGrid2.DataSource = null;
                    //materialTabControl1.TabPages[0].Parent.Visible = true;
                    //materialTabControl1.TabPages[1].Parent.Visible = true;
                    //materialTabControl1.TabPages[2].Parent.Visible = false;

                    dtFechaInicio.Value = DateTime.Now;
                    dtFechaFin.Value = DateTime.Now;
                    txtDiag1.Text = "";
                    cmbD1.Text = "DEF";

                    txtDiag2.Text = "";
                    cmbD2.Text = "DEF";

                    txtDiag3.Text = "";
                    cmbD3.Text = "DEF";
                    txtDiag4.Text = "";
                    cmbD4.Text = "DEF";

                    txtCodigoDerivacion.Text = "";
                    txtSecuencial.Text = "";

                    cmbContingencia.Text = "--Seleccionar--";
                    cmbDependecia.Text = "--Seleccionar--";
                    cmbHabitacion.Text = "--Seleccionar--";
                    cmbTipo.Text = "--Seleccionar--";
                    cmbTipoSeguro.Text = "--Seleccionar--";
                    cmbBeneficiario.Text = "--Seleccionar--";
                    txtNombresTitular.Text = "";
                    txtCedulaTitular.Text = "";
                    cmbParentesco.Text = "--Seleccionar--";

                    btnGuardar.Text = "GUARDAR";


                    CargaPlanillas();
                    
                }
            }
        }
        private string VerificaEstadoPlanilla(string Estado)
        {

            using (DataContext db = new DataContext())
            {
                var items = db.EstadoPlanillas
                    .FirstOrDefault(p => p.Estado == Estado);

                if (items == null)
                {
                    return "NO";
                }
                return items.Final.Trim();
            }
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            dsetPlanillaInd dsetPlanilla = new dsetPlanillaInd();
            int id = Convert.ToInt32(label1.Text);
            using (DataContext db = new DataContext())
            {
                var paciente = db.Pacientes
                    .FirstOrDefault(p => p.Cedula == txtCedula.Text);
                    
                if (paciente == null)
                {
                    return;
                }

                var planilla = db.Planillas
                    .Include(c => c.Contigencia)
                    .Include(d => d.Dependencia)
                    .Include(h => h.Habitacion)
                    .Include(t => t.Tipo)
                    .FirstOrDefault(p => p.Id == id);

                    
                if (planilla == null)
                {
                    return;
                }
                
                var items = db.PlanillaDetails

                    .Where(p => p.Planilla.Id == id)
                    .Include(p => p.Planilla)
                    .Include(u => u.User);
                
                    
                //if (items == null)
                //{
                //    return;
                //}


                dsetPlanilla.Tables["Paciente"]
                    .Rows
                    .Add(paciente.Id, 
                        paciente.Nombres + " " + paciente.Apellidos, 
                        paciente.Cedula,
                        paciente.FechaNacimiento.ToString("dd/MM/yyyy"),
                        paciente.Genero,
                        paciente.EstadoCivil,
                        paciente.Address,
                        paciente.CellularPhone + "-"+paciente.HomePhone,
                        paciente.Email,
                        planilla.TipoBeneficiario,
                        planilla.NombresTitular,
                        planilla.CedulaTitular,
                        planilla.Parentezco,
                        paciente.edad,
                        planilla.TipoSeguro
                        );

                dsetPlanilla.Tables["Planilla"]
                        .Rows
                        .Add(planilla.Id,
                                planilla.Fecha_Inicio.ToString("dd/MM/yyyy"),
                                planilla.Fecha_Fin.ToString("dd/MM/yyyy"),
                                planilla.Diagnostico1,
                                planilla.Diagnostico2,
                                planilla.Diagnostico3,
                                planilla.Diagnostico4,
                                planilla.CIE1,
                                planilla.CIE2,
                                planilla.CIE3,
                                planilla.CIE4,
                                planilla.DiagTipo1,
                                planilla.DiagTipo2,
                                planilla.DiagTipo3,
                                planilla.DiagTipo4,
                                planilla.CodigoDerivacion,
                                planilla.Secuencial,
                                planilla.Contigencia.Descripcion,
                                planilla.Dependencia.Descripcion,
                                planilla.Habitacion.Descripcion,
                                planilla.Tipo.Descripcion,
                                planilla.Estado,
                                planilla.Fecha.ToString("dd/MM/yyyy")
                            );

                foreach (var det in items)
                {
                    dsetPlanilla.Tables["Detalles"]
                        .Rows
                        .Add(det.Id, 
                                det.Codigo, 
                                det.Nombre, 
                                det.Valor, 
                                det.TIPO_PROCEDIMIENTO, 
                                det.Cantidad, 
                                det.Medico, 
                                det.Observacion, 
                                det.Fecha.ToString("dd/MM/yyyy"), 
                                det.User.Usuario,
                                det.Valor * det.Cantidad);
                }
                
                //CrystalReportViewer.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
                rptPlanillaInd crystalReport = new rptPlanillaInd();
                
                crystalReport.SetDataSource(dsetPlanilla);
                crystalReportViewer1.ReportSource = crystalReport;
                crystalReportViewer1.RefreshReport();

            }
        }

        private void cmbBeneficiario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBeneficiario.Text =="TITULAR")
            {
                txtCedulaTitular.Visible = false;
                txtNombresTitular.Visible = false;
                cmbParentesco.Visible = false;
            }
            else
            {
                txtCedulaTitular.Visible = true;
                txtNombresTitular.Visible = true;
                cmbParentesco.Visible = true;
            }
        }
    }
}
