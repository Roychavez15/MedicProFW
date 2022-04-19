using ClosedXML.Excel;
using MaterialSkin.Controls;
using MedicProFW.Win.Data;
using MedicProFW.Win.Data.DataReports;
using MedicProFW.Win.Data.Entities;
using MedicProFW.Win.Models;
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
    public partial class frmArchivoPlano : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmArchivoPlano()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmArchivoPlano_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            dsetArchivoPlano archivoPlano = new dsetArchivoPlano();

            using (DataContext db = new DataContext())
            {
                DateTime desde = Convert.ToDateTime(dtDesde.Value.ToString("dd/MM/yyyy"));
                DateTime hasta = Convert.ToDateTime(dtHasta.Value.AddDays(1).ToString("dd/MM/yyyy"));
                DateTime hastar = Convert.ToDateTime(dtHasta.Value.ToString("dd/MM/yyyy"));

                var planillas = db.Planillas
                    .Where(f => f.Fecha_Inicio >= desde && f.Fecha_Inicio < hasta)
                    .Include(c => c.Contigencia)
                    .Include(d => d.Dependencia)
                    .Include(h => h.Habitacion)
                    .Include(p => p.Paciente)
                    .Include(t => t.Tipo);

                if (planillas == null)
                {

                    return;
                }
                List<PlanillasArchivoPlanoViewModel> planillasViewModels = new List<PlanillasArchivoPlanoViewModel>();

                foreach (var items in planillas)
                {

                    var detallePlanillas = DetallePlanillas(items.Id);
                    int contador = 1;

                    foreach (var detalle in detallePlanillas)
                    {
                        PlanillasArchivoPlanoViewModel planillaList = new PlanillasArchivoPlanoViewModel();
                        planillaList.Id = items.Id;
                        planillaList.Orden = contador; //todo: cambiar
                        planillaList.FechaIngreso = items.Fecha_Inicio.ToString("dd/MM/yyyy");
                        planillaList.TipoSeguro = VerificaTipoSeguro(items.TipoSeguro);
                        planillaList.IdentificacionPaciente = items.Paciente.Cedula;
                        planillaList.NombrePaciente = items.Paciente.FullName;
                        planillaList.Genero = items.Paciente.Genero.Substring(0, 1);
                        planillaList.FechaNacimiento = items.Paciente.FechaNacimiento.ToString("dd/MM/yyyy");
                        planillaList.Edad = items.Paciente.edad;
                        planillaList.TipoAtencion = items.Tipo.Codigo;
                        planillaList.Codigo = detalle.Codigo;
                        planillaList.Descripcion = detalle.Nombre;
                        planillaList.CIE101 = items.CIE1;
                        planillaList.CIE102 = items.CIE2;
                        planillaList.CIE103 = items.CIE3;
                        planillaList.Cantidad = detalle.Cantidad;
                        planillaList.Valor = detalle.Valor;
                        planillaList.Blanco1 = "";
                        var tipopaciente = "T";
                        if(items.TipoBeneficiario=="TITUTAR")
                        {
                            tipopaciente = "T";
                        }
                        else if(items.TipoBeneficiario == "CONYUGE")
                        {
                            tipopaciente = "C";
                        }
                        else if (items.TipoBeneficiario == "HIJO/HIJA")
                        {
                            tipopaciente = "H";
                        }
                        else if (items.TipoBeneficiario == "PARIENTE")
                        {
                            tipopaciente = "X";
                        }
                        else
                        {
                            tipopaciente = "";
                        }
                        planillaList.TipoPaciente = tipopaciente;
                        string IdentificacionTitular = "";
                        string NombreTitular = "";
                        if (items.TipoBeneficiario == "TITUTAR")
                        {
                            planillaList.IdentificacionTitular = items.Paciente.Cedula;
                            planillaList.NombreTitular = items.Paciente.FullName;
                            IdentificacionTitular= items.Paciente.Cedula;
                            NombreTitular = items.Paciente.FullName;
                        }
                        else
                        {
                            planillaList.IdentificacionTitular = items.CedulaTitular;
                            planillaList.NombreTitular = items.NombresTitular;
                            IdentificacionTitular = items.CedulaTitular;
                            NombreTitular = items.NombresTitular;
                        }
                        planillaList.Autorizacion = items.CodigoDerivacion;
                        planillaList.Secuencial = items.Secuencial;
                        planillaList.Uno1 = "1";
                        planillaList.D1 = "D";
                        planillaList.Blanco2 = "";
                        planillaList.Blanco3 = "";
                        planillaList.Blanco4 = "";
                        planillaList.Blanco5 = "";
                        planillaList.Blanco6 = "";
                        planillaList.Blanco7 = "";
                        planillaList.Final = "F";
                        planillasViewModels.Add(planillaList);
                        archivoPlano.Tables["Planillas"]
                            .Rows
                            .Add(items.Id,
                                contador,
                                items.Fecha_Inicio.ToString("dd/MM/yyyy"),
                                VerificaTipoSeguro(items.TipoSeguro),
                                items.Paciente.Cedula,
                                items.Paciente.FullName,
                                items.Paciente.Genero.Substring(0, 1),
                                items.Paciente.FechaNacimiento.ToString("dd/MM/yyyy"),
                                items.Paciente.edad,
                                items.Tipo.Codigo,
                                detalle.Codigo,
                                detalle.Nombre,
                                items.CIE1,
                                items.CIE2,
                                items.CIE3,
                                detalle.Cantidad,
                                detalle.Valor,
                                "",
                                tipopaciente,
                                IdentificacionTitular,
                                NombreTitular,
                                items.CodigoDerivacion,
                                items.Secuencial,
                                "1",
                                "D",
                                "",
                                "",
                                "",
                                "",
                                "",
                                "",
                                "F");

                        contador++;
                    }
                    
                }

                
                //MessageBox.Show("Listo");
                XLWorkbook wb = new XLWorkbook();
                string esc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "Excel  Files  | *.xlsx";

                wb.Worksheets.Add(archivoPlano.Tables["Planillas"], "Hoja1");

                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    wb.SaveAs(file.FileName);
                    MessageBox.Show("Archivo Exportado"); ;
                }
            }
        }
        private string VerificaTipoSeguro(string seguro)
        {

            using (DataContext db = new DataContext())
            {
                var items = db.Seguros
                    .FirstOrDefault(p => p.Descripcion == seguro);

                if (items == null)
                {
                    return "";
                }
                return items.Codigo.Trim();
            }
        }
        private List<PlanillaDetail> DetallePlanillas(int id)
        {

            using (DataContext db = new DataContext())
            {
                var items = db.PlanillaDetails
                    .Where(i => i.Planilla.Id == id);

                if (items == null)
                {
                    return null;
                }
                return items.ToList();
            }
        }
    }
}
