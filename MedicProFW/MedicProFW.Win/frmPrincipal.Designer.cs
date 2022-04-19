
namespace MedicProFW.Win
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuConfiguración = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacienteNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacienteBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanillas = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfiguración,
            this.mnuPacientes,
            this.mnuPlanillas,
            this.reportesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(626, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(3, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(626, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mnuConfiguración
            // 
            this.mnuConfiguración.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.dependenciasToolStripMenuItem,
            this.enfermedadesToolStripMenuItem,
            this.segurosToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.medicosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.mnuConfiguración.Image = global::MedicProFW.Win.Properties.Resources.tools32;
            this.mnuConfiguración.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuConfiguración.Name = "mnuConfiguración";
            this.mnuConfiguración.Size = new System.Drawing.Size(127, 36);
            this.mnuConfiguración.Text = "Configuración";
            this.mnuConfiguración.Click += new System.EventHandler(this.mnuConfiguración_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.users;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // dependenciasToolStripMenuItem
            // 
            this.dependenciasToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.dependency;
            this.dependenciasToolStripMenuItem.Name = "dependenciasToolStripMenuItem";
            this.dependenciasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dependenciasToolStripMenuItem.Text = "Dependencias";
            this.dependenciasToolStripMenuItem.Click += new System.EventHandler(this.dependenciasToolStripMenuItem_Click);
            // 
            // enfermedadesToolStripMenuItem
            // 
            this.enfermedadesToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.enfermedades;
            this.enfermedadesToolStripMenuItem.Name = "enfermedadesToolStripMenuItem";
            this.enfermedadesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.enfermedadesToolStripMenuItem.Text = "Diagnosticos";
            this.enfermedadesToolStripMenuItem.Click += new System.EventHandler(this.enfermedadesToolStripMenuItem_Click);
            // 
            // segurosToolStripMenuItem
            // 
            this.segurosToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.seguro132;
            this.segurosToolStripMenuItem.Name = "segurosToolStripMenuItem";
            this.segurosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.segurosToolStripMenuItem.Text = "Seguros";
            this.segurosToolStripMenuItem.Click += new System.EventHandler(this.segurosToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.seguro32;
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.servicio32;
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::MedicProFW.Win.Properties.Resources.tarifario32;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Tarifario";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.doctor;
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mnuPacientes
            // 
            this.mnuPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPacienteNuevo,
            this.mnuPacienteBuscar});
            this.mnuPacientes.Image = global::MedicProFW.Win.Properties.Resources.pacientes32;
            this.mnuPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.Size = new System.Drawing.Size(101, 36);
            this.mnuPacientes.Text = "Pacientes";
            // 
            // mnuPacienteNuevo
            // 
            this.mnuPacienteNuevo.Image = global::MedicProFW.Win.Properties.Resources.new16;
            this.mnuPacienteNuevo.Name = "mnuPacienteNuevo";
            this.mnuPacienteNuevo.Size = new System.Drawing.Size(137, 22);
            this.mnuPacienteNuevo.Text = "Crear/Editar";
            this.mnuPacienteNuevo.Click += new System.EventHandler(this.mnuPacienteNuevo_Click);
            // 
            // mnuPacienteBuscar
            // 
            this.mnuPacienteBuscar.Image = global::MedicProFW.Win.Properties.Resources.buscar;
            this.mnuPacienteBuscar.Name = "mnuPacienteBuscar";
            this.mnuPacienteBuscar.Size = new System.Drawing.Size(137, 22);
            this.mnuPacienteBuscar.Text = "Listar";
            this.mnuPacienteBuscar.Click += new System.EventHandler(this.mnuPacienteBuscar_Click);
            // 
            // mnuPlanillas
            // 
            this.mnuPlanillas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEditarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.mnuPlanillas.Image = global::MedicProFW.Win.Properties.Resources.Historias;
            this.mnuPlanillas.Name = "mnuPlanillas";
            this.mnuPlanillas.Size = new System.Drawing.Size(78, 36);
            this.mnuPlanillas.Text = "Planillas";
            // 
            // crearEditarToolStripMenuItem
            // 
            this.crearEditarToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.new16;
            this.crearEditarToolStripMenuItem.Name = "crearEditarToolStripMenuItem";
            this.crearEditarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.crearEditarToolStripMenuItem.Text = "Crear/Editar";
            this.crearEditarToolStripMenuItem.Click += new System.EventHandler(this.crearEditarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.buscar;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoPlanoToolStripMenuItem,
            this.planillasToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.report64;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // archivoPlanoToolStripMenuItem
            // 
            this.archivoPlanoToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.excel48;
            this.archivoPlanoToolStripMenuItem.Name = "archivoPlanoToolStripMenuItem";
            this.archivoPlanoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.archivoPlanoToolStripMenuItem.Text = "Archivo Plano";
            this.archivoPlanoToolStripMenuItem.Click += new System.EventHandler(this.archivoPlanoToolStripMenuItem_Click);
            // 
            // planillasToolStripMenuItem
            // 
            this.planillasToolStripMenuItem.Image = global::MedicProFW.Win.Properties.Resources.planillas48;
            this.planillasToolStripMenuItem.Name = "planillasToolStripMenuItem";
            this.planillasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.planillasToolStripMenuItem.Text = "Planillas";
            this.planillasToolStripMenuItem.Click += new System.EventHandler(this.planillasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuConfiguración;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuPacienteBuscar;
        private System.Windows.Forms.ToolStripMenuItem mnuPacienteNuevo;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanillas;
        private System.Windows.Forms.ToolStripMenuItem crearEditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
    }
}



