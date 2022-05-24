using MaterialSkin.Controls;
using MedicProFW.Win.Helpers;
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
    public partial class frmPrincipal : MaterialForm
    {
        private int childFormNumber = 0;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmPrincipal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
             frmPrincipal.ActiveForm.Text = "MedicPro                                                                                Usuario: [" + Global.UserLogin + "]";
            if(Global.UserTipo!="Administrador")
            {
                usuariosToolStripMenuItem.Enabled = false;
                dependenciasToolStripMenuItem.Enabled = false;
                enfermedadesToolStripMenuItem.Enabled = false;
                segurosToolStripMenuItem.Enabled = false;
                habitacionesToolStripMenuItem.Enabled = false;
                serviciosToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                medicosToolStripMenuItem.Enabled = false;
            }
        }

        private void mnuConfigracion_Click(object sender, EventArgs e)
        {

        }

        private void mnuConfiguración_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuPacienteBuscar_Click(object sender, EventArgs e)
        {
            frmListaPacientes childForm = new frmListaPacientes();
            childForm.MdiParent = this;
            childForm.Text = "Lista Pacientes";

            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void mnuPacienteNuevo_Click(object sender, EventArgs e)
        {
            frmPacienteNuevo childForm = new frmPacienteNuevo();
            childForm.MdiParent = this;
            childForm.Text = "Crear Pacientes";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void crearEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacienteBuscar childForm = new frmPacienteBuscar();
            childForm.MdiParent = this;
            childForm.Text = "Crear-Editar Planillas";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dependenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDependencias childForm = new frmDependencias();
            childForm.MdiParent = this;
            childForm.Text = "Dependencias";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void enfermedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiagnosticos childForm = new frmDiagnosticos();
            childForm.MdiParent = this;
            childForm.Text = "Diagnosticos";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicios childForm = new frmServicios();
            childForm.MdiParent = this;
            childForm.Text = "Servicios";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void segurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguros childForm = new frmSeguros();
            childForm.MdiParent = this;
            childForm.Text = "Seguros";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTarifario childForm = new frmTarifario();
            childForm.MdiParent = this;
            childForm.Text = "Tarifario";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaPlanilla childForm = new frmListaPlanilla();
            childForm.MdiParent = this;
            childForm.Text = "Planillas";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void planillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePlanillas childForm = new frmReportePlanillas();
            childForm.MdiParent = this;
            childForm.Text = "Reporte Planillas";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion childForm = new frmHabitacion();
            childForm.MdiParent = this;
            childForm.Text = "Habitaciones";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios childForm = new frmUsuarios();
            childForm.MdiParent = this;
            childForm.Text = "Usuarios";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicos childForm = new frmMedicos();
            childForm.MdiParent = this;
            childForm.Text = "Medicos";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void archivoPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivoPlano childForm = new frmArchivoPlano();
            childForm.MdiParent = this;
            childForm.Text = "Archivo Plano";
            childForm.Show();
            childForm.Top = 0;
            childForm.Left = 0;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }
    }
}
