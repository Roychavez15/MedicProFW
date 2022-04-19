
namespace MedicProFW.Win
{
    partial class frmPacienteNuevo
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
            this.txtCedula = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstadoCivil = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar1 = new MaterialSkin.Controls.MaterialButton();
            this.txtCelular = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.AnimateReadOnly = false;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Depth = 0;
            this.txtCedula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCedula.Hint = "Identificación";
            this.txtCedula.LeadingIcon = null;
            this.txtCedula.Location = new System.Drawing.Point(17, 77);
            this.txtCedula.MaxLength = 50;
            this.txtCedula.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCedula.Multiline = false;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(179, 36);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Text = "";
            this.txtCedula.TrailingIcon = null;
            this.txtCedula.UseTallSize = false;
            // 
            // txtNombres
            // 
            this.txtNombres.AnimateReadOnly = false;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Depth = 0;
            this.txtNombres.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombres.Hint = "Nombres";
            this.txtNombres.LeadingIcon = null;
            this.txtNombres.Location = new System.Drawing.Point(17, 119);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombres.Multiline = false;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(254, 36);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.Text = "";
            this.txtNombres.TrailingIcon = null;
            this.txtNombres.UseTallSize = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AnimateReadOnly = false;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.Hint = "Apellidos";
            this.txtApellidos.LeadingIcon = null;
            this.txtApellidos.Location = new System.Drawing.Point(286, 119);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidos.Multiline = false;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(254, 36);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Text = "";
            this.txtApellidos.TrailingIcon = null;
            this.txtApellidos.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 171);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Fecha de Nacimiento:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(177, 171);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(266, 20);
            this.dtFechaNacimiento.TabIndex = 6;
            // 
            // cmbGenero
            // 
            this.cmbGenero.AutoResize = false;
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGenero.Depth = 0;
            this.cmbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGenero.DropDownHeight = 118;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.DropDownWidth = 121;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.IntegralHeight = false;
            this.cmbGenero.ItemHeight = 29;
            this.cmbGenero.Items.AddRange(new object[] {
            "--Seleccionar--",
            "MASCULINO",
            "FEMENINO"});
            this.cmbGenero.Location = new System.Drawing.Point(177, 203);
            this.cmbGenero.MaxDropDownItems = 4;
            this.cmbGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(266, 35);
            this.cmbGenero.StartIndex = 0;
            this.cmbGenero.TabIndex = 7;
            this.cmbGenero.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 213);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Genero:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 248);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Estado Civil:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.AutoResize = false;
            this.cmbEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstadoCivil.Depth = 0;
            this.cmbEstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstadoCivil.DropDownHeight = 118;
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.DropDownWidth = 121;
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.IntegralHeight = false;
            this.cmbEstadoCivil.ItemHeight = 29;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "--Seleccionar--",
            "SOLTERO(A)",
            "CASADO(A)",
            "VIUDO(A)",
            "UNION LIBRE"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(177, 244);
            this.cmbEstadoCivil.MaxDropDownItems = 4;
            this.cmbEstadoCivil.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(266, 35);
            this.cmbEstadoCivil.StartIndex = 0;
            this.cmbEstadoCivil.TabIndex = 12;
            this.cmbEstadoCivil.UseTallSize = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Image = global::MedicProFW.Win.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(33, 522);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar1.Depth = 0;
            this.btnGuardar1.HighEmphasis = true;
            this.btnGuardar1.Icon = global::MedicProFW.Win.Properties.Resources.guardar;
            this.btnGuardar1.Location = new System.Drawing.Point(252, 513);
            this.btnGuardar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar1.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar1.TabIndex = 14;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar1.UseAccentColor = false;
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.AnimateReadOnly = false;
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Depth = 0;
            this.txtCelular.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular.LeadingIcon = null;
            this.txtCelular.Location = new System.Drawing.Point(177, 398);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(266, 50);
            this.txtCelular.TabIndex = 35;
            this.txtCelular.Text = "";
            this.txtCelular.TrailingIcon = null;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.Location = new System.Drawing.Point(14, 394);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(54, 19);
            this.materialLabel26.TabIndex = 34;
            this.materialLabel26.Text = "Celular:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(177, 342);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(266, 50);
            this.txtTelefono.TabIndex = 33;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.Location = new System.Drawing.Point(14, 338);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(68, 19);
            this.materialLabel25.TabIndex = 32;
            this.materialLabel25.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(177, 285);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(266, 50);
            this.txtDireccion.TabIndex = 31;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(17, 287);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 19);
            this.materialLabel9.TabIndex = 30;
            this.materialLabel9.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(177, 454);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(266, 50);
            this.txtCorreo.TabIndex = 37;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 450);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "Correo:";
            // 
            // frmPacienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.materialLabel26);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.materialLabel25);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCedula);
            this.Name = "frmPacienteNuevo";
            this.Text = "Crear Paciente";
            this.Load += new System.EventHandler(this.frmPacienteNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCedula;
        private MaterialSkin.Controls.MaterialTextBox txtNombres;
        private MaterialSkin.Controls.MaterialTextBox txtApellidos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private MaterialSkin.Controls.MaterialComboBox cmbGenero;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbEstadoCivil;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnGuardar1;
        private MaterialSkin.Controls.MaterialTextBox txtCelular;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}