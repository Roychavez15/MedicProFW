using MaterialSkin.Controls;
using MedicProFW.Win.Data;
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
    public partial class frmListaPlanilla : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmListaPlanilla()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void frmListaPlanilla_Load(object sender, EventArgs e)
        {
            this.sfDataGrid1.DataSource = null;
            sfDataGrid1.AllowFiltering = true;
            sfDataGrid1.AllowSorting = true;
            sfDataGrid1.ShowGroupDropArea = true;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                DateTime desde = Convert.ToDateTime(dtDesde.Value.ToString("dd/MM/yyyy"));
                DateTime hasta = Convert.ToDateTime(dtHasta.Value.AddDays(1).ToString("dd/MM/yyyy"));

                var planillas = db.Planillas
                    .Where(f => f.Fecha_Inicio>=desde && f.Fecha_Inicio < hasta)
                    .Include(c => c.Contigencia)
                    .Include(d => d.Dependencia)
                    .Include(h => h.Habitacion)
                    .Include(p => p.Paciente)
                    .Include(t => t.Tipo);

                if (planillas == null)
                {
                    this.sfDataGrid1.DataSource=null;
                    return;
                }
                List<PlanillasViewModel> planillasViewModels = new List<PlanillasViewModel>();

                foreach(var items in planillas)
                {
                    PlanillasViewModel planillaList = new PlanillasViewModel();
                    planillaList.Id = items.Id;
                    planillaList.Paciente = items.Paciente.Nombres + " " + items.Paciente.Apellidos;
                    planillaList.Seguro = items.TipoSeguro;
                    planillaList.CIE = items.CIE1;
                    planillaList.Ingreso = items.Fecha_Inicio;
                    planillaList.Salida = items.Fecha_Fin;
                    planillaList.Cedula = items.Paciente.Cedula;
                    planillaList.Estado = items.Estado;                    
                    planillaList.Valor = ValorPlanilla(items.Id); 
                    planillasViewModels.Add(planillaList);
                }
                this.sfDataGrid1.DataSource = planillasViewModels.ToList();
            }
        }
        private decimal ValorPlanilla(int planilla)
        {
            decimal valor = 0M;
            using (DataContext db = new DataContext())
            {
                var detalles = db.PlanillaDetails
                                    .Where(p => p.Planilla.Id == planilla);

                foreach (var val in detalles)
                {
                    valor = valor + (val.Cantidad * val.Valor);
                }
            }
            return valor;
        }
    }
}
