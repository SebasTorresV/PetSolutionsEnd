namespace PetApp
{
    partial class frmReporte
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
            this.gpbReporte = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVacuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.petAppMascota = new PetApp.PetAppMascota();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaTableAdapter = new PetApp.PetAppMascotaTableAdapters.MascotaTableAdapter();
            this.petAppMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gpbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbReporte
            // 
            this.gpbReporte.Controls.Add(this.cmbReporte);
            this.gpbReporte.Controls.Add(this.label1);
            this.gpbReporte.Controls.Add(this.button2);
            this.gpbReporte.Controls.Add(this.label2);
            this.gpbReporte.Controls.Add(this.txtVacuna);
            this.gpbReporte.Controls.Add(this.button1);
            this.gpbReporte.Location = new System.Drawing.Point(13, 13);
            this.gpbReporte.Name = "gpbReporte";
            this.gpbReporte.Size = new System.Drawing.Size(496, 133);
            this.gpbReporte.TabIndex = 0;
            this.gpbReporte.TabStop = false;
            this.gpbReporte.Text = "Reporte";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar reporte de la mascota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVacuna
            // 
            this.txtVacuna.Location = new System.Drawing.Point(0, 96);
            this.txtVacuna.Name = "txtVacuna";
            this.txtVacuna.Size = new System.Drawing.Size(241, 20);
            this.txtVacuna.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Proxima Vacunación";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mascota";
            // 
            // cmbReporte
            // 
            this.cmbReporte.DataSource = this.mascotaBindingSource1;
            this.cmbReporte.DisplayMember = "Alias";
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Location = new System.Drawing.Point(9, 38);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbReporte.TabIndex = 19;
            this.cmbReporte.ValueMember = "Alias";
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
            // petAppMascotaBindingSource
            // 
            this.petAppMascotaBindingSource.DataSource = this.petAppMascota;
            this.petAppMascotaBindingSource.Position = 0;
            // 
            // mascotaBindingSource1
            // 
            this.mascotaBindingSource1.DataMember = "Mascota";
            this.mascotaBindingSource1.DataSource = this.petAppMascotaBindingSource;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 158);
            this.Controls.Add(this.gpbReporte);
            this.Name = "frmReporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.gpbReporte.ResumeLayout(false);
            this.gpbReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVacuna;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReporte;
        private PetAppMascota petAppMascota;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private PetAppMascotaTableAdapters.MascotaTableAdapter mascotaTableAdapter;
        private System.Windows.Forms.BindingSource mascotaBindingSource1;
        private System.Windows.Forms.BindingSource petAppMascotaBindingSource;
    }
}