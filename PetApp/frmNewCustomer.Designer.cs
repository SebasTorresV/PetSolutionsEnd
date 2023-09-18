namespace PetApp
{
    partial class frmNewCustomer
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
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaProx = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.petAppMascota = new PetApp.PetAppMascota();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaTableAdapter = new PetApp.PetAppMascotaTableAdapters.MascotaTableAdapter();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMascota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(67, 193);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(121, 20);
            this.txtEnfermedad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enfermedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha proxima";
            // 
            // dtFechaProx
            // 
            this.dtFechaProx.CustomFormat = "";
            this.dtFechaProx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaProx.Location = new System.Drawing.Point(67, 244);
            this.dtFechaProx.Name = "dtFechaProx";
            this.dtFechaProx.Size = new System.Drawing.Size(121, 20);
            this.dtFechaProx.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(46, 275);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FechaInicial
            // 
            this.FechaInicial.CustomFormat = "";
            this.FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicial.Location = new System.Drawing.Point(67, 132);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(121, 20);
            this.FechaInicial.TabIndex = 11;
            // 
            // petAppMascota
            // 
            this.petAppMascota.DataSetName = "PetAppMascota";
            this.petAppMascota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataMember = "Mascota";
            this.mascotaBindingSource.DataSource = this.petAppMascota;
            // 
            // mascotaTableAdapter
            // 
            this.mascotaTableAdapter.ClearBeforeFill = true;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.cmbMascota);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(278, 101);
            this.grb1.TabIndex = 13;
            this.grb1.TabStop = false;
            this.grb1.Text = "Datos de la Mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota";
            // 
            // cmbMascota
            // 
            this.cmbMascota.DataSource = this.mascotaBindingSource;
            this.cmbMascota.DisplayMember = "Alias";
            this.cmbMascota.FormattingEnabled = true;
            this.cmbMascota.Location = new System.Drawing.Point(55, 49);
            this.cmbMascota.Name = "cmbMascota";
            this.cmbMascota.Size = new System.Drawing.Size(121, 21);
            this.cmbMascota.TabIndex = 1;
            this.cmbMascota.ValueMember = "Alias";
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 354);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.FechaInicial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtFechaProx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.label2);
            this.Name = "frmNewCustomer";
            this.Text = "Registros de Vacunas";
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaProx;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker FechaInicial;
        private PetAppMascota petAppMascota;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private PetAppMascotaTableAdapters.MascotaTableAdapter mascotaTableAdapter;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMascota;
    }
}